﻿#pragma checksum "..\..\..\ViewWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6DCC7D437E19A453672927F595AF7E218ABC151A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using Text_Editor;


namespace Text_Editor {
    
    
    /// <summary>
    /// ViewWindow
    /// </summary>
    public partial class ViewWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\ViewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\ViewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\ViewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox surnameBox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\ViewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox emailBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\ViewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox roleBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\ViewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox descriptionBox;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\ViewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitBtn;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\ViewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBtn;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\ViewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NextBtn;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\ViewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditBtn;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\ViewWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Text Editor;V1.0.0.0;component/viewwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ViewWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.idBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.nameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.surnameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.emailBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.roleBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.descriptionBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.ExitBtn = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\ViewWindow.xaml"
            this.ExitBtn.Click += new System.Windows.RoutedEventHandler(this.ExitToMain);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\ViewWindow.xaml"
            this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.PreviousPerson);
            
            #line default
            #line hidden
            return;
            case 9:
            this.NextBtn = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\ViewWindow.xaml"
            this.NextBtn.Click += new System.Windows.RoutedEventHandler(this.NextPersonBtn);
            
            #line default
            #line hidden
            return;
            case 10:
            this.EditBtn = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\ViewWindow.xaml"
            this.EditBtn.Click += new System.Windows.RoutedEventHandler(this.EditPerson);
            
            #line default
            #line hidden
            return;
            case 11:
            this.SaveBtn = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\ViewWindow.xaml"
            this.SaveBtn.Click += new System.Windows.RoutedEventHandler(this.SaveEdit);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

