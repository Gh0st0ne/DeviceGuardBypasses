﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CreateAddInIpcData.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CreateAddInIpcData.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;script&gt;
        ///// First run %WINDIR%\Microsoft.NET\Framework64\v4.0.30319\AddInProcess.exe /guid:32A91B0F-30CD-4C75-BE79-CCBD6345DE11 /pid:XXXX
        ///// Where XXXX is the PID of a stable process on the system (such as explorer.exe)
        ///// Next run this HTML file using HH PATH\TO\HTML. The HTML must be unblocked, it can&apos;t have a Zone Identifier associated with it.
        ///var d = {
        ///0x0 : 0x0 ,
        ///0x1 : 0x1 ,
        ///0x2 : 0x2 ,
        ///0x3 : 0x3 ,
        ///0x4 : 0x4 ,
        ///0x5 : 0x5 ,
        ///0x6 : 0x6 ,
        ///0x7 : 0x7 ,
        ///0x8 : 0x8 ,
        ///0x9 : 0x9 ,
        ///0xa : 0xa ,
        ///0xb  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Template {
            get {
                return ResourceManager.GetString("Template", resourceCulture);
            }
        }
    }
}
