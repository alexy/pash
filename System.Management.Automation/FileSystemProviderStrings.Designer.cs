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
    public class FileSystemProviderStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal FileSystemProviderStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Management.Automation.FileSystemProviderStrings", typeof(FileSystemProviderStrings).Assembly);
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
        ///   Looks up a localized string similar to Could not open alternate data stream &apos;{0}&apos; of file &apos;{1}&apos;..
        /// </summary>
        public static string AlternateDataStreamNotFound {
            get {
                return ResourceManager.GetString("AlternateDataStreamNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The attribute cannot be set because attributes are not supported. Only the following attributes can be set: Archive, Hidden, Normal, ReadOnly, or System..
        /// </summary>
        public static string AttributesNotSupported {
            get {
                return ResourceManager.GetString("AttributesNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The path length is too short. The length of a path cannot be less than the length of the basePath..
        /// </summary>
        public static string BasePathLengthError {
            get {
                return ResourceManager.GetString("BasePathLengthError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot proceed with byte encoding. When using byte encoding the content must be of type byte..
        /// </summary>
        public static string ByteEncodingError {
            get {
                return ResourceManager.GetString("ByteEncodingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property cannot be cleared because the property is not supported. Only the Attributes property can be cleared..
        /// </summary>
        public static string CannotClearProperty {
            get {
                return ResourceManager.GetString("CannotClearProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot remove item {0}: {1}.
        /// </summary>
        public static string CannotRemoveItem {
            get {
                return ResourceManager.GetString("CannotRemoveItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot restore attributes on item {0}: {1}.
        /// </summary>
        public static string CannotRestoreAttributes {
            get {
                return ResourceManager.GetString("CannotRestoreAttributes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Clear Content.
        /// </summary>
        public static string ClearContentActionFile {
            get {
                return ResourceManager.GetString("ClearContentActionFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item: {0}.
        /// </summary>
        public static string ClearContentesourceTemplate {
            get {
                return ResourceManager.GetString("ClearContentesourceTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Clear property directory.
        /// </summary>
        public static string ClearPropertyActionDirectory {
            get {
                return ResourceManager.GetString("ClearPropertyActionDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Clear Property File.
        /// </summary>
        public static string ClearPropertyActionFile {
            get {
                return ResourceManager.GetString("ClearPropertyActionFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item: {0} Property: {1}.
        /// </summary>
        public static string ClearPropertyResourceTemplate {
            get {
                return ResourceManager.GetString("ClearPropertyResourceTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot copy item {0} onto itself..
        /// </summary>
        public static string CopyError {
            get {
                return ResourceManager.GetString("CopyError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copy directory.
        /// </summary>
        public static string CopyItemActionDirectory {
            get {
                return ResourceManager.GetString("CopyItemActionDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copy File.
        /// </summary>
        public static string CopyItemActionFile {
            get {
                return ResourceManager.GetString("CopyItemActionFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item: {0} Destination: {1}.
        /// </summary>
        public static string CopyItemResourceFileTemplate {
            get {
                return ResourceManager.GetString("CopyItemResourceFileTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delimiter cannot be specified when reading the stream one byte at a time..
        /// </summary>
        public static string DelimiterError {
            get {
                return ResourceManager.GetString("DelimiterError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Directory: .
        /// </summary>
        public static string DirectoryDisplayGrouping {
            get {
                return ResourceManager.GetString("DirectoryDisplayGrouping", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item with specified name {0} already exists..
        /// </summary>
        public static string DirectoryExist {
            get {
                return ResourceManager.GetString("DirectoryExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Directory {0} cannot be removed because it is not empty..
        /// </summary>
        public static string DirectoryNotEmpty {
            get {
                return ResourceManager.GetString("DirectoryNotEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is a NTFS junction point. Use the Force parameter to delete or modify..
        /// </summary>
        public static string DirectoryReparsePoint {
            get {
                return ResourceManager.GetString("DirectoryReparsePoint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Drive root &quot;{0}&quot; does not exist or it is not a folder..
        /// </summary>
        public static string DriveRootError {
            get {
                return ResourceManager.GetString("DriveRootError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot process file because file {0} was not found..
        /// </summary>
        public static string FileNotFound {
            get {
                return ResourceManager.GetString("FileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If you are using the -Persist switch parameter, the drive name must be supported by the operating system (for example, A-Z)..
        /// </summary>
        public static string InvalidDriveName {
            get {
                return ResourceManager.GetString("InvalidDriveName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invoke Item.
        /// </summary>
        public static string InvokeItemAction {
            get {
                return ResourceManager.GetString("InvokeItemAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item: {0}.
        /// </summary>
        public static string InvokeItemResourceFileTemplate {
            get {
                return ResourceManager.GetString("InvokeItemResourceFileTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An object at the specified path {0} does not exist..
        /// </summary>
        public static string ItemDoesNotExist {
            get {
                return ResourceManager.GetString("ItemDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find item {0}..
        /// </summary>
        public static string ItemNotFound {
            get {
                return ResourceManager.GetString("ItemNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move Directory.
        /// </summary>
        public static string MoveItemActionDirectory {
            get {
                return ResourceManager.GetString("MoveItemActionDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move File.
        /// </summary>
        public static string MoveItemActionFile {
            get {
                return ResourceManager.GetString("MoveItemActionFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item: {0} Destination: {1}.
        /// </summary>
        public static string MoveItemResourceFileTemplate {
            get {
                return ResourceManager.GetString("MoveItemResourceFileTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create directory.
        /// </summary>
        public static string NewItemActionDirectory {
            get {
                return ResourceManager.GetString("NewItemActionDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create file.
        /// </summary>
        public static string NewItemActionFile {
            get {
                return ResourceManager.GetString("NewItemActionFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Destination: {0}.
        /// </summary>
        public static string NewItemActionTemplate {
            get {
                return ResourceManager.GetString("NewItemActionTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; parameter and the &apos;{1}&apos; parameter cannot both be specified..
        /// </summary>
        public static string NoFirstLastWaitForRaw {
            get {
                return ResourceManager.GetString("NoFirstLastWaitForRaw", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot process path because the specified path refers to an item that is outside the basePath..
        /// </summary>
        public static string PathOutSideBasePath {
            get {
                return ResourceManager.GetString("PathOutSideBasePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not Enough permission to perform operation..
        /// </summary>
        public static string PermissionError {
            get {
                return ResourceManager.GetString("PermissionError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When you use the Persist parameter, the root must be a file system location on a remote computer..
        /// </summary>
        public static string PersistNotSupported {
            get {
                return ResourceManager.GetString("PersistNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property {0} does not exist..
        /// </summary>
        public static string PropertyNotFound {
            get {
                return ResourceManager.GetString("PropertyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameters -Raw and -Wait cannot be specified at the same time..
        /// </summary>
        public static string RawAndWaitCannotCoexist {
            get {
                return ResourceManager.GetString("RawAndWaitCannotCoexist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot detect the encoding of the file. The specified encoding {0} is not supported when the content is read in reverse..
        /// </summary>
        public static string ReadBackward_Encoding_NotSupport {
            get {
                return ResourceManager.GetString("ReadBackward_Encoding_NotSupport", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove Directory.
        /// </summary>
        public static string RemoveItemActionDirectory {
            get {
                return ResourceManager.GetString("RemoveItemActionDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove file.
        /// </summary>
        public static string RemoveItemActionFile {
            get {
                return ResourceManager.GetString("RemoveItemActionFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot rename because the target specified represents a path or device name..
        /// </summary>
        public static string RenameError {
            get {
                return ResourceManager.GetString("RenameError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rename directory.
        /// </summary>
        public static string RenameItemActionDirectory {
            get {
                return ResourceManager.GetString("RenameItemActionDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rename File.
        /// </summary>
        public static string RenameItemActionFile {
            get {
                return ResourceManager.GetString("RenameItemActionFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item: {0} Destination: {1}.
        /// </summary>
        public static string RenameItemResourceFileTemplate {
            get {
                return ResourceManager.GetString("RenameItemResourceFileTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set property directory.
        /// </summary>
        public static string SetPropertyActionDirectory {
            get {
                return ResourceManager.GetString("SetPropertyActionDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set Property File.
        /// </summary>
        public static string SetPropertyActionFile {
            get {
                return ResourceManager.GetString("SetPropertyActionFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item: {0} Property: {1} Value: {2}.
        /// </summary>
        public static string SetPropertyResourceTemplate {
            get {
                return ResourceManager.GetString("SetPropertyResourceTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stream &apos;{0}&apos; of file &apos;{1}&apos;..
        /// </summary>
        public static string StreamAction {
            get {
                return ResourceManager.GetString("StreamAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot process path &apos;{0}&apos; because the target represents a reserved device name..
        /// </summary>
        public static string TargetCannotContainDeviceName {
            get {
                return ResourceManager.GetString("TargetCannotContainDeviceName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type is not a known type for the file system. Only &quot;file&quot; and &quot;directory&quot; can be specified..
        /// </summary>
        public static string UnknownType {
            get {
                return ResourceManager.GetString("UnknownType", resourceCulture);
            }
        }
    }
}
