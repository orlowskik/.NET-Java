﻿#pragma checksum "..\..\SimulateWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8BE429FAFD730A7CF36AA933A97CAD54F1DD25F722E1D0E55802CC62B169CAF7"
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
    /// SimulateWindow
    /// </summary>
    public partial class SimulateWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\SimulateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ContactsList2;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\SimulateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NameTextBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\SimulateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox YouPayBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\SimulateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox YouReceiveBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\SimulateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock1;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\SimulateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock2;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\SimulateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SumBox;
        
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
            System.Uri resourceLocater = new System.Uri("/APP;component/simulatewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SimulateWindow.xaml"
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
            
            #line 11 "..\..\SimulateWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnSimulate);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 12 "..\..\SimulateWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnExit);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 13 "..\..\SimulateWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnCheck);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ContactsList2 = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.NameTextBox = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.YouPayBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\SimulateWindow.xaml"
            this.YouPayBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.NameTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.YouReceiveBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\SimulateWindow.xaml"
            this.YouReceiveBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.NameTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.textBlock2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.SumBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\SimulateWindow.xaml"
            this.SumBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.NameTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

