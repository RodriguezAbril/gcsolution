﻿#pragma checksum "..\..\..\..\..\..\..\Modules\Ektelesis\LRG\Views\History\CLTView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BB051D4C6928A4534322056713D0427B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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
using Telerik.Windows.Controls;


namespace GGGC.Admin.Modules.Ektelesis.LRG.Views.History {
    
    
    /// <summary>
    /// CLTView
    /// </summary>
    public partial class CLTView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\..\..\..\Modules\Ektelesis\LRG\Views\History\CLTView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Telerik.Windows.Controls.RadWatermarkTextBox txtFolio;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\..\..\Modules\Ektelesis\LRG\Views\History\CLTView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBuscar;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\..\..\Modules\Ektelesis\LRG\Views\History\CLTView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Telerik.Windows.Controls.RadGridView rgv;
        
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
            System.Uri resourceLocater = new System.Uri("/GGGC.Admin;component/modules/ektelesis/lrg/views/history/cltview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\Modules\Ektelesis\LRG\Views\History\CLTView.xaml"
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
            this.txtFolio = ((Telerik.Windows.Controls.RadWatermarkTextBox)(target));
            
            #line 21 "..\..\..\..\..\..\..\Modules\Ektelesis\LRG\Views\History\CLTView.xaml"
            this.txtFolio.KeyDown += new System.Windows.Input.KeyEventHandler(this.txtCodigo_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnBuscar = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\..\..\..\Modules\Ektelesis\LRG\Views\History\CLTView.xaml"
            this.btnBuscar.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.rgv = ((Telerik.Windows.Controls.RadGridView)(target));
            
            #line 27 "..\..\..\..\..\..\..\Modules\Ektelesis\LRG\Views\History\CLTView.xaml"
            this.rgv.FieldFilterEditorCreated += new System.EventHandler<Telerik.Windows.Controls.GridView.EditorCreatedEventArgs>(this.rgv_FieldFilterEditorCreated);
            
            #line default
            #line hidden
            
            #line 27 "..\..\..\..\..\..\..\Modules\Ektelesis\LRG\Views\History\CLTView.xaml"
            this.rgv.FilterOperatorsLoading += new System.EventHandler<Telerik.Windows.Controls.GridView.FilterOperatorsLoadingEventArgs>(this.rgv_FilterOperatorsLoading);
            
            #line default
            #line hidden
            
            #line 27 "..\..\..\..\..\..\..\Modules\Ektelesis\LRG\Views\History\CLTView.xaml"
            this.rgv.Filtered += new System.EventHandler<Telerik.Windows.Controls.GridView.GridViewFilteredEventArgs>(this.rgv_Filtered);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

