﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlarmWorkflow.AlarmSource.Fax.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AlarmWorkflow.AlarmSource.Fax.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Could not delete temporary file &apos;{0}&apos;! You may want to delete them manually. See log for further information..
        /// </summary>
        internal static string CuneiformDeleteTempFileError {
            get {
                return ResourceManager.GetString("CuneiformDeleteTempFileError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wertet eingehende Faxe aus, die in ein Verzeichnis auf dem lokalen PC geschrieben werden..
        /// </summary>
        internal static string ExportAlarmSourceDescription {
            get {
                return ResourceManager.GetString("ExportAlarmSourceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fax.
        /// </summary>
        internal static string ExportAlarmSourceDisplayName {
            get {
                return ResourceManager.GetString("ExportAlarmSourceDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Benutzt Tesseract für Texterkennung..
        /// </summary>
        internal static string ExportTesseractOcrDescription {
            get {
                return ResourceManager.GetString("ExportTesseractOcrDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tesseract.
        /// </summary>
        internal static string ExportTesseractOcrDisplayName {
            get {
                return ResourceManager.GetString("ExportTesseractOcrDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using OCR software &apos;{0}&apos;..
        /// </summary>
        internal static string InitializeUsingOcrSoftware {
            get {
                return ResourceManager.GetString("InitializeUsingOcrSoftware", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Begin parsing of fax &apos;{0}&apos;....
        /// </summary>
        internal static string OcrSoftwareParseBegin {
            get {
                return ResourceManager.GetString("OcrSoftwareParseBegin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parsing failed! Please check the log for more details. The parsing of this fax will end because of possible missing information and/or inconsistencies..
        /// </summary>
        internal static string OcrSoftwareParseEndFail {
            get {
                return ResourceManager.GetString("OcrSoftwareParseEndFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Finished parsing in &apos;{0}&apos; milliseconds..
        /// </summary>
        internal static string OcrSoftwareParseEndSuccess {
            get {
                return ResourceManager.GetString("OcrSoftwareParseEndSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Process data event: {0}.
        /// </summary>
        internal static string ProcessDataEvent {
            get {
                return ResourceManager.GetString("ProcessDataEvent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Process error event: {0}.
        /// </summary>
        internal static string ProcessErrorEvent {
            get {
                return ResourceManager.GetString("ProcessErrorEvent", resourceCulture);
            }
        }
    }
}
