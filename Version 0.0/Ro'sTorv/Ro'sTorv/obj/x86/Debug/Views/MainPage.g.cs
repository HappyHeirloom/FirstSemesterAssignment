﻿#pragma checksum "C:\Users\Jonas\Desktop\Uni - Zealand\FørsteSemesterEksamen\FirstSemesterAssignment\Version 0.0\Ro'sTorv\Ro'sTorv\Views\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "20D4D084EABA412FC94BB1524823EC55"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ro_sTorv
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\MainPage.xaml line 61
                {
                    this.NavigationView = (global::Windows.UI.Xaml.Controls.NavigationView)(target);
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.NavigationView).Loaded += this.NavigationView_Loaded;
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.NavigationView).SelectionChanged += this.NavigationView_SelectionChanged;
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.NavigationView).ItemInvoked += this.NavigationView_ItemInvoked;
                }
                break;
            case 3: // Views\MainPage.xaml line 122
                {
                    this.contentFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

