﻿#pragma checksum "C:\Users\Sarah Radzihovsky\Documents\Dali-HoloLens\Dali\Views\webView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "533FD17A6E82D56C2BD23AA1D784A4E2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dali.Views
{
    partial class webView : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 33 "..\..\..\Views\webView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button).Click += this.button_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.WebViewControl = (global::Windows.UI.Xaml.Controls.WebView)(target);
                    #line 29 "..\..\..\Views\webView.xaml"
                    ((global::Windows.UI.Xaml.Controls.WebView)this.WebViewControl).NavigationStarting += this.WebViewControl_NavigationStarting;
                    #line 29 "..\..\..\Views\webView.xaml"
                    ((global::Windows.UI.Xaml.Controls.WebView)this.WebViewControl).ContentLoading += this.WebViewControl_ContentLoading;
                    #line 30 "..\..\..\Views\webView.xaml"
                    ((global::Windows.UI.Xaml.Controls.WebView)this.WebViewControl).DOMContentLoaded += this.WebViewControl_DOMContentLoaded;
                    #line 30 "..\..\..\Views\webView.xaml"
                    ((global::Windows.UI.Xaml.Controls.WebView)this.WebViewControl).UnviewableContentIdentified += this.WebViewControl_UnviewableContentIdentified;
                    #line 31 "..\..\..\Views\webView.xaml"
                    ((global::Windows.UI.Xaml.Controls.WebView)this.WebViewControl).NavigationCompleted += this.WebViewControl_NavigationCompleted;
                    #line 31 "..\..\..\Views\webView.xaml"
                    ((global::Windows.UI.Xaml.Controls.WebView)this.WebViewControl).LoadCompleted += this.WebViewControl_LoadCompleted;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

