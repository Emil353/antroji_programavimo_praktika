using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

using Antras_Praktinias_Darbas.SQL;
using Antras_Praktinias_Darbas.Object;
using System;

namespace Antras_Praktinias_Darbas.Pages {
    public partial class Page_Student : Page {
        SQL_Connection Conn;
        User CurrentStudent;
        Group StudentGroup;


        public Page_Student() {
            InitializeComponent();
            Conn = (SQL_Connection)App.Current.Properties["sql"];
        }

        internal void NavigationService_LoadCompleted(object sender, NavigationEventArgs e) {
            CurrentStudent = (User)e.ExtraData;
            Text_StudentName.Text = CurrentStudent.FirstName + " " + CurrentStudent.LastName;
            
            StudentGroup = Conn.GetStudentGroup(CurrentStudent.Id);
            ComboBox_Subject.ItemsSource = Conn.GetGroupSubjects(StudentGroup.Id);
            
            NavigationService.LoadCompleted -= NavigationService_LoadCompleted;
        }

        private void BTN_LogOut(object sender, RoutedEventArgs e) {
            Page_Login page = new Page_Login();
            _ = NavigationService.Navigate(page);
        }

        private void BOX_PickedSubject(object sender, SelectionChangedEventArgs e) {
            Subject SelectedSubject = ComboBox_Subject.SelectedItem as Subject;
            if (SelectedSubject == null)
                return;

            ListBox_Grades.ItemsSource = Conn.GetStudentGradesFromSubject(CurrentStudent.Id, SelectedSubject.Id);
        }
    }
}
