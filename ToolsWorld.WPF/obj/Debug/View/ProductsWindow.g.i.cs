﻿#pragma checksum "..\..\..\View\ProductsWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A6D7CB6BB5447B7F8BD946484ED1CC1E69CA5AC2636FD1E74AEF008F314495E7"
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
        
        
        #line 27 "..\..\..\View\ProductsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ExitMenuItem;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\View\ProductsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem PlaceOrderMenuItem;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\View\ProductsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ParamComboBox;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\View\ProductsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ValueTextBox;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\View\ProductsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchButton;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\View\ProductsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FilterButton;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\View\ProductsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RefreshButton;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\View\ProductsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ProductsDataGrid;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\View\ProductsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InsertButton;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\View\ProductsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateButton;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\View\ProductsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteButton;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\View\ProductsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LogLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/ToolsWorld.WPF;component/view/productswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\ProductsWindow.xaml"
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
            
            #line 11 "..\..\..\View\ProductsWindow.xaml"
            ((ToolsWorld.WPF.ProductsWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ExitMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 27 "..\..\..\View\ProductsWindow.xaml"
            this.ExitMenuItem.Click += new System.Windows.RoutedEventHandler(this.ExitMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PlaceOrderMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 30 "..\..\..\View\ProductsWindow.xaml"
            this.PlaceOrderMenuItem.Click += new System.Windows.RoutedEventHandler(this.PlaceOrderMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ParamComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.ValueTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.SearchButton = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\View\ProductsWindow.xaml"
            this.SearchButton.Click += new System.Windows.RoutedEventHandler(this.SearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.FilterButton = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\View\ProductsWindow.xaml"
            this.FilterButton.Click += new System.Windows.RoutedEventHandler(this.FilterButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.RefreshButton = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\View\ProductsWindow.xaml"
            this.RefreshButton.Click += new System.Windows.RoutedEventHandler(this.RefreshButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ProductsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            this.InsertButton = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\View\ProductsWindow.xaml"
            this.InsertButton.Click += new System.Windows.RoutedEventHandler(this.InsertButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.UpdateButton = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\..\View\ProductsWindow.xaml"
            this.UpdateButton.Click += new System.Windows.RoutedEventHandler(this.UpdateButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.DeleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\View\ProductsWindow.xaml"
            this.DeleteButton.Click += new System.Windows.RoutedEventHandler(this.DeleteButton_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.LogLabel = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

