﻿#pragma checksum "..\..\..\Pages\Authorization.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2C42026856C72B97C6201D780DA18D0EDAD928BE37F616B531658D117F5E9F48"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Events2._0.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Events2._0.Pages {
    
    
    /// <summary>
    /// Authorization
    /// </summary>
    public partial class Authorization : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\Pages\Authorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Events2._0.Pages.Authorization AuthorizationPage;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Pages\Authorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid txtPassword;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Pages\Authorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLogin;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\Authorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox paswordBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\Authorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockCaptcha;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\Authorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtBlockCaptcha;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\Authorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCaptcha;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\Authorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEnterGuest;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\Authorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEnter;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Pages\Authorization.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtBlockTimer;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Events2.0;component/pages/authorization.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Authorization.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.AuthorizationPage = ((Events2._0.Pages.Authorization)(target));
            return;
            case 2:
            this.txtPassword = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.txtLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.paswordBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.textBlockCaptcha = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.txtBlockCaptcha = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.txtCaptcha = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btnEnterGuest = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Pages\Authorization.xaml"
            this.btnEnterGuest.Click += new System.Windows.RoutedEventHandler(this.btnEnterGuest_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnEnter = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Pages\Authorization.xaml"
            this.btnEnter.Click += new System.Windows.RoutedEventHandler(this.btnEnter_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.txtBlockTimer = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

