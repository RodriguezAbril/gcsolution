﻿#pragma checksum "..\..\..\..\..\AZ\Garage\Views\OutputDetailServiceView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0957A8A18322F1AD500D3E50B031DD8D31DC89FF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GGGC.Admin.ERP.Modules.MTE.Garage.Support;
using Syncfusion;
using Syncfusion.Windows;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools;
using Syncfusion.Windows.Tools.Controls;
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


namespace GGGC.Admin.AZ.Garage.Views {
    
    
    /// <summary>
    /// OutputDetailServiceView
    /// </summary>
    public partial class OutputDetailServiceView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 76 "..\..\..\..\..\AZ\Garage\Views\OutputDetailServiceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTitle;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\..\AZ\Garage\Views\OutputDetailServiceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Telerik.Windows.Controls.RadComboBox item;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\..\..\AZ\Garage\Views\OutputDetailServiceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Telerik.Windows.Controls.RadWatermarkTextBox txtDescripcion;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\..\..\AZ\Garage\Views\OutputDetailServiceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Telerik.Windows.Controls.RadMaskedNumericInput quantity;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\..\..\AZ\Garage\Views\OutputDetailServiceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Telerik.Windows.Controls.RadMaskedNumericInput txtPrecio;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\..\..\..\AZ\Garage\Views\OutputDetailServiceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
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
            System.Uri resourceLocater = new System.Uri("/GGGC.Admin;component/az/garage/views/outputdetailserviceview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\AZ\Garage\Views\OutputDetailServiceView.xaml"
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
            
            #line 9 "..\..\..\..\..\AZ\Garage\Views\OutputDetailServiceView.xaml"
            ((GGGC.Admin.AZ.Garage.Views.OutputDetailServiceView)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.item = ((Telerik.Windows.Controls.RadComboBox)(target));
            
            #line 89 "..\..\..\..\..\AZ\Garage\Views\OutputDetailServiceView.xaml"
            this.item.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.item_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 89 "..\..\..\..\..\AZ\Garage\Views\OutputDetailServiceView.xaml"
            this.item.KeyDown += new System.Windows.Input.KeyEventHandler(this.item_KeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtDescripcion = ((Telerik.Windows.Controls.RadWatermarkTextBox)(target));
            return;
            case 5:
            this.quantity = ((Telerik.Windows.Controls.RadMaskedNumericInput)(target));
            
            #line 117 "..\..\..\..\..\AZ\Garage\Views\OutputDetailServiceView.xaml"
            this.quantity.ValueChanged += new System.EventHandler<Telerik.Windows.RadRoutedEventArgs>(this.quantity_ValueChanged);
            
            #line default
            #line hidden
            
            #line 117 "..\..\..\..\..\AZ\Garage\Views\OutputDetailServiceView.xaml"
            this.quantity.KeyDown += new System.Windows.Input.KeyEventHandler(this.quantity_KeyDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtPrecio = ((Telerik.Windows.Controls.RadMaskedNumericInput)(target));
            return;
            case 7:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 160 "..\..\..\..\..\AZ\Garage\Views\OutputDetailServiceView.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.updtButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 161 "..\..\..\..\..\AZ\Garage\Views\OutputDetailServiceView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

