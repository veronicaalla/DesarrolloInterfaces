﻿#pragma checksum "..\..\Reserva.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6554F9E6B1784DC8FC18F82FF9825337DBE303D16F9E7643C32F6E424457EE8F"
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
using UT5E4_Veronica;


namespace UT5E4_Veronica {
    
    
    /// <summary>
    /// Reserva
    /// </summary>
    public partial class Reserva : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 43 "..\..\Reserva.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombre;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\Reserva.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtpFecha;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\Reserva.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTelefono;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\Reserva.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtComensales;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\Reserva.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkAsiste;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\Reserva.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDescripcion;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\Reserva.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAceptar;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\Reserva.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelar;
        
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
            System.Uri resourceLocater = new System.Uri("/UT5E4_Veronica;component/reserva.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Reserva.xaml"
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
            this.txtNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.dtpFecha = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.txtTelefono = ((System.Windows.Controls.TextBox)(target));
            
            #line 49 "..\..\Reserva.xaml"
            this.txtTelefono.KeyDown += new System.Windows.Input.KeyEventHandler(this.txtTelefono_KeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtComensales = ((System.Windows.Controls.TextBox)(target));
            
            #line 52 "..\..\Reserva.xaml"
            this.txtComensales.KeyDown += new System.Windows.Input.KeyEventHandler(this.txtComensales_KeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.chkAsiste = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.txtDescripcion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnAceptar = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\Reserva.xaml"
            this.btnAceptar.Click += new System.Windows.RoutedEventHandler(this.btnAceptar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\Reserva.xaml"
            this.btnCancelar.Click += new System.Windows.RoutedEventHandler(this.btnCancelar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
