﻿#pragma checksum "..\..\..\Windows\PrincipalWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F310179B964034570D25C9FB9EF98061"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using IlogicContabilidad.Windows;
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


namespace IlogicContabilidad.Windows {
    
    
    /// <summary>
    /// PrincipalWindow
    /// </summary>
    public partial class PrincipalWindow : IlogicContabilidad.Windows.MetroWindowBase, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Windows\PrincipalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu menu;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Windows\PrincipalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem CuentaWindow;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Windows\PrincipalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ComprobWindow;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Windows\PrincipalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem NewCompronWindow;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Windows\PrincipalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CommandGuardar;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Windows\PrincipalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CommandNuevo;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Windows\PrincipalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CommandGuardar_Copy;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Windows\PrincipalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CommandNuevo_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/IlogicContabilidad;component/windows/principalwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\PrincipalWindow.xaml"
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
            this.menu = ((System.Windows.Controls.Menu)(target));
            return;
            case 2:
            this.CuentaWindow = ((System.Windows.Controls.MenuItem)(target));
            
            #line 17 "..\..\..\Windows\PrincipalWindow.xaml"
            this.CuentaWindow.Click += new System.Windows.RoutedEventHandler(this.AbrirForm);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ComprobWindow = ((System.Windows.Controls.MenuItem)(target));
            
            #line 18 "..\..\..\Windows\PrincipalWindow.xaml"
            this.ComprobWindow.Click += new System.Windows.RoutedEventHandler(this.AbrirForm);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 25 "..\..\..\Windows\PrincipalWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Close);
            
            #line default
            #line hidden
            return;
            case 5:
            this.NewCompronWindow = ((System.Windows.Controls.MenuItem)(target));
            
            #line 28 "..\..\..\Windows\PrincipalWindow.xaml"
            this.NewCompronWindow.Click += new System.Windows.RoutedEventHandler(this.AbrirForm);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CommandGuardar = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Windows\PrincipalWindow.xaml"
            this.CommandGuardar.Click += new System.Windows.RoutedEventHandler(this.CommandGuardar_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CommandNuevo = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\Windows\PrincipalWindow.xaml"
            this.CommandNuevo.Click += new System.Windows.RoutedEventHandler(this.CommandNuevo_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CommandGuardar_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\Windows\PrincipalWindow.xaml"
            this.CommandGuardar_Copy.Click += new System.Windows.RoutedEventHandler(this.CommandGuardar_Copy_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CommandNuevo_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\Windows\PrincipalWindow.xaml"
            this.CommandNuevo_Copy.Click += new System.Windows.RoutedEventHandler(this.CommandNuevo_Copy_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

