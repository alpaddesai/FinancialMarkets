﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "85780F0636B7081CBF37B40ACB8359AF1C4662A1FE5C98A99303D860FCB9642A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FinancialMarkets;
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


namespace FinancialMarkets {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid PortfolioAnalysis;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Regulations;
        
        #line default
        #line hidden
        
        
        #line 181 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Portfolio_Analysis;
        
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
            System.Uri resourceLocater = new System.Uri("/FinancialMarkets;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.PortfolioAnalysis = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            
            #line 16 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.RichTextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.RichTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 58 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.RichTextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.RichTextBox_TextChanged_1);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 89 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.RichTextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.RichTextBox_TextChanged_2);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 136 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.RichTextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.RichTextBox_TextChanged_3);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Regulations = ((System.Windows.Controls.Button)(target));
            
            #line 180 "..\..\MainWindow.xaml"
            this.Regulations.Click += new System.Windows.RoutedEventHandler(this.Regulations_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Portfolio_Analysis = ((System.Windows.Controls.Button)(target));
            
            #line 181 "..\..\MainWindow.xaml"
            this.Portfolio_Analysis.Click += new System.Windows.RoutedEventHandler(this.Portfolio_Analysis_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

