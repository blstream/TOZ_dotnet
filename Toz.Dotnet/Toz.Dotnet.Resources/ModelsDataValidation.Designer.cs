﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Toz.Dotnet.Resources {
    using System;
    using System.Reflection;
    
    
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
    public class ModelsDataValidation {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ModelsDataValidation() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Toz.Dotnet.Resources.ModelsDataValidation", typeof(ModelsDataValidation).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to Invalid Email Address.
        /// </summary>
        public static string EmailValidationMessage {
            get {
                return ResourceManager.GetString("EmailValidationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You can&apos;t leave this empty..
        /// </summary>
        public static string EmptyField {
            get {
                return ResourceManager.GetString("EmptyField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The maximum length is {1} characters..
        /// </summary>
        public static string MaxLength {
            get {
                return ResourceManager.GetString("MaxLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name can only consist of letters..
        /// </summary>
        public static string NameLetters {
            get {
                return ResourceManager.GetString("NameLetters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This field can only consist of digits..
        /// </summary>
        public static string OnlyDigits {
            get {
                return ResourceManager.GetString("OnlyDigits", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select a pet sex..
        /// </summary>
        public static string PetSexUndefined {
            get {
                return ResourceManager.GetString("PetSexUndefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select a pet type..
        /// </summary>
        public static string PetTypeUndefined {
            get {
                return ResourceManager.GetString("PetTypeUndefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select a user type..
        /// </summary>
        public static string TypeUndefined {
            get {
                return ResourceManager.GetString("TypeUndefined", resourceCulture);
            }
        }
    }
}
