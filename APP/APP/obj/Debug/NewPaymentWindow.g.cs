﻿#pragma checksum "..\..\NewPaymentWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F5C6676AF4EB9094B574F9F29104F60DA54230CC910D56FA2C6718A2731407BD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using APP;
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


namespace APP {
    
    
    /// <summary>
    /// NewPaymentWindow
    /// </summary>
    public partial class NewPaymentWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\NewPaymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\NewPaymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rb1;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\NewPaymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rb2;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\NewPaymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ContactsList3;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\NewPaymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock2;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\NewPaymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock5;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\NewPaymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxLoanSize;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\NewPaymentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock6;
        
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
            System.Uri resourceLocater = new System.Uri("/APP;component/newpaymentwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NewPaymentWindow.xaml"
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
            this.textBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.rb1 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 23 "..\..\NewPaymentWindow.xaml"
            this.rb1.Checked += new System.Windows.RoutedEventHandler(this.HandleCheckPlus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.rb2 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 27 "..\..\NewPaymentWindow.xaml"
            this.rb2.Checked += new System.Windows.RoutedEventHandler(this.HandleCheckMinus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ContactsList3 = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.textBlock2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            
            #line 46 "..\..\NewPaymentWindow.xaml"
            ((System.Windows.Controls.DatePicker)(target)).SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.DatePicker_SelectedDateChangedIssue);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 49 "..\..\NewPaymentWindow.xaml"
            ((System.Windows.Controls.DatePicker)(target)).SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.DatePicker_SelectedDateChangedExpire);
            
            #line default
            #line hidden
            return;
            case 8:
            this.textBlock5 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.TextBoxLoanSize = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.textBlock6 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            
            #line 64 "..\..\NewPaymentWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnSubmit);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 65 "..\..\NewPaymentWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnExit);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

