﻿#pragma checksum "..\..\..\View\WorkerWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "41B9E9605E2070800BA5E276B1E0D53A67950601B88FD9096592A5B366994982"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using ToolsWorld.WPF.View;


namespace ToolsWorld.WPF.View {
    
    
    /// <summary>
    /// WorkerWindow
    /// </summary>
    public partial class WorkerWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\View\WorkerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label PasswordLabel;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\View\WorkerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LogTextBox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\View\WorkerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\View\WorkerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FullnameTextBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\View\WorkerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TelTextBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\View\WorkerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DepartamentNamesComboBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\View\WorkerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox LvlsComboBox;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\View\WorkerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EnterButton;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\View\WorkerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelButton;
        
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
            System.Uri resourceLocater = new System.Uri("/ToolsWorld.WPF;component/view/workerwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\WorkerWindow.xaml"
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
            this.PasswordLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.LogTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.PasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.FullnameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TelTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.DepartamentNamesComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.LvlsComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.EnterButton = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\View\WorkerWindow.xaml"
            this.EnterButton.Click += new System.Windows.RoutedEventHandler(this.EnterButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\View\WorkerWindow.xaml"
            this.CancelButton.Click += new System.Windows.RoutedEventHandler(this.CancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

