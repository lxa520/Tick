﻿#pragma checksum "..\..\..\Page\OrdinaryTimerPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9BAAE961135A93FD6797F8B5A4AF81A2E5B2C7E8FB5D5AD36D0E960BD14EBF06"
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
using System.Windows.Shell;
using Tick;


namespace Tick {
    
    
    /// <summary>
    /// OrdinaryTimerPage
    /// </summary>
    public partial class OrdinaryTimerPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Page\OrdinaryTimerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Tick.TickControl MyConrtol;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Page\OrdinaryTimerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Tick.TextShowControl showHour;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Page\OrdinaryTimerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Tick.TextShowControl showMinute;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Page\OrdinaryTimerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Tick.TextShowControl showSecond;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Page\OrdinaryTimerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Tick.DigitalTubeControl digiteHour;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Page\OrdinaryTimerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Tick.DigitalTubeControl digiteMinute;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Page\OrdinaryTimerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Tick.DigitalTubeControl digiteSecond;
        
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
            System.Uri resourceLocater = new System.Uri("/Tick;component/page/ordinarytimerpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Page\OrdinaryTimerPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.MyConrtol = ((Tick.TickControl)(target));
            return;
            case 2:
            this.showHour = ((Tick.TextShowControl)(target));
            return;
            case 3:
            this.showMinute = ((Tick.TextShowControl)(target));
            return;
            case 4:
            this.showSecond = ((Tick.TextShowControl)(target));
            return;
            case 5:
            this.digiteHour = ((Tick.DigitalTubeControl)(target));
            return;
            case 6:
            this.digiteMinute = ((Tick.DigitalTubeControl)(target));
            return;
            case 7:
            this.digiteSecond = ((Tick.DigitalTubeControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

