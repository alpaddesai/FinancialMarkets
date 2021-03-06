﻿#pragma checksum "..\..\PortfolioAnalysis.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6EB813862577205871E4AC793B3A619A54C9A8D9FE7E5DF8E16A98E9F4228110"
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
    /// PortfolioAnalysis
    /// </summary>
    public partial class PortfolioAnalysis : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\PortfolioAnalysis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Companies;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\PortfolioAnalysis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Portfolio_Performance;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\PortfolioAnalysis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button WeekOne;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\PortfolioAnalysis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button WeekTwo;
        
        #line default
        #line hidden
        
        
        #line 274 "..\..\PortfolioAnalysis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Forecast_Companies;
        
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
            System.Uri resourceLocater = new System.Uri("/FinancialMarkets;component/portfolioanalysis.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PortfolioAnalysis.xaml"
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
            this.Companies = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\PortfolioAnalysis.xaml"
            this.Companies.Click += new System.Windows.RoutedEventHandler(this.Companies_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Portfolio_Performance = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\PortfolioAnalysis.xaml"
            this.Portfolio_Performance.Click += new System.Windows.RoutedEventHandler(this.Portfolio_Performance_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.WeekOne = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\PortfolioAnalysis.xaml"
            this.WeekOne.Click += new System.Windows.RoutedEventHandler(this.WeekOne_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.WeekTwo = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\PortfolioAnalysis.xaml"
            this.WeekTwo.Click += new System.Windows.RoutedEventHandler(this.WeekTwo_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 26 "..\..\PortfolioAnalysis.xaml"
            ((System.Windows.Controls.RichTextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.RichTextBox_TextChanged_1);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Forecast_Companies = ((System.Windows.Controls.Button)(target));
            
            #line 274 "..\..\PortfolioAnalysis.xaml"
            this.Forecast_Companies.Click += new System.Windows.RoutedEventHandler(this.Forecast_Companies_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

