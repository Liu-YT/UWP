﻿#pragma checksum "F:\操作系统实验\Homework\homework1_MyList\16340158_刘宇庭_lab1\lab1_code\MyList\MyList\NewPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F7C90B6BADAE82539A6679BE8B1D5FFD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyList
{
    partial class NewPage : 
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
                    this.DeleteAppBarButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 14 "..\..\..\NewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.DeleteAppBarButton).Click += this.DeleteAppBarButton_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.AddAppBarButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 15 "..\..\..\NewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.AddAppBarButton).Click += this.AddAppBarButton_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.Title = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.titleText = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5:
                {
                    this.detail = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.detailText = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    this.Date = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.DatePicker = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                }
                break;
            case 9:
                {
                    this.createButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 71 "..\..\..\NewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.createButton).Click += this.CreateButton_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.cancelButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 72 "..\..\..\NewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.cancelButton).Click += this.CancelButton_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.MySlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                }
                break;
            case 12:
                {
                    this.pic = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 13:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element13 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 62 "..\..\..\NewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element13).Click += this.selectPic;
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

