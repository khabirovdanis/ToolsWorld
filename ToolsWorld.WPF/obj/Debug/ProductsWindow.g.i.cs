﻿#pragma checksum "..\..\ProductsWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DF656EED728F5FC2A4EEB31C7664A3037E4E7A6D4A7BB8B9FBB80D3462463912"
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
using ToolsWorld.WPF;


namespace ToolsWorld.WPF {
    
    
    /// <summary>
    /// ProductsWindow
    /// </summary>
    public partial class ProductsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\ProductsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ExitMenuItem;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\ProductsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid productsDataGrid;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\ProductsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InsertButton;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\ProductsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateButton;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\ProductsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteButton;
        
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
            System.Uri resourceLocater = new System.Uri("/ToolsWorld.WPF;component/productswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ProductsWindow.xaml"
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
            this.ExitMenuItem = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 2:
            this.productsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.InsertButton = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\ProductsWindow.xaml"
            this.InsertButton.Click += new System.Windows.RoutedEventHandler(this.InsertButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.UpdateButton = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\ProductsWindow.xaml"
            this.UpdateButton.Click += new System.Windows.RoutedEventHandler(this.UpdateButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DeleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\ProductsWindow.xaml"
            this.DeleteButton.Click += new System.Windows.RoutedEventHandler(this.DeleteButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

