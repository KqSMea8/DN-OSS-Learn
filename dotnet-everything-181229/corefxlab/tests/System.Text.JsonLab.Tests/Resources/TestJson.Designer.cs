﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Text.JsonLab.Tests.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class TestJson {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TestJson() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Text.JsonLab.Tests.Resources.TestJson", typeof(TestJson).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///   &quot;age&quot; : 30,
        ///   &quot;first&quot; : &quot;John&quot;,
        ///   &quot;last&quot; : &quot;Smith&quot;,
        ///   &quot;phoneNumbers&quot; : [
        ///      &quot;425-000-1212&quot;,
        ///      &quot;425-000-1213&quot;
        ///   ],
        ///   &quot;address&quot; : {
        ///      &quot;street&quot; : &quot;1 Microsoft Way&quot;,
        ///      &quot;city&quot; : &quot;Redmond&quot;,
        ///      &quot;zip&quot; : 98052
        ///   }
        ///}.
        /// </summary>
        internal static string BasicJson {
            get {
                return ResourceManager.GetString("BasicJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;age&quot;:30,&quot;first&quot;:&quot;John&quot;,&quot;last&quot;:&quot;Smith&quot;,&quot;phoneNumbers&quot;:[&quot;425-000-1212&quot;,&quot;425-000-1213&quot;],&quot;address&quot;:{&quot;street&quot;:&quot;1MicrosoftWay&quot;,&quot;city&quot;:&quot;Redmond&quot;,&quot;zip&quot;:98052},&quot;IDs&quot;:[425,-70,9223372036854775807]}.
        /// </summary>
        internal static string BasicJsonWithLargeNum {
            get {
                return ResourceManager.GetString("BasicJsonWithLargeNum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [
        ///  {
        ///    &quot;_id&quot;: &quot;5af4c006873ec87e12466553&quot;,
        ///    &quot;index&quot;: 0,
        ///    &quot;guid&quot;: &quot;cce48618-6953-4907-b641-288a68f2bd75&quot;,
        ///    &quot;isActive&quot;: true,
        ///    &quot;balance&quot;: &quot;$3,677.14&quot;,
        ///    &quot;picture&quot;: &quot;http://placehold.it/32x32&quot;,
        ///    &quot;age&quot;: 22,
        ///    &quot;eyeColor&quot;: &quot;blue&quot;,
        ///    &quot;name&quot;: &quot;Hampton Guerra&quot;,
        ///    &quot;gender&quot;: &quot;male&quot;,
        ///    &quot;company&quot;: &quot;GAPTEC&quot;,
        ///    &quot;email&quot;: &quot;hamptonguerra@gaptec.com&quot;,
        ///    &quot;phone&quot;: &quot;+1 (858) 595-2071&quot;,
        ///    &quot;address&quot;: &quot;282 Harden Street, Orason, Nebraska, 3912&quot;,
        ///    &quot;about&quot;: &quot;Tempor ullamco eu anim d [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string BroadTree {
            get {
                return ResourceManager.GetString("BroadTree", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [
        ///  {
        ///    &quot;_id&quot;: &quot;5af4bfbe93ba383385d9047a&quot;,
        ///    &quot;index&quot;: 0,
        ///    &quot;guid&quot;: &quot;1a4244ab-960b-4937-872d-d0b00882a99d&quot;,
        ///    &quot;isActive&quot;: true,
        ///    &quot;balance&quot;: &quot;$3,377.20&quot;,
        ///    &quot;picture&quot;: &quot;http://placehold.it/32x32&quot;,
        ///    &quot;age&quot;: 30,
        ///    &quot;eyeColor&quot;: &quot;blue&quot;,
        ///    &quot;name&quot;: &quot;Ferguson Avery&quot;,
        ///    &quot;gender&quot;: &quot;male&quot;,
        ///    &quot;company&quot;: &quot;PHARMACON&quot;,
        ///    &quot;email&quot;: &quot;fergusonavery@pharmacon.com&quot;,
        ///    &quot;phone&quot;: &quot;+1 (904) 438-2218&quot;,
        ///    &quot;address&quot;: &quot;732 Falmouth Street, Riviera, Mississippi, 4550&quot;,
        ///    &quot;about&quot;: &quot;Pariatur adi [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DeepTree {
            get {
                return ResourceManager.GetString("DeepTree", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;runtimeTarget&quot;: {
        ///    &quot;name&quot;: &quot;.NETCoreApp,Version=v2.2&quot;,
        ///    &quot;signature&quot;: &quot;96b3a7d355de094922eacd5950627ebb97271704&quot;
        ///  },
        ///  &quot;compilationOptions&quot;: {},
        ///  &quot;targets&quot;: {
        ///    &quot;.NETCoreApp,Version=v2.2&quot;: {
        ///      &quot;Microsoft.AspNetCore.SignalR.Client.FunctionalTests/3.0.0-alpha1-t000&quot;: {
        ///        &quot;dependencies&quot;: {
        ///          &quot;Internal.AspNetCore.Sdk&quot;: &quot;3.0.0-alpha1-10015&quot;,
        ///          &quot;Microsoft.AspNetCore.Authentication.JwtBearer&quot;: &quot;3.0.0-alpha1-10173&quot;,
        ///          &quot;Microsoft.AspNetCore.Diagnostics&quot;: &quot;3 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DepsJsonSignalR {
            get {
                return ResourceManager.GetString("DepsJsonSignalR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;age&quot;:30,&quot;first&quot;:&quot;John&quot;,&quot;last&quot;:&quot;Smith&quot;,&quot;phoneNumbers&quot;:[&quot;425-000-1212&quot;,&quot;425-000-1213&quot;],&quot;address&quot;:{&quot;street&quot;:&quot;1 Microsoft Way&quot;,&quot;city&quot;:&quot;Redmond&quot;,&quot;zip&quot;:98052}}.
        /// </summary>
        internal static string ExpectedBasicJson {
            get {
                return ResourceManager.GetString("ExpectedBasicJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;age&quot;:30,&quot;first&quot;:&quot;John&quot;,&quot;last&quot;:&quot;Smith&quot;,&quot;phoneNumbers&quot;:[&quot;425-000-1212&quot;,&quot;425-000-1213&quot;],&quot;address&quot;:{&quot;street&quot;:&quot;1MicrosoftWay&quot;,&quot;city&quot;:&quot;Redmond&quot;,&quot;zip&quot;:98052},&quot;IDs&quot;:[425,-70,9.22337203685478E+18]}.
        /// </summary>
        internal static string ExpectedBasicJsonWithLargeNum {
            get {
                return ResourceManager.GetString("ExpectedBasicJsonWithLargeNum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;age&quot;:30,&quot;first&quot;:&quot;John&quot;,&quot;last&quot;:&quot;Smith&quot;,&quot;phoneNumbers&quot;:[&quot;425-000-1212&quot;,&quot;425-000-1213&quot;],&quot;address&quot;:{&quot;street&quot;:&quot;1 Microsoft Way&quot;,&quot;city&quot;:&quot;Redmond&quot;,&quot;zip&quot;:98052}}.
        /// </summary>
        internal static string ExpectedCreateJson {
            get {
                return ResourceManager.GetString("ExpectedCreateJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;age&quot;:30,&quot;first&quot;:&quot;John&quot;,&quot;last&quot;:&quot;Smith&quot;,&quot;phoneNumbers&quot;:[&quot;425-000-1212&quot;,&quot;425-000-1213&quot;],&quot;address&quot;:{&quot;street&quot;:&quot;1MicrosoftWay&quot;,&quot;city&quot;:&quot;Redmond&quot;,&quot;zip&quot;:98052},&quot;IDs&quot;:[425,-70,9.22337203685478E+18],&quot;arrayWithObjects&quot;:[&quot;text&quot;,14,[],null,false,{},{&quot;time&quot;:24},[&quot;1&quot;,&quot;2&quot;,&quot;3&quot;]],&quot;boolean&quot;:false,&quot;null&quot;:null,&quot;objectName&quot;:{&quot;group&quot;:{&quot;array&quot;:[false],&quot;field&quot;:&quot;simple&quot;,&quot;anotherFieldNum&quot;:5,&quot;anotherFieldBool&quot;:true,&quot;lastField&quot;:null}},&quot;emptyObject&quot;:{}}.
        /// </summary>
        internal static string ExpectedFullJsonSchema1 {
            get {
                return ResourceManager.GetString("ExpectedFullJsonSchema1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;string&quot;:&quot;string&quot;,&quot;number&quot;:5,&quot;decimal&quot;:3516512.13512,&quot;long&quot;:9.22337203685478E+18,&quot;notLong&quot;:922854776000.12,&quot;boolean&quot;:false,&quot;object&quot;:{},&quot;array&quot;:[],&quot;null&quot;:null,&quot;emptyArray&quot;:[],&quot;emptyObject&quot;:{},&quot;arrayString&quot;:[&quot;alpha&quot;,&quot;beta&quot;],&quot;arrayNum&quot;:[1,212512.01,3],&quot;arrayBool&quot;:[false,true,true],&quot;arrayNull&quot;:[null,null],&quot;arrayObject&quot;:[{&quot;firstName&quot;:&quot;name1&quot;,&quot;lastName&quot;:&quot;name&quot;},{&quot;firstName&quot;:&quot;name1&quot;,&quot;lastName&quot;:&quot;name&quot;},{&quot;firstName&quot;:&quot;name2&quot;,&quot;lastName&quot;:&quot;name&quot;},{&quot;firstName&quot;:&quot;name3&quot;,&quot;lastName&quot;:&quot;name1&quot;}],&quot;arrayArray&quot;:[[null,false,5,&quot;-0 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ExpectedFullJsonSchema2 {
            get {
                return ResourceManager.GetString("ExpectedFullJsonSchema2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;array&quot;:[{&quot;_id&quot;:&quot;56280d1abea79cfca762cd56&quot;,&quot;index&quot;:0,&quot;isActive&quot;:false,&quot;tags&quot;:[&quot;ad&quot;,&quot;voluptate&quot;,&quot;ullamco&quot;,&quot;reprehenderit&quot;,&quot;duis&quot;,&quot;Lorem&quot;,&quot;anim&quot;],&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Fernandez Barr&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Selena Hoover&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Verna Keller&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Middleton Duncan&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Fitzgerald Mcbride&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Boyd Marshall&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Debbie Hess&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Larson Mcmahon&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name [rest of string was truncated]&qu....
        /// </summary>
        internal static string ExpectedHeavyNestedJson {
            get {
                return ResourceManager.GetString("ExpectedHeavyNestedJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [{&quot;array&quot;:[{&quot;_id&quot;:&quot;56280d1abea79cfca762cd56&quot;,&quot;index&quot;:0,&quot;isActive&quot;:false,&quot;tags&quot;:[&quot;ad&quot;,&quot;voluptate&quot;,&quot;ullamco&quot;,&quot;reprehenderit&quot;,&quot;duis&quot;,&quot;Lorem&quot;,&quot;anim&quot;],&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Fernandez Barr&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Selena Hoover&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Verna Keller&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Middleton Duncan&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Fitzgerald Mcbride&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Boyd Marshall&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Debbie Hess&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;name&quot;:&quot;Larson Mcmahon&quot;,&quot;friends&quot;:[{&quot;id&quot;:0,&quot;nam [rest of string was truncated]&qu....
        /// </summary>
        internal static string ExpectedHeavyNestedJsonWithArray {
            get {
                return ResourceManager.GetString("ExpectedHeavyNestedJsonWithArray", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;+testZero+&quot;:0,&quot;+testSmallNum+&quot;:0.1,&quot;+testeZero+&quot;:0.1,&quot;+testENegtiveWithZero+&quot;:0,&quot;+testeNegativeWithInt+&quot;:0.02155,&quot;+testEPositiveWithDecimal+&quot;:215215.41,&quot;+testePositiveWithLargeInt+&quot;:1.84467440737096E+128,&quot;+testeNegativeWithLargeDecimal+&quot;:1.25125612512513E-109,&quot;-testZero-&quot;:0,&quot;-testSmallNum-&quot;:-0.1,&quot;-testeZero-&quot;:-0.1,&quot;-testENegtiveWithZero-&quot;:0,&quot;-testeNegativeWithInt-&quot;:-0.02155,&quot;-testEPositiveWithDecimal-&quot;:-215215.41,&quot;-testePositiveWithLargeInt-&quot;:-1.84467440737096E+128,&quot;-testeNegativeWithLargeDecimal-&quot;:-1.251 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ExpectedJsonWithSpecialNumFormat {
            get {
                return ResourceManager.GetString("ExpectedJsonWithSpecialNumFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;Here is a string: \&quot;\&quot;&quot;:&quot;Here is a hex value -\u024A&quot;,&quot;Here is a back slash\\&quot;:[&quot;Multiline
        /// String
        ///&quot;,&quot;	Mul
        ///tiline String&quot;,&quot;\&quot;somequote\&quot;	Mu\&quot;\&quot;l
        ///tiline\&quot;another\&quot; String\\&quot;],&quot;str&quot;:&quot;\&quot;\&quot;&quot;}.
        /// </summary>
        internal static string ExpectedJsonWithSpecialStrings {
            get {
                return ResourceManager.GetString("ExpectedJsonWithSpecialStrings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;test&quot;:[{&quot;_id&quot;:&quot;562704ab8c67fc70235cb3ee&quot;,&quot;index&quot;:0,&quot;guid&quot;:&quot;9e16ac89-e6cb-401d-b0bd-5cb567908ad7&quot;,&quot;isActive&quot;:false,&quot;balance&quot;:&quot;$2,222.13&quot;,&quot;picture&quot;:&quot;http://placehold.it/32x32&quot;,&quot;age&quot;:34,&quot;eyeColor&quot;:&quot;blue&quot;,&quot;name&quot;:&quot;Reba Abbott&quot;,&quot;gender&quot;:&quot;female&quot;,&quot;company&quot;:&quot;VERBUS&quot;,&quot;email&quot;:&quot;rebaabbott@verbus.com&quot;,&quot;phone&quot;:&quot;+1 (878) 506-3650&quot;,&quot;address&quot;:&quot;800 Anchorage Place, Crayne, Illinois, 9130&quot;,&quot;about&quot;:&quot;Proident ea dolor ullamco occaecat ut pariatur. Pariatur aute deserunt deserunt qui aute commodo. Dolor ipsum incididunt tempo [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ExpectedLargeJson {
            get {
                return ResourceManager.GetString("ExpectedLargeJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;locked&quot;:false,&quot;version&quot;:1,&quot;targets&quot;:{&quot;DNXCore,Version=v5.0&quot;:{&quot;Microsoft.CSharp/4.0.0&quot;:{&quot;dependencies&quot;:{&quot;System.Runtime&quot;:&quot;[4.0.20, )&quot;,&quot;System.Dynamic.Runtime&quot;:&quot;[4.0.0, )&quot;,&quot;System.Linq.Expressions&quot;:&quot;[4.0.0, )&quot;,&quot;System.Runtime.InteropServices&quot;:&quot;[4.0.20, )&quot;,&quot;System.Resources.ResourceManager&quot;:&quot;[4.0.0, )&quot;,&quot;System.Linq&quot;:&quot;[4.0.0, )&quot;,&quot;System.Reflection.TypeExtensions&quot;:&quot;[4.0.0, )&quot;,&quot;System.Reflection.Primitives&quot;:&quot;[4.0.0, )&quot;,&quot;System.Reflection.Extensions&quot;:&quot;[4.0.0, )&quot;,&quot;System.Collections&quot;:&quot;[4.0.10, )&quot;,&quot;System.Diagnost [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ExpectedProjectLockJson {
            get {
                return ResourceManager.GetString("ExpectedProjectLockJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;age&quot;:30,&quot;first&quot;:&quot;John&quot;,&quot;last&quot;:&quot;Smith&quot;,&quot;phoneNumbers&quot;:[&quot;425-000-1212&quot;,&quot;425-000-1213&quot;],&quot;address&quot;:{&quot;street&quot;:&quot;1MicrosoftWay&quot;,&quot;city&quot;:&quot;Redmond&quot;,&quot;zip&quot;:98052},&quot;IDs&quot;:[425,-70,9223372036854776000],&quot;arrayWithObjects&quot;:[&quot;text&quot;,14,[],null,false,{},{&quot;time&quot;:24},[&quot;1&quot;,&quot;2&quot;,&quot;3&quot;]],&quot;boolean&quot;:false,&quot;null&quot;:null,&quot;objectName&quot;:{&quot;group&quot;:{&quot;array&quot;:[false],&quot;field&quot;:&quot;simple&quot;,&quot;anotherFieldNum&quot;:5,&quot;anotherFieldBool&quot;:true,&quot;lastField&quot;:null}},&quot;emptyObject&quot;:{}}.
        /// </summary>
        internal static string FullJsonSchema1 {
            get {
                return ResourceManager.GetString("FullJsonSchema1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;string&quot;:&quot;string&quot;,&quot;number&quot;:5,&quot;decimal&quot;:3516512.13512,&quot;long&quot;:9223372036854776000.1200,&quot;notLong&quot;:922854776000.1200,&quot;boolean&quot;:false,&quot;object&quot;:{},&quot;array&quot;:[],&quot;null&quot;:null,&quot;emptyArray&quot;:[],&quot;emptyObject&quot;:{},&quot;arrayString&quot;:[&quot;alpha&quot;,&quot;beta&quot;],&quot;arrayNum&quot;:[1,212512.01,3.00],&quot;arrayBool&quot;:[false,true,true],&quot;arrayNull&quot;:[null,null],&quot;arrayObject&quot;:[{&quot;firstName&quot;:&quot;name1&quot;,&quot;lastName&quot;:&quot;name&quot;},{&quot;firstName&quot;:&quot;name1&quot;,&quot;lastName&quot;:&quot;name&quot;},{&quot;firstName&quot;:&quot;name2&quot;,&quot;lastName&quot;:&quot;name&quot;},{&quot;firstName&quot;:&quot;name3&quot;,&quot;lastName&quot;:&quot;name1&quot;}],&quot;arrayArray&quot;:[[null,fa [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string FullJsonSchema2 {
            get {
                return ResourceManager.GetString("FullJsonSchema2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;array&quot;:[  {    &quot;_id&quot;: &quot;56280d1abea79cfca762cd56&quot;,    &quot;index&quot;: 0,    &quot;isActive&quot;: false,    &quot;tags&quot;: [      &quot;ad&quot;,      &quot;voluptate&quot;,      &quot;ullamco&quot;,      &quot;reprehenderit&quot;,      &quot;duis&quot;,      &quot;Lorem&quot;,      &quot;anim&quot;    ],    &quot;friends&quot;: [      {        &quot;id&quot;: 0,        &quot;name&quot;: &quot;Fernandez Barr&quot;,        &quot;friends&quot;: [          {            &quot;id&quot;: 0,            &quot;name&quot;: &quot;Selena Hoover&quot;,            &quot;friends&quot;: [              {                &quot;id&quot;: 0,                &quot;name&quot;: &quot;Verna Keller&quot;,                &quot;friends&quot;: [           [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string HeavyNestedJson {
            get {
                return ResourceManager.GetString("HeavyNestedJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [{&quot;array&quot;:[  {    &quot;_id&quot;: &quot;56280d1abea79cfca762cd56&quot;,    &quot;index&quot;: 0,    &quot;isActive&quot;: false,    &quot;tags&quot;: [      &quot;ad&quot;,      &quot;voluptate&quot;,      &quot;ullamco&quot;,      &quot;reprehenderit&quot;,      &quot;duis&quot;,      &quot;Lorem&quot;,      &quot;anim&quot;    ],    &quot;friends&quot;: [      {        &quot;id&quot;: 0,        &quot;name&quot;: &quot;Fernandez Barr&quot;,        &quot;friends&quot;: [          {            &quot;id&quot;: 0,            &quot;name&quot;: &quot;Selena Hoover&quot;,            &quot;friends&quot;: [              {                &quot;id&quot;: 0,                &quot;name&quot;: &quot;Verna Keller&quot;,                &quot;friends&quot;: [          [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string HeavyNestedJsonWithArray {
            get {
                return ResourceManager.GetString("HeavyNestedJsonWithArray", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to { &quot;message&quot;: &quot;Hello, World!&quot; }.
        /// </summary>
        internal static string HelloWorld {
            get {
                return ResourceManager.GetString("HelloWorld", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [
        ///  {
        ///    &quot;_id&quot;: &quot;5671ebcfd88de5e8dac53641&quot;,
        ///    &quot;index&quot;: 0,
        ///    &quot;isActive&quot;: true,
        ///    &quot;balance&quot;: &quot;$3,951.98&quot;,
        ///    &quot;picture&quot;: &quot;http://placehold.it/32x32&quot;,
        ///    &quot;age&quot;: 36,
        ///    &quot;email&quot;: &quot;clementsvillarreal@daycore.com&quot;,
        ///    &quot;phone&quot;: &quot;+1 (882) 479-2331&quot;,
        ///    &quot;address&quot;: &quot;488 Grand Street, Hackneyville, Vermont, 5344&quot;,
        ///    &quot;registered&quot;: &quot;2015-04-12T05:27:22 +07:00&quot;,
        ///    &quot;latitude&quot;: -57.256693,
        ///    &quot;longitude&quot;: 49.961028
        ///  }
        ///].
        /// </summary>
        internal static string Json400B {
            get {
                return ResourceManager.GetString("Json400B", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [
        ///  {
        ///    &quot;_id&quot;: &quot;5671eaf1eb61139592ea92ff&quot;,
        ///    &quot;index&quot;: 0,
        ///    &quot;guid&quot;: &quot;b825474f-3855-434e-930c-c3015f3b39ee&quot;,
        ///    &quot;isActive&quot;: false,
        ///    &quot;balance&quot;: &quot;$2,100.09&quot;,
        ///    &quot;picture&quot;: &quot;http://placehold.it/32x32&quot;,
        ///    &quot;age&quot;: 20,
        ///    &quot;eyeColor&quot;: &quot;green&quot;,
        ///    &quot;name&quot;: &quot;Zelma Blackburn&quot;,
        ///    &quot;gender&quot;: &quot;female&quot;,
        ///    &quot;company&quot;: &quot;AUTOMON&quot;,
        ///    &quot;email&quot;: &quot;zelmablackburn@automon.com&quot;,
        ///    &quot;phone&quot;: &quot;+1 (935) 411-3028&quot;,
        ///    &quot;address&quot;: &quot;358 Catherine Street, Takilma, New Hampshire, 9061&quot;,
        ///    &quot;about&quot;: &quot;Ad ea o [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Json400KB {
            get {
                return ResourceManager.GetString("Json400KB", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [
        ///  {
        ///    &quot;_id&quot;: &quot;5671eb0737b18866984067ac&quot;,
        ///    &quot;index&quot;: 0,
        ///    &quot;guid&quot;: &quot;3cfa77d7-29be-467f-a967-16bae78767e8&quot;,
        ///    &quot;isActive&quot;: false,
        ///    &quot;balance&quot;: &quot;$1,223.37&quot;,
        ///    &quot;picture&quot;: &quot;http://placehold.it/32x32&quot;,
        ///    &quot;age&quot;: 34,
        ///    &quot;eyeColor&quot;: &quot;brown&quot;,
        ///    &quot;name&quot;: &quot;Josephine Snider&quot;,
        ///    &quot;gender&quot;: &quot;female&quot;,
        ///    &quot;company&quot;: &quot;SYBIXTEX&quot;,
        ///    &quot;email&quot;: &quot;josephinesnider@sybixtex.com&quot;,
        ///    &quot;phone&quot;: &quot;+1 (936) 525-3324&quot;,
        ///    &quot;address&quot;: &quot;905 Marconi Place, Motley, Oregon, 3159&quot;,
        ///    &quot;about&quot;: &quot;Ut id id conse [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Json40KB {
            get {
                return ResourceManager.GetString("Json40KB", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [
        ///  {
        ///    &quot;_id&quot;: &quot;5671eb1b60a382ffb56b3946&quot;,
        ///    &quot;index&quot;: 0,
        ///    &quot;guid&quot;: &quot;8938d485-7ea7-4b57-ab02-cd7ff698a57e&quot;,
        ///    &quot;isActive&quot;: true,
        ///    &quot;balance&quot;: &quot;$3,138.66&quot;,
        ///    &quot;picture&quot;: &quot;http://placehold.it/32x32&quot;,
        ///    &quot;age&quot;: 28,
        ///    &quot;eyeColor&quot;: &quot;blue&quot;,
        ///    &quot;name&quot;: &quot;Susanne Wright&quot;,
        ///    &quot;gender&quot;: &quot;female&quot;,
        ///    &quot;company&quot;: &quot;VIXO&quot;,
        ///    &quot;email&quot;: &quot;susannewright@vixo.com&quot;,
        ///    &quot;phone&quot;: &quot;+1 (836) 581-2698&quot;,
        ///    &quot;address&quot;: &quot;367 Clifford Place, Benson, Northern Mariana Islands, 4627&quot;,
        ///    &quot;about&quot;: &quot;Irure off [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Json4KB {
            get {
                return ResourceManager.GetString("Json4KB", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;+testZero+&quot; : 0,&quot;+testSmallNum+&quot; : 0.1,&quot;+testeZero+&quot; : 0.1e0,&quot;+testENegtiveWithZero+&quot; : 0E-1,&quot;+testeNegativeWithInt+&quot; : 2155e-5,&quot;+testEPositiveWithDecimal+&quot; : 2152.1541E+2,&quot;+testePositiveWithLargeInt+&quot; : 18446744073709551615E109,&quot;+testeNegativeWithLargeDecimal+&quot; : 125125612512512.512512e-0123,&quot;-testZero-&quot; : -0,&quot;-testSmallNum-&quot; : -0.1,&quot;-testeZero-&quot; : -0.1e0,&quot;-testENegtiveWithZero-&quot; : -0E-1,&quot;-testeNegativeWithInt-&quot; : -2155e-5,&quot;-testEPositiveWithDecimal-&quot; : -2152.1541E+2,&quot;-testePositiveWithLargeInt-&quot; :-18446 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string JsonWithSpecialNumFormat {
            get {
                return ResourceManager.GetString("JsonWithSpecialNumFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;Here is a string: \&quot;\&quot;&quot;:&quot;Here is a hex value -\u024A&quot;,&quot;Here is a back slash\\&quot;:[&quot;Multiline
        /// String
        ///&quot;,&quot;	Mul
        ///tiline String&quot;,&quot;\&quot;somequote\&quot;	Mu\&quot;\&quot;l
        ///tiline\&quot;another\&quot; String\\&quot;],&quot;str&quot;:&quot;\&quot;\&quot;&quot;}.
        /// </summary>
        internal static string JsonWithSpecialStrings {
            get {
                return ResourceManager.GetString("JsonWithSpecialStrings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {  &quot;test&quot; : [    {      &quot;_id&quot;: &quot;562704ab8c67fc70235cb3ee&quot;,      &quot;index&quot;: 0,      &quot;guid&quot;: &quot;9e16ac89-e6cb-401d-b0bd-5cb567908ad7&quot;,      &quot;isActive&quot;: false,      &quot;balance&quot;: &quot;$2,222.13&quot;,      &quot;picture&quot;: &quot;http://placehold.it/32x32&quot;,      &quot;age&quot;: 34,      &quot;eyeColor&quot;: &quot;blue&quot;,      &quot;name&quot;: &quot;Reba Abbott&quot;,      &quot;gender&quot;: &quot;female&quot;,      &quot;company&quot;: &quot;VERBUS&quot;,      &quot;email&quot;: &quot;rebaabbott@verbus.com&quot;,      &quot;phone&quot;: &quot;+1 (878) 506-3650&quot;,      &quot;address&quot;: &quot;800 Anchorage Place, Crayne, Illinois, 9130&quot;,      &quot;about&quot;: &quot;Proident ea d [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string LargeJson {
            get {
                return ResourceManager.GetString("LargeJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [
        ///  {
        ///    &quot;_id1&quot;: 1970097990,
        ///    &quot;_id2&quot;: 9666
        ///  },
        ///  {
        ///    &quot;_id1&quot;: 5632677389,
        ///    &quot;_id2&quot;: 2356
        ///  },
        ///  {
        ///    &quot;_id1&quot;: 7930277137,
        ///    &quot;_id2&quot;: 1130
        ///  },
        ///  {
        ///    &quot;_id1&quot;: 6964942657,
        ///    &quot;_id2&quot;: 3348
        ///  },
        ///  {
        ///    &quot;_id1&quot;: 2504939563,
        ///    &quot;_id2&quot;: 3501
        ///  },
        ///  {
        ///    &quot;_id1&quot;: 5993828171,
        ///    &quot;_id2&quot;: 4462
        ///  },
        ///  {
        ///    &quot;_id1&quot;: 6829429877,
        ///    &quot;_id2&quot;: 3502
        ///  },
        ///  {
        ///    &quot;_id1&quot;: 9526593666,
        ///    &quot;_id2&quot;: 5752
        ///  },
        ///  {
        ///    &quot;_id1&quot;: 7980793185,
        ///    &quot;_id2&quot;: 9376
        ///  },
        ///  {
        ///    &quot;_id1&quot;: 747666 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string LotsOfNumbers {
            get {
                return ResourceManager.GetString("LotsOfNumbers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [
        ///  {
        ///    &quot;email&quot;: &quot;3388 hooversexton@nitracyr.com 6241&quot;
        ///  },
        ///  {
        ///    &quot;email&quot;: &quot;9999 hooversexton@nitracyr.com 445&quot;
        ///  },
        ///  {
        ///    &quot;email&quot;: &quot;7601 hooversexton@nitracyr.com 4879&quot;
        ///  },
        ///  {
        ///    &quot;email&quot;: &quot;1913 hooversexton@nitracyr.com 4301&quot;
        ///  },
        ///  {
        ///    &quot;email&quot;: &quot;9541 hooversexton@nitracyr.com 403&quot;
        ///  },
        ///  {
        ///    &quot;email&quot;: &quot;4363 hooversexton@nitracyr.com 9040&quot;
        ///  },
        ///  {
        ///    &quot;email&quot;: &quot;7105 hooversexton@nitracyr.com 4676&quot;
        ///  },
        ///  {
        ///    &quot;email&quot;: &quot;2558 hooversexton@nitracyr.com 8668&quot;
        ///  },
        ///  {
        ///   [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string LotsOfStrings {
            get {
                return ResourceManager.GetString("LotsOfStrings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [
        ///   {
        ///      &quot;age&quot; : 30,
        ///      &quot;first&quot; : &quot;John&quot;,
        ///      &quot;last&quot; : &quot;Smith&quot;,
        ///      &quot;phoneNumbers&quot; : [
        ///         &quot;425-000-1212&quot;,
        ///         &quot;425-000-1213&quot;
        ///      ],
        ///      &quot;address&quot; : {
        ///         &quot;street&quot; : &quot;1 Microsoft Way&quot;,
        ///         &quot;city&quot; : &quot;Redmond&quot;,
        ///         &quot;zip&quot; : 98052
        ///      }
        ///   }
        ///].
        /// </summary>
        internal static string ParseJson {
            get {
                return ResourceManager.GetString("ParseJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {  &quot;locked&quot;: false,  &quot;version&quot;: 1,  &quot;targets&quot;: {    &quot;DNXCore,Version=v5.0&quot;: {      &quot;Microsoft.CSharp/4.0.0&quot;: {        &quot;dependencies&quot;: {          &quot;System.Runtime&quot;: &quot;[4.0.20, )&quot;,          &quot;System.Dynamic.Runtime&quot;: &quot;[4.0.0, )&quot;,          &quot;System.Linq.Expressions&quot;: &quot;[4.0.0, )&quot;,          &quot;System.Runtime.InteropServices&quot;: &quot;[4.0.20, )&quot;,          &quot;System.Resources.ResourceManager&quot;: &quot;[4.0.0, )&quot;,          &quot;System.Linq&quot;: &quot;[4.0.0, )&quot;,          &quot;System.Reflection.TypeExtensions&quot;: &quot;[4.0.0, )&quot;,          &quot;System.Reflection. [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ProjectLockJson {
            get {
                return ResourceManager.GetString("ProjectLockJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [
        ///	&quot;425-214-3151&quot;,
        ///	25
        ///].
        /// </summary>
        internal static string SimpleArrayJson {
            get {
                return ResourceManager.GetString("SimpleArrayJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///	&quot;age&quot;: 30,
        ///	&quot;first&quot;: &quot;John&quot;,
        ///	&quot;last&quot;: &quot;Smith&quot;,
        ///	&quot;phoneNumber&quot;: &quot;425-214-3151&quot;,
        ///	&quot;street&quot;: &quot;1 Microsoft Way&quot;,
        ///	&quot;city&quot;: &quot;Redmond&quot;,
        ///	&quot;zip&quot;: 98052
        ///}.
        /// </summary>
        internal static string SimpleObjectJson {
            get {
                return ResourceManager.GetString("SimpleObjectJson", resourceCulture);
            }
        }
    }
}