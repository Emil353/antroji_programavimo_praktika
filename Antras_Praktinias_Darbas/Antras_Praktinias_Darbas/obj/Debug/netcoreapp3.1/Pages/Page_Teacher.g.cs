#pragma checksum "..\..\..\..\Pages\Page_Teacher.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3C08EAAA92E5E39DF4FFD85EE5B6B4F41235936B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Antras_Praktinias_Darbas.Pages;
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
    /// Page_Teacher
    /// </summary>
    public partial class Page_Teacher : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\..\Pages\Page_Teacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Text_TeacherName;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Pages\Page_Teacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBox_Subject;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Pages\Page_Teacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBox_Group;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\Pages\Page_Teacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBox_Student;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\Pages\Page_Teacher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBox_Grades;
        
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
            System.Uri resourceLocater = new System.Uri("/Antras_Praktinias_Darbas;component/pages/page_teacher.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Page_Teacher.xaml"
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
            this.Text_TeacherName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            
            #line 43 "..\..\..\..\Pages\Page_Teacher.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BTN_LogOut);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ComboBox_Subject = ((System.Windows.Controls.ComboBox)(target));
            
            #line 50 "..\..\..\..\Pages\Page_Teacher.xaml"
            this.ComboBox_Subject.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.BOX_PickedSubject);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ComboBox_Group = ((System.Windows.Controls.ComboBox)(target));
            
            #line 60 "..\..\..\..\Pages\Page_Teacher.xaml"
            this.ComboBox_Group.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.BOX_PickedGroup);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ComboBox_Student = ((System.Windows.Controls.ComboBox)(target));
            
            #line 70 "..\..\..\..\Pages\Page_Teacher.xaml"
            this.ComboBox_Student.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.BOX_PickedStudent);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ListBox_Grades = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            
            #line 95 "..\..\..\..\Pages\Page_Teacher.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BTN_CreateNewGrade);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 96 "..\..\..\..\Pages\Page_Teacher.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BTN_ChangeGrade);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 97 "..\..\..\..\Pages\Page_Teacher.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BTN_DeleteGrade);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

