﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinWeather.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WinWeather.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to {&quot;location&quot;:{&quot;name&quot;:&quot;London&quot;,&quot;region&quot;:&quot;City of London, Greater London&quot;,&quot;country&quot;:&quot;United Kingdom&quot;,&quot;lat&quot;:51.52,&quot;lon&quot;:-0.11,&quot;tz_id&quot;:&quot;Europe/London&quot;,&quot;localtime_epoch&quot;:1713995101,&quot;localtime&quot;:&quot;2024-04-24 22:45&quot;},&quot;current&quot;:{&quot;last_updated_epoch&quot;:1713994200,&quot;last_updated&quot;:&quot;2024-04-24 22:30&quot;,&quot;temp_c&quot;:5.0,&quot;temp_f&quot;:41.0,&quot;is_day&quot;:0,&quot;condition&quot;:{&quot;text&quot;:&quot;Clear&quot;,&quot;icon&quot;:&quot;//cdn.weatherapi.com/weather/64x64/night/113.png&quot;,&quot;code&quot;:1000},&quot;wind_mph&quot;:2.2,&quot;wind_kph&quot;:3.6,&quot;wind_degree&quot;:330,&quot;wind_dir&quot;:&quot;NNW&quot;,&quot;pressure_mb&quot;:1013.0,&quot;pres [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string FallbackApiData {
            get {
                return ResourceManager.GetString("FallbackApiData", resourceCulture);
            }
        }
    }
}
