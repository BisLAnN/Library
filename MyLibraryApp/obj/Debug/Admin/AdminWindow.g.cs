﻿#pragma checksum "..\..\..\Admin\AdminWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "20AF28C88805F544979DC881BD61EB31C7ED6B7197FC811FC4AF20FE3CAFF9A8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MyLibraryApp.Staffer;
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


namespace MyLibraryApp.Staffer {
    
    
    /// <summary>
    /// AdminWindow
    /// </summary>
    public partial class AdminWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\Admin\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Admin\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemove;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Admin\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbSearch;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Admin\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbAsc;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Admin\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbDesc;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Admin\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
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
            System.Uri resourceLocater = new System.Uri("/MyLibraryApp;component/admin/adminwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Admin\AdminWindow.xaml"
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
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Admin\AdminWindow.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnRemove = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\Admin\AdminWindow.xaml"
            this.btnRemove.Click += new System.Windows.RoutedEventHandler(this.btnRemove_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtbSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 44 "..\..\..\Admin\AdminWindow.xaml"
            this.txtbSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtbSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.rbAsc = ((System.Windows.Controls.RadioButton)(target));
            
            #line 49 "..\..\..\Admin\AdminWindow.xaml"
            this.rbAsc.Checked += new System.Windows.RoutedEventHandler(this.rbAsc_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.rbDesc = ((System.Windows.Controls.RadioButton)(target));
            
            #line 50 "..\..\..\Admin\AdminWindow.xaml"
            this.rbDesc.Checked += new System.Windows.RoutedEventHandler(this.rbDesc_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\Admin\AdminWindow.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

