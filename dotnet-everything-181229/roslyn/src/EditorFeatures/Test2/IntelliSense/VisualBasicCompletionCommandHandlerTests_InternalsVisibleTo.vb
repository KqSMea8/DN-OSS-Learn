﻿' Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

Imports System.Threading.Tasks

Namespace Microsoft.CodeAnalysis.Editor.UnitTests.IntelliSense

    <[UseExportProvider]>
    Public Class VisualBasicCompletionCommandHandlerTests_InternalsVisibleTo
        Public Shared ReadOnly Property AllCompletionImplementations() As IEnumerable(Of Object())
            Get
                Return TestStateFactory.GetAllCompletionImplementations()
            End Get
        End Property

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function CodeCompletionContainsOtherAssembliesOfSolution(completionImplementation As CompletionImplementation) As Task
            Using state = TestStateFactory.CreateTestStateFromWorkspace(completionImplementation,
                <Workspace>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary1"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary2"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary3"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="TestAssembly">
                        <Document FilePath="A.vb"><![CDATA[
<Assembly: System.Runtime.CompilerServices.InternalsVisibleTo("$$
]]>
                        </Document>
                    </Project>
                </Workspace>)
                state.SendInvokeCompletionList()
                Await state.AssertCompletionSession()
                Assert.True(state.CompletionItemsContainsAll({"ClassLibrary1", "ClassLibrary2", "ClassLibrary3"}))
            End Using
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function CodeCompletionContainsOtherAssemblyIfAttributeSuffixIsPresent(completionImplementation As CompletionImplementation) As Task
            Using state = TestStateFactory.CreateTestStateFromWorkspace(completionImplementation,
                <Workspace>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary1"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="TestAssembly">
                        <Document FilePath="A.vb"><![CDATA[
<Assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute("$$
]]>
                        </Document>
                    </Project>
                </Workspace>)
                state.SendInvokeCompletionList()
                Await state.AssertCompletionSession()
                Assert.True(state.CompletionItemsContainsAll({"ClassLibrary1"}))
            End Using
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function CodeCompletionIsTriggeredWhenDoubleQuoteIsEntered(completionImplementation As CompletionImplementation) As Task
            Using state = TestStateFactory.CreateTestStateFromWorkspace(completionImplementation,
                <Workspace>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary1"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="TestAssembly">
                        <Document FilePath="A.vb"><![CDATA[
<Assembly: System.Runtime.CompilerServices.InternalsVisibleTo($$
]]>
                        </Document>
                    </Project>
                </Workspace>)
                Await state.AssertNoCompletionSession()
                state.SendTypeChars(""""c)
                Await state.AssertCompletionSession()
                Assert.True(state.CompletionItemsContainsAll({"ClassLibrary1"}))
            End Using
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function CodeCompletionIsEmptyUntilDoubleQuotesAreEntered(completionImplementation As CompletionImplementation) As Task
            Using state = TestStateFactory.CreateTestStateFromWorkspace(completionImplementation,
                <Workspace>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary1"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="TestAssembly">
                        <Document FilePath="A.vb"><![CDATA[
<Assembly: System.Runtime.CompilerServices.InternalsVisibleTo$$
]]>
                        </Document>
                    </Project>
                </Workspace>)
                Await state.AssertNoCompletionSession()
                state.SendInvokeCompletionList()
                Await state.WaitForAsynchronousOperationsAsync()
                Assert.False(state.CompletionItemsContainsAny({"ClassLibrary1"}))
                state.SendTypeChars("("c)
                Await state.WaitForAsynchronousOperationsAsync()
                state.SendInvokeCompletionList()
                Await state.WaitForAsynchronousOperationsAsync()
                Assert.False(state.CompletionItemsContainsAny({"ClassLibrary1"}))
                state.SendTypeChars(""""c)
                Await state.AssertCompletionSession()
                Assert.True(state.CompletionItemsContainsAll({"ClassLibrary1"}))
            End Using
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function CodeCompletionIsTriggeredWhenCharacterIsEnteredAfterOpeningDoubleQuote(completionImplementation As CompletionImplementation) As Task
            Using state = TestStateFactory.CreateTestStateFromWorkspace(completionImplementation,
                <Workspace>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary1"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="TestAssembly">
                        <Document FilePath="A.vb"><![CDATA[
<Assembly: System.Runtime.CompilerServices.InternalsVisibleTo("$$")>
]]>
                        </Document>
                    </Project>
                </Workspace>)
                Await state.AssertNoCompletionSession()
                state.SendTypeChars("a"c)
                Await state.AssertCompletionSession()
                Assert.True(state.CompletionItemsContainsAll({"ClassLibrary1"}))
            End Using
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function CodeCompletionIsNotTriggeredWhenCharacterIsEnteredThatIsNotRightBesideTheOpeniningDoubleQuote(completionImplementation As CompletionImplementation) As Task
            Using state = TestStateFactory.CreateTestStateFromWorkspace(completionImplementation,
                <Workspace>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary1"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="TestAssembly">
                        <Document FilePath="A.vb"><![CDATA[
<Assembly: System.Runtime.CompilerServices.InternalsVisibleTo("a$$")>
]]>
                        </Document>
                    </Project>
                </Workspace>)
                Await state.AssertNoCompletionSession()
                state.SendTypeChars("b"c)
                Await state.AssertNoCompletionSession()
            End Using
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function CodeCompletionIsNotTriggeredWhenDoubleQuoteIsEnteredAtStartOfFile(completionImplementation As CompletionImplementation) As Task
            Using state = TestStateFactory.CreateTestStateFromWorkspace(completionImplementation,
                <Workspace>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary1"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="TestAssembly">
                        <Document FilePath="A.vb">$$
                        </Document>
                    </Project>
                </Workspace>)
                Await state.AssertNoCompletionSession()
                state.SendTypeChars("a"c)
                Await state.WaitForAsynchronousOperationsAsync()
                Assert.False(state.CompletionItemsContainsAny({"ClassLibrary1"}))
            End Using
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function CodeCompletionIsNotTriggeredByArrayElementAccess(completionImplementation As CompletionImplementation) As Task
            Using state = TestStateFactory.CreateTestStateFromWorkspace(completionImplementation,
                <Workspace>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary1"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="TestAssembly">
                        <Document FilePath="A.vb"><![CDATA[
Namespace A
	Public Class C
		Public Sub M()
			Dim d = New System.Collections.Generic.Dictionary(Of String, String)()
			Dim v = d$$
		End Sub
	End Class
End Namespace
]]>
                        </Document>
                    </Project>
                </Workspace>)
                Dim AssertNoCompletionAndCompletionDoesNotContainClassLibrary1 As Func(Of Task) =
                    Async Function()
                        Await state.AssertNoCompletionSession()
                        state.SendInvokeCompletionList()
                        Await state.WaitForAsynchronousOperationsAsync()
                        Assert.True(
                            state.CurrentCompletionPresenterSession Is Nothing OrElse
                            Not state.CompletionItemsContainsAny({"ClassLibrary1"}))
                    End Function
                Await AssertNoCompletionAndCompletionDoesNotContainClassLibrary1()
                state.SendTypeChars("("c)
                Await state.WaitForAsynchronousOperationsAsync()
                Assert.False(state.CompletionItemsContainsAny({"ClassLibrary1"}))
                state.SendTypeChars(""""c)
                Await AssertNoCompletionAndCompletionDoesNotContainClassLibrary1()
            End Using
        End Function

        Private Async Function AssertCompletionListHasItems(completionImplementation As CompletionImplementation, code As String, hasItems As Boolean) As Task
            Using state = TestStateFactory.CreateTestStateFromWorkspace(completionImplementation,
                <Workspace>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary1"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="TestAssembly">
                        <Document FilePath="A.vb">
Imports System.Runtime.CompilerServices
Imports System.Reflection
<%= code %>
                        </Document>
                    </Project>
                </Workspace>)
                state.SendInvokeCompletionList()
                Await state.WaitForAsynchronousOperationsAsync()
                If hasItems Then
                    Await state.AssertCompletionSession()
                    Assert.True(state.CompletionItemsContainsAll({"ClassLibrary1"}))
                Else
                    If Not state.CurrentCompletionPresenterSession Is Nothing Then
                        Assert.False(state.CompletionItemsContainsAny({"ClassLibrary1"}))
                    End If
                End If
            End Using
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function AssertCompletionListHasItems_AfterSingleDoubleQuoteAndClosing(completionImplementation As CompletionImplementation) As Task
            Await AssertCompletionListHasItems(completionImplementation, "<Assembly: InternalsVisibleTo(""$$)>", True)
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function AssertCompletionListHasItems_AfterText(completionImplementation As CompletionImplementation) As Task
            Await AssertCompletionListHasItems(completionImplementation, "<Assembly: InternalsVisibleTo(""Test$$)>", True)
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function AssertCompletionListHasItems_IfCursorIsInSecondParameter(completionImplementation As CompletionImplementation) As Task
            Await AssertCompletionListHasItems(completionImplementation, "<Assembly: InternalsVisibleTo(""Test"", ""$$", True)
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function AssertCompletionListHasNoItems_IfCursorIsClosingDoubleQuote1(completionImplementation As CompletionImplementation) As Task
            Await AssertCompletionListHasItems(completionImplementation, "<Assembly: InternalsVisibleTo(""Test""$$", False)
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function AssertCompletionListHasNoItems_IfCursorIsClosingDoubleQuote2(completionImplementation As CompletionImplementation) As Task
            Await AssertCompletionListHasItems(completionImplementation, "<Assembly: InternalsVisibleTo(""""$$", False)
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function AssertCompletionListHasItems_IfNamedParameterIsPresent(completionImplementation As CompletionImplementation) As Task
            Await AssertCompletionListHasItems(completionImplementation, "<Assembly: InternalsVisibleTo(""$$, AllInternalsVisible:=True)>", True)
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function AssertCompletionListHasNoItems_IfNumberIsEntered(completionImplementation As CompletionImplementation) As Task
            Await AssertCompletionListHasItems(completionImplementation, "<Assembly: InternalsVisibleTo(1$$2)>", False)
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function AssertCompletionListHasNoItems_IfNotInternalsVisibleToAttribute(completionImplementation As CompletionImplementation) As Task
            Await AssertCompletionListHasItems(completionImplementation, "<Assembly: AssemblyVersion(""$$"")>", False)
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function AssertCompletionListHasItems_IfOtherAttributeIsPresent1(completionImplementation As CompletionImplementation) As Task
            Await AssertCompletionListHasItems(completionImplementation, "<Assembly: AssemblyVersion(""1.0.0.0""), InternalsVisibleTo(""$$", True)
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function AssertCompletionListHasItems_IfOtherAttributeIsPresent2(completionImplementation As CompletionImplementation) As Task
            Await AssertCompletionListHasItems(completionImplementation, "<Assembly: InternalsVisibleTo(""$$""), AssemblyVersion(""1.0.0.0"")>", True)
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function AssertCompletionListHasItems_IfOtherAttributesAreAhead(completionImplementation As CompletionImplementation) As Task
            Await AssertCompletionListHasItems(completionImplementation, "
                <Assembly: AssemblyVersion(""1.0.0.0"")>
                <Assembly: InternalsVisibleTo(""$$", True)
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function AssertCompletionListHasItems_IfOtherAttributesAreFollowing(completionImplementation As CompletionImplementation) As Task
            Await AssertCompletionListHasItems(completionImplementation, "
            <Assembly: InternalsVisibleTo(""$$
            <Assembly: AssemblyVersion(""1.0.0.0"")>
            <Assembly: AssemblyCompany(""Test"")>", True)
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function AssertCompletionListHasItems_IfNamespaceIsFollowing(completionImplementation As CompletionImplementation) As Task
            Await AssertCompletionListHasItems(completionImplementation, "
            <Assembly: InternalsVisibleTo(""$$
            Namespace A             
                Public Class A
                End Class
            End Namespace", True)
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function CodeCompletionHasItemsIfInteralVisibleToIsReferencedByTypeAlias(completionImplementation As CompletionImplementation) As Task
            Using state = TestStateFactory.CreateTestStateFromWorkspace(completionImplementation,
                <Workspace>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary1"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="TestAssembly">
                        <Document FilePath="A.vb"><![CDATA[
Imports IVT = System.Runtime.CompilerServices.InternalsVisibleToAttribute
<Assembly: IVT("$$
]]>
                        </Document>
                    </Project>
                </Workspace>)
                state.SendInvokeCompletionList()
                Await state.AssertCompletionSession()
                Assert.True(state.CompletionItemsContainsAll({"ClassLibrary1"}))
            End Using
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function CodeCompletionDoesNotContainCurrentAssembly(completionImplementation As CompletionImplementation) As Task
            Using state = TestStateFactory.CreateTestStateFromWorkspace(completionImplementation,
                <Workspace>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary1"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="TestAssembly">
                        <Document FilePath="A.vb"><![CDATA[
<Assembly: System.Runtime.CompilerServices.InternalsVisibleTo("$$")>
]]>
                        </Document>
                    </Project>
                </Workspace>)
                state.SendInvokeCompletionList()
                Await state.AssertCompletionSession()
                Assert.False(state.CompletionItemsContainsAny({"TestAssembly"}))
            End Using
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function CodeCompletionInsertsAssemblyNameOnCommit(completionImplementation As CompletionImplementation) As Task
            Using state = TestStateFactory.CreateTestStateFromWorkspace(completionImplementation,
                <Workspace>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary1">
                    </Project>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="TestAssembly">
                        <Document><![CDATA[
<Assembly: System.Runtime.CompilerServices.InternalsVisibleTo("$$")>
]]>
                        </Document>
                    </Project>
                </Workspace>)
                state.SendInvokeCompletionList()
                Await state.AssertSelectedCompletionItem("ClassLibrary1")
                state.SendTab()
                Await state.WaitForAsynchronousOperationsAsync()
                state.AssertMatchesTextStartingAtLine(1, "<Assembly: System.Runtime.CompilerServices.InternalsVisibleTo(""ClassLibrary1"")>")
            End Using
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function CodeCompletionInsertsPublicKeyOnCommit(completionImplementation As CompletionImplementation) As Task
            Using state = TestStateFactory.CreateTestStateFromWorkspace(completionImplementation,
                <Workspace>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary1">
                        <CompilationOptions
                            CryptoKeyFile=<%= SigningTestHelpers.PublicKeyFile %>
                            StrongNameProvider=<%= SigningTestHelpers.s_defaultDesktopProvider.GetType().AssemblyQualifiedName %>/>
                    </Project>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="TestAssembly">
                        <Document><![CDATA[
<Assembly: System.Runtime.CompilerServices.InternalsVisibleTo("$$")>
]]>
                        </Document>
                    </Project>
                </Workspace>)
                state.SendInvokeCompletionList()
                Await state.AssertSelectedCompletionItem("ClassLibrary1")
                state.SendTab()
                Await state.WaitForAsynchronousOperationsAsync()
                state.AssertMatchesTextStartingAtLine(1, "<Assembly: System.Runtime.CompilerServices.InternalsVisibleTo(""ClassLibrary1, PublicKey=00240000048000009400000006020000002400005253413100040000010001002b986f6b5ea5717d35c72d38561f413e267029efa9b5f107b9331d83df657381325b3a67b75812f63a9436ceccb49494de8f574f8e639d4d26c0fcf8b0e9a1a196b80b6f6ed053628d10d027e032df2ed1d60835e5f47d32c9ef6da10d0366a319573362c821b5f8fa5abc5bb22241de6f666a85d82d6ba8c3090d01636bd2bb"")>")
            End Using
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function CodeCompletionContainsPublicKeyIfKeyIsSpecifiedByAttribute(completionImplementation As CompletionImplementation) As Task
            Using state = TestStateFactory.CreateTestStateFromWorkspace(completionImplementation,
                <Workspace>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary1">
                        <CompilationOptions
                            StrongNameProvider=<%= SigningTestHelpers.s_defaultDesktopProvider.GetType().AssemblyQualifiedName %>/>
                        <Document>
                            &lt;Assembly: System.Reflection.AssemblyKeyFile("<%= SigningTestHelpers.PublicKeyFile %>")&gt;
                        </Document>
                    </Project>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="TestAssembly">
                        <Document><![CDATA[
<Assembly: System.Runtime.CompilerServices.InternalsVisibleTo("$$")>
]]>
                        </Document>
                    </Project>
                </Workspace>)
                state.SendInvokeCompletionList()
                Await state.AssertSelectedCompletionItem("ClassLibrary1")
                state.SendTab()
                Await state.WaitForAsynchronousOperationsAsync()
                state.AssertMatchesTextStartingAtLine(1, "<Assembly: System.Runtime.CompilerServices.InternalsVisibleTo(""ClassLibrary1, PublicKey=00240000048000009400000006020000002400005253413100040000010001002b986f6b5ea5717d35c72d38561f413e267029efa9b5f107b9331d83df657381325b3a67b75812f63a9436ceccb49494de8f574f8e639d4d26c0fcf8b0e9a1a196b80b6f6ed053628d10d027e032df2ed1d60835e5f47d32c9ef6da10d0366a319573362c821b5f8fa5abc5bb22241de6f666a85d82d6ba8c3090d01636bd2bb"")>")
            End Using
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function CodeCompletionContainsPublicKeyIfDelayedSigningIsEnabled(completionImplementation As CompletionImplementation) As Task
            Using state = TestStateFactory.CreateTestStateFromWorkspace(completionImplementation,
                <Workspace>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary1">
                        <CompilationOptions
                            CryptoKeyFile=<%= SigningTestHelpers.PublicKeyFile %>
                            StrongNameProvider=<%= SigningTestHelpers.s_defaultDesktopProvider.GetType().AssemblyQualifiedName %>/>
                            DelaySign="True"
                        />
                    </Project>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="TestAssembly">
                        <Document><![CDATA[
<Assembly: System.Runtime.CompilerServices.InternalsVisibleTo("$$")>
]]>
                        </Document>
                    </Project>
                </Workspace>)
                state.SendInvokeCompletionList()
                Await state.AssertSelectedCompletionItem("ClassLibrary1")
                state.SendTab()
                Await state.WaitForAsynchronousOperationsAsync()
                state.AssertMatchesTextStartingAtLine(1, "<Assembly: System.Runtime.CompilerServices.InternalsVisibleTo(""ClassLibrary1, PublicKey=00240000048000009400000006020000002400005253413100040000010001002b986f6b5ea5717d35c72d38561f413e267029efa9b5f107b9331d83df657381325b3a67b75812f63a9436ceccb49494de8f574f8e639d4d26c0fcf8b0e9a1a196b80b6f6ed053628d10d027e032df2ed1d60835e5f47d32c9ef6da10d0366a319573362c821b5f8fa5abc5bb22241de6f666a85d82d6ba8c3090d01636bd2bb"")>")
            End Using
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function CodeCompletionListIsEmptyIfAttributeIsNotTheBCLAttribute(completionImplementation As CompletionImplementation) As Task
            Using state = TestStateFactory.CreateTestStateFromWorkspace(completionImplementation,
                <Workspace>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary1"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="TestAssembly">
                        <Document FilePath="A.vb"><![CDATA[
<Assembly: Test.InternalsVisibleTo("$$")>
Namespace Test
	<System.AttributeUsage(System.AttributeTargets.Assembly)> _
	Public NotInheritable Class InternalsVisibleToAttribute
		Inherits System.Attribute

		Public Sub New(ignore As String)
		End Sub
	End Class
End Namespace
]]>
                        </Document>
                    </Project>
                </Workspace>)
                state.SendInvokeCompletionList()
                Await state.AssertNoCompletionSession()
            End Using
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function CodeCompletionContainsOnlyAssembliesThatAreNotAlreadyIVT(completionImplementation As CompletionImplementation) As Task
            Using state = TestStateFactory.CreateTestStateFromWorkspace(completionImplementation,
                <Workspace>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary1"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary2"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary3"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="TestAssembly">
                        <Document FilePath="A.vb"><![CDATA[
<Assembly: System.Runtime.CompilerServices.InternalsVisibleTo("ClassLibrary1")>
<Assembly: System.Runtime.CompilerServices.InternalsVisibleTo("ClassLibrary2")>
<Assembly: System.Runtime.CompilerServices.InternalsVisibleTo("$$
]]>
                        </Document>
                    </Project>
                </Workspace>)
                state.SendInvokeCompletionList()
                Await state.AssertCompletionSession()
                Assert.False(state.CompletionItemsContainsAny({"ClassLibrary1", "ClassLibrary2"}))
                Assert.True(state.CompletionItemsContainsAll({"ClassLibrary3"}))
            End Using
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function CodeCompletionContainsOnlyAssembliesThatAreNotAlreadyIVTIfAssemblyNameIsAConstant(completionImplementation As CompletionImplementation) As Task
            Using state = TestStateFactory.CreateTestStateFromWorkspace(completionImplementation,
                <Workspace>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary1"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary2"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary3"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="TestAssembly">
                        <MetadataReferenceFromSource Language="Visual Basic" CommonReferences="true">
                            <Document FilePath="ReferencedDocument.vb">
Namespace A
	Public NotInheritable Class Constants
		Private Sub New()
		End Sub
		Public Const AssemblyName1 As String = "ClassLibrary1"
	End Class
End Namespace                            
                            </Document>
                        </MetadataReferenceFromSource>
                        <Document FilePath="A.vb"><![CDATA[
<Assembly: System.Runtime.CompilerServices.InternalsVisibleTo(A.Constants.AssemblyName1)>
<Assembly: System.Runtime.CompilerServices.InternalsVisibleTo("ClassLibrary2")>
<Assembly: System.Runtime.CompilerServices.InternalsVisibleTo("$$
]]>
                        </Document>
                    </Project>
                </Workspace>)
                state.SendInvokeCompletionList()
                Await state.AssertCompletionSession()
                Assert.False(state.CompletionItemsContainsAny({"ClassLibrary1", "ClassLibrary2"}))
                Assert.True(state.CompletionItemsContainsAll({"ClassLibrary3"}))
            End Using
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function CodeCompletionContainsOnlyAssembliesThatAreNotAlreadyIVTForDifferentSyntax(completionImplementation As CompletionImplementation) As Task
            Using state = TestStateFactory.CreateTestStateFromWorkspace(completionImplementation,
                <Workspace>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary1"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary2"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary3"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary4"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary5"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary6"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary7"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary8"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="TestAssembly">
                        <Document FilePath="A.vb"><![CDATA[
' Code comment
Imports System.Runtime.CompilerServices
Imports System.Reflection
Imports IVT = System.Runtime.CompilerServices.InternalsVisibleToAttribute
' Code comment
<Assembly: InternalsVisibleTo("ClassLibrary1", AllInternalsVisible:=True)>
<Assembly: AssemblyVersion("1.0.0.0"), Assembly: InternalsVisibleTo("ClassLibrary2")>
<Assembly: InternalsVisibleTo("ClassLibrary3"), Assembly: AssemblyCopyright("Copyright")>
<Assembly: AssemblyDescription("Description")>
<Assembly: InternalsVisibleTo("ClassLibrary4")>
<Assembly: InternalsVisibleTo("ClassLibrary5, PublicKey=00240000048000009400000006020000002400005253413100040000010001002b986f6b5ea5717d35c72d38561f413e267029efa9b5f107b9331d83df657381325b3a67b75812f63a9436ceccb49494de8f574f8e639d4d26c0fcf8b0e9a1a196b80b6f6ed053628d10d027e032df2ed1d60835e5f47d32c9ef6da10d0366a319573362c821b5f8fa5abc5bb22241de6f666a85d82d6ba8c3090d01636bd2bb")>
<Assembly: InternalsVisibleTo("ClassLibrary" + "6")>
<Assembly: IVT("ClassLibrary7")>
<Assembly: InternalsVisibleTo("$$
Namespace A
    Public Class A
End Class
]]>
                        </Document>
                    </Project>
                </Workspace>)
                state.SendInvokeCompletionList()
                Await state.AssertCompletionSession()
                Assert.False(state.CompletionItemsContainsAny({"ClassLibrary1", "ClassLibrary2", "ClassLibrary3", "ClassLibrary4", "ClassLibrary5", "ClassLibrary6", "ClassLibrary7"}))
                Assert.True(state.CompletionItemsContainsAll({"ClassLibrary8"}))
            End Using
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function CodeCompletionContainsOnlyAssembliesThatAreNotAlreadyIVTWithSyntaxError(completionImplementation As CompletionImplementation) As Task
            Using state = TestStateFactory.CreateTestStateFromWorkspace(completionImplementation,
                <Workspace>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary1"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="TestAssembly">
                        <Document FilePath="A.vb"><![CDATA[
Imports System.Runtime.CompilerServices
Imports System.Reflection

<Assembly: InternalsVisibleTo("ClassLibrary" + 1.ToString())> ' Not a constant
<Assembly: InternalsVisibleTo("$$
]]>
                        </Document>
                    </Project>
                </Workspace>)
                state.SendInvokeCompletionList()
                Await state.AssertCompletionSession()
                ' ClassLibrary1 must be listed because the existing attribute argument can't be resolved to a constant.
                Assert.True(state.CompletionItemsContainsAll({"ClassLibrary1"}))
            End Using
        End Function

        <MemberData(NameOf(AllCompletionImplementations))> <WpfTheory, Trait(Traits.Feature, Traits.Features.Completion)>
        Public Async Function CodeCompletionContainsOnlyAssembliesThatAreNotAlreadyIVTWithMoreThanOneDocument(completionImplementation As CompletionImplementation) As Task
            Using state = TestStateFactory.CreateTestStateFromWorkspace(completionImplementation,
                <Workspace>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary1"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="ClassLibrary2"/>
                    <Project Language="Visual Basic" CommonReferences="true" AssemblyName="TestAssembly">
                        <Document FilePath="OtherDocument.vb"><![CDATA[
Imports System.Runtime.CompilerServices
Imports System.Reflection
<Assembly: InternalsVisibleTo("ClassLibrary1")>
<Assembly: AssemblyDescription("Description")>
]]>
                        </Document>
                        <Document FilePath="A.vb"><![CDATA[
Imports System.Runtime.CompilerServices
Imports System.Reflection
<Assembly: InternalsVisibleTo("$$
]]>
                        </Document>
                    </Project>
                </Workspace>)
                state.SendInvokeCompletionList()
                Await state.AssertCompletionSession()
                Assert.False(state.CompletionItemsContainsAny({"ClassLibrary1"}))
                Assert.True(state.CompletionItemsContainsAll({"ClassLibrary2"}))
            End Using
        End Function
    End Class
End Namespace