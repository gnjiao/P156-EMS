﻿#pragma checksum "..\..\..\ExpiryAlarm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D328C27EA10E1A66CCE186851BD4423EBD55D5E2"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace EMS {
    
    
    /// <summary>
    /// ExpiryWindow
    /// </summary>
    public partial class ExpiryWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\ExpiryAlarm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_remindLate;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\ExpiryAlarm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_print;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\ExpiryAlarm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txt_partID;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\ExpiryAlarm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txt_sapcode;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\ExpiryAlarm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txt_batchNo;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\ExpiryAlarm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txt_thawingTime;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\ExpiryAlarm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txt_readyTime;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\ExpiryAlarm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txt_expiryTime;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\ExpiryAlarm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txt_mcID;
        
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
            System.Uri resourceLocater = new System.Uri("/EMS;component/expiryalarm.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ExpiryAlarm.xaml"
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
            this.btn_remindLate = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\ExpiryAlarm.xaml"
            this.btn_remindLate.Click += new System.Windows.RoutedEventHandler(this.btn_remindLate_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_print = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\ExpiryAlarm.xaml"
            this.btn_print.Click += new System.Windows.RoutedEventHandler(this.btn_print_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txt_partID = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txt_sapcode = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txt_batchNo = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.txt_thawingTime = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.txt_readyTime = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.txt_expiryTime = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.txt_mcID = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

