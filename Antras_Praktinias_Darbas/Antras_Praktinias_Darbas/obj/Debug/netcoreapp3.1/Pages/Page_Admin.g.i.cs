﻿#pragma checksum "..\..\..\..\Pages\Page_Admin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "141AD68447CB1F476FCF2748B9AF9C7602DA5B5F"
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


namespace Antras_Praktinias_Darbas.Pages {
    
    
    /// <summary>
    /// Page_Admin
    /// </summary>
    public partial class Page_Admin : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\..\Pages\Page_Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid_Page_1;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\Pages\Page_Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBox_Student;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\..\Pages\Page_Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBox_Teacher;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\..\Pages\Page_Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBox_Group;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\..\Pages\Page_Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBox_Subject;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\..\Pages\Page_Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid_Page_2;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Antras_Praktinias_Darbas;V1.0.0.0;component/pages/page_admin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Page_Admin.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 39 "..\..\..\..\Pages\Page_Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BTN_LogOut);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Grid_Page_1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            
            #line 70 "..\..\..\..\Pages\Page_Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BTN_ShowStudentList);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 71 "..\..\..\..\Pages\Page_Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BTN_ShowTeacherList);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 72 "..\..\..\..\Pages\Page_Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BTN_ShowGroupList);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 73 "..\..\..\..\Pages\Page_Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BTN_ShowSubjectList);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ListBox_Student = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.ListBox_Teacher = ((System.Windows.Controls.ListBox)(target));
            return;
            case 9:
            this.ListBox_Group = ((System.Windows.Controls.ListBox)(target));
            return;
            case 10:
            this.ListBox_Subject = ((System.Windows.Controls.ListBox)(target));
            return;
            case 11:
            
            #line 141 "..\..\..\..\Pages\Page_Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BTN_CreateNewEntry);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 142 "..\..\..\..\Pages\Page_Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BTN_DeleteSelectedItem);
            
            #line default
            #line hidden
            return;
            case 13:
            this.Grid_Page_2 = ((System.Windows.Controls.Grid)(target));
            return;
            case 14:
            
            #line 176 "..\..\..\..\Pages\Page_Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BTN_AssignTeacherToSubject);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 177 "..\..\..\..\Pages\Page_Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BTN_AssignStudentToGroup);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 178 "..\..\..\..\Pages\Page_Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BTN_AssignSubjectToGroup);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 182 "..\..\..\..\Pages\Page_Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BTN_GridPage1);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 183 "..\..\..\..\Pages\Page_Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BTN_GridPage2);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

