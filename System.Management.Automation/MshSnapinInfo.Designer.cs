﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Management.Automation {
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
    public class MshSnapinInfo {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MshSnapinInfo() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Management.Automation.MshSnapinInfo", typeof(MshSnapinInfo).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find required information in registry or missing key files.  Cannot load some cmdlets..
        /// </summary>
        public static string DefaultMshSnapinNotPresent {
            get {
                return ResourceManager.GetString("DefaultMshSnapinNotPresent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mandatory value {0} is not in correct format for registry key {1}.  Expected format is string..
        /// </summary>
        public static string MandatoryValueNotInCorrectFormat {
            get {
                return ResourceManager.GetString("MandatoryValueNotInCorrectFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mandatory value {0} is not in correct format for registry key {1}.  Expected format is multistring..
        /// </summary>
        public static string MandatoryValueNotInCorrectFormatMultiString {
            get {
                return ResourceManager.GetString("MandatoryValueNotInCorrectFormatMultiString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mandatory value {0} not specified for registry key {1}..
        /// </summary>
        public static string MandatoryValueNotPresent {
            get {
                return ResourceManager.GetString("MandatoryValueNotPresent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to access Windows PowerShell PowerShellEngine registry information..
        /// </summary>
        public static string MonadEngineRegistryAccessFailed {
            get {
                return ResourceManager.GetString("MonadEngineRegistryAccessFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to access Windows PowerShell registry information..
        /// </summary>
        public static string MonadRootRegistryAccessFailed {
            get {
                return ResourceManager.GetString("MonadRootRegistryAccessFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Windows PowerShell snap-in &apos;{0}&apos; is not installed on this computer..
        /// </summary>
        public static string MshSnapinDoesNotExist {
            get {
                return ResourceManager.GetString("MshSnapinDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No snap-ins have been registered for Windows PowerShell version {0}..
        /// </summary>
        public static string NoMshSnapinPresentForVersion {
            get {
                return ResourceManager.GetString("NoMshSnapinPresentForVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No [PSVersion] attribute was found for Windows PowerShell type {0}. Add a PSVersion attribute to the type using [PSVersion(Windows PowerShell SnapinBase.PSEngineVersion)]..
        /// </summary>
        public static string PSVersionAttributeNotExist {
            get {
                return ResourceManager.GetString("PSVersionAttributeNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to access PublicKeyToken information..
        /// </summary>
        public static string PublicKeyTokenAccessFailed {
            get {
                return ResourceManager.GetString("PublicKeyTokenAccessFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot retrieve the string resource because the reader has been disposed..
        /// </summary>
        public static string ResourceReaderDisposed {
            get {
                return ResourceManager.GetString("ResourceReaderDisposed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Version {0} of Windows PowerShell is not available on this computer..
        /// </summary>
        public static string SpecifiedVersionNotFound {
            get {
                return ResourceManager.GetString("SpecifiedVersionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Version value {0} is not specified or is incorrect for registry key {1}..
        /// </summary>
        public static string VersionValueInCorrect {
            get {
                return ResourceManager.GetString("VersionValueInCorrect", resourceCulture);
            }
        }
    }
}
