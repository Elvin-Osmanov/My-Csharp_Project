﻿#pragma checksum "..\..\..\..\Windows\DashboardWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91CBFA3D4FEB36C9B0455B8C966AE9C2E6062667"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LMS.Windows;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace LMS.Windows {
    
    
    /// <summary>
    /// DashboardWindow
    /// </summary>
    public partial class DashboardWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\Windows\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCreate;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Windows\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnReturn;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Windows\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnStream;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Windows\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBooks;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Windows\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnManagers;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Windows\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCustomers;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Windows\DashboardWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnButtonReport;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LMS;component/windows/dashboardwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\DashboardWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BtnCreate = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.BtnReturn = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.BtnStream = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.BtnBooks = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\Windows\DashboardWindow.xaml"
            this.BtnBooks.Click += new System.Windows.RoutedEventHandler(this.BtnBooks_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnManagers = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\Windows\DashboardWindow.xaml"
            this.BtnManagers.Click += new System.Windows.RoutedEventHandler(this.BtnManagers_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnCustomers = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\Windows\DashboardWindow.xaml"
            this.BtnCustomers.Click += new System.Windows.RoutedEventHandler(this.BtnCustomers_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnButtonReport = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

