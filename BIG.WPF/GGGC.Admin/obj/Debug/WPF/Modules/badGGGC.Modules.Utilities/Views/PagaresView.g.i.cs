﻿#pragma checksum "..\..\..\..\..\..\WPF\Modules\badGGGC.Modules.Utilities\Views\PagaresView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2F05A2479AF13E97CD90EDE3EF3E745617838736"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GGGC.UI.Infrastructure;
using GGGC.UI.Infrastructure.Prism;
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


namespace GGGC.Modules.Utilities.Views {
    
    
    /// <summary>
    /// PagaresView
    /// </summary>
    public partial class PagaresView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\..\..\WPF\Modules\badGGGC.Modules.Utilities\Views\PagaresView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\..\WPF\Modules\badGGGC.Modules.Utilities\Views\PagaresView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtID;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\..\WPF\Modules\badGGGC.Modules.Utilities\Views\PagaresView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearch;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\..\WPF\Modules\badGGGC.Modules.Utilities\Views\PagaresView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombre;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\..\WPF\Modules\badGGGC.Modules.Utilities\Views\PagaresView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFecha;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\..\WPF\Modules\badGGGC.Modules.Utilities\Views\PagaresView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCondicion;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\..\WPF\Modules\badGGGC.Modules.Utilities\Views\PagaresView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPagares;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\..\..\WPF\Modules\badGGGC.Modules.Utilities\Views\PagaresView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnImprimir;
        
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
            System.Uri resourceLocater = new System.Uri("/GGGC.Admin;component/wpf/modules/badgggc.modules.utilities/views/pagaresview.xam" +
                    "l", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\WPF\Modules\badGGGC.Modules.Utilities\Views\PagaresView.xaml"
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
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.txtID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btnSearch = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\..\..\WPF\Modules\badGGGC.Modules.Utilities\Views\PagaresView.xaml"
            this.btnSearch.Click += new System.Windows.RoutedEventHandler(this.btnSearch_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtFecha = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtCondicion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtPagares = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btnImprimir = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\..\..\WPF\Modules\badGGGC.Modules.Utilities\Views\PagaresView.xaml"
            this.btnImprimir.Click += new System.Windows.RoutedEventHandler(this.btnImprimir_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

