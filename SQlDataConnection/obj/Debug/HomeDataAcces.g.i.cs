﻿#pragma checksum "..\..\HomeDataAcces.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B5B82005C92A79BF1389C3B55B37C39FBE8AF6C2CAEAE5C490893DF592C9C6DE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MyCalc;
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


namespace MyCalc {
    
    
    /// <summary>
    /// HomeDataAcces
    /// </summary>
    public partial class HomeDataAcces : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\HomeDataAcces.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox peopleFoundListBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\HomeDataAcces.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lastNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\HomeDataAcces.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lastNameLabel;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\HomeDataAcces.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button searchButton;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\HomeDataAcces.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InsertButton;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\HomeDataAcces.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backButton_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/MyCalc;component/homedataacces.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\HomeDataAcces.xaml"
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
            
            #line 10 "..\..\HomeDataAcces.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.peopleFoundListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.lastNameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\HomeDataAcces.xaml"
            this.lastNameTextBox.KeyUp += new System.Windows.Input.KeyEventHandler(this.enterButton_KeyUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lastNameLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.searchButton = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\HomeDataAcces.xaml"
            this.searchButton.Click += new System.Windows.RoutedEventHandler(this.searchButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.InsertButton = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\HomeDataAcces.xaml"
            this.InsertButton.Click += new System.Windows.RoutedEventHandler(this.InsertPage_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.backButton_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\HomeDataAcces.xaml"
            this.backButton_Copy.Click += new System.Windows.RoutedEventHandler(this.backButton_Copy_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

