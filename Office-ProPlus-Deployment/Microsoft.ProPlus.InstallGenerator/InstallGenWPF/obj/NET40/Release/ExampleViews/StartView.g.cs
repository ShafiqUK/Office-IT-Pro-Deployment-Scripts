﻿#pragma checksum "..\..\..\..\ExampleViews\StartView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "ACF6658CAF0288531F1DAC081DAE657C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
using MetroDemo;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using WpfAnimatedGif;


namespace MetroDemo.ExampleViews {
    
    
    /// <summary>
    /// StartView
    /// </summary>
    public partial class StartView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\ExampleViews\StartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Product;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\ExampleViews\StartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.MetroAnimatedSingleRowTabControl MainTabControl;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\ExampleViews\StartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem OptionalTab;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\ExampleViews\StartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StartNew;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\..\ExampleViews\StartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ImportExisting;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\ExampleViews\StartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ManageLocal;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\..\ExampleViews\StartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgManageLocal;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\..\ExampleViews\StartView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image WaitManageLocal;
        
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
            System.Uri resourceLocater = new System.Uri("/OfficeProPlusInstallGenerator;component/exampleviews/startview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ExampleViews\StartView.xaml"
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
            
            #line 13 "..\..\..\..\ExampleViews\StartView.xaml"
            ((MetroDemo.ExampleViews.StartView)(target)).Loaded += new System.Windows.RoutedEventHandler(this.StartView_OnLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Product = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.MainTabControl = ((MahApps.Metro.Controls.MetroAnimatedSingleRowTabControl)(target));
            return;
            case 4:
            this.OptionalTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 5:
            this.StartNew = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\..\ExampleViews\StartView.xaml"
            this.StartNew.Click += new System.Windows.RoutedEventHandler(this.StartNew_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ImportExisting = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\..\..\ExampleViews\StartView.xaml"
            this.ImportExisting.Click += new System.Windows.RoutedEventHandler(this.ImportExisting_Click_1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ManageLocal = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\..\..\ExampleViews\StartView.xaml"
            this.ManageLocal.Click += new System.Windows.RoutedEventHandler(this.ManageLocal_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ImgManageLocal = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.WaitManageLocal = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

