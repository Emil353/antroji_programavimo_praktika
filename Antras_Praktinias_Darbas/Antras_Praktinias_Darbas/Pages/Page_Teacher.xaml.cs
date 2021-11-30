using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

using Antras_Praktinias_Darbas.SQL;
using Antras_Praktinias_Darbas.Object;
using Antras_Praktinias_Darbas.Dialog.Create;

namespace Antras_Praktinias_Darbas.Pages {
    public partial class Page_Teacher : Page {
        SQL_Connection Conn;
        User CurrentTeacher;
        User SelectedStudent;
        Subject SelectedSubject;
        Group SelectedGroup;

        public Page_Teacher() {
            InitializeComponent();
            Conn = (SQL_Connection)App.Current.Properties["sql"];
            Application.Current.Properties["ListBox_Grades"] = ListBox_Grades;
        }

        // Log Out Function
        private void BTN_LogOut(object sender, RoutedEventArgs e) {
            Page_Login page = new Page_Login();
            CleanUp();
            _ = NavigationService.Navigate(page);
        }

        public void CleanUp() {
            ComboBox_Subject.ItemsSource = null;
            ComboBox_Group.ItemsSource = null;
            ComboBox_Subject.ItemsSource = null;
            ListBox_Grades.ItemsSource = null;
        }

        internal void NavigationService_LoadCompleted(object sender, NavigationEventArgs e) {
            CurrentTeacher = (User)e.ExtraData;
            Text_TeacherName.Text = CurrentTeacher.FirstName + " " + CurrentTeacher.LastName;
            ComboBox_Subject.ItemsSource = Conn.GetTeacherSubjects(CurrentTeacher.Id);
            NavigationService.LoadCompleted -= NavigationService_LoadCompleted;
        }

        private void BTN_CreateNewGrade(object sender, RoutedEventArgs e) {
            if (SelectedSubject == null || SelectedGroup == null || SelectedStudent == null)
                return;

            Dialog_Grade New_Grade = new Dialog_Grade();

            New_Grade.Student = SelectedStudent;
            New_Grade.Teacher = CurrentTeacher;
            New_Grade.Subject = SelectedSubject;
            New_Grade.Grades = ListBox_Grades;

            New_Grade.ShowDialog();
        }

        private void BTN_DeleteGrade(object sender, RoutedEventArgs e) {
            Grade SelectedGrade = ListBox_Grades.SelectedItem as Grade;
            if(SelectedGrade == null) {
                _ = MessageBox.Show("Please select a grade!", "Exception!");
                return;
            }

            Conn.RemoveGrade(SelectedGrade.Id);
            ListBox_Grades.ItemsSource = Conn.GetStudentGradesFromSubject(SelectedStudent.Id, SelectedSubject.Id);
        }

        // ComboBox SelectionChange Functions
        private void BOX_PickedSubject(object sender, SelectionChangedEventArgs e) {
            SelectedSubject = ComboBox_Subject.SelectedItem as Subject;
            if (SelectedSubject == null)
                return;

            ComboBox_Student.ItemsSource = null;
            ListBox_Grades.ItemsSource = null;
            
            ComboBox_Group.ItemsSource = Conn.GetGroupsWithSubject(SelectedSubject.Id);
        }
        private void BOX_PickedGroup(object sender, SelectionChangedEventArgs e) {
            SelectedGroup = ComboBox_Group.SelectedItem as Group;
            if (SelectedGroup == null)
                return;

            ListBox_Grades.ItemsSource = null;

            ComboBox_Student.ItemsSource = Conn.GetStudentsInGroup(SelectedGroup.Id);
        }
        private void BOX_PickedStudent(object sender, SelectionChangedEventArgs e) {
            SelectedStudent = ComboBox_Student.SelectedItem as User;
            if (SelectedStudent == null)
                return;

            ListBox_Grades.ItemsSource = Conn.GetStudentGradesFromSubject(SelectedStudent.Id, SelectedSubject.Id);
        }
    }
}
