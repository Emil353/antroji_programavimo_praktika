using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

using Antras_Praktinias_Darbas.SQL;
using Antras_Praktinias_Darbas.Object;
using Antras_Praktinias_Darbas.Dialog;
using Antras_Praktinias_Darbas.Dialog.Assign;

namespace Antras_Praktinias_Darbas.Pages {
    public partial class Page_Admin : Page {
        SQL_Connection Conn;
        ListBox CurrentBox;
        int CurrentBoxTab;

        public Page_Admin() {
            InitializeComponent();
            Conn = (SQL_Connection)App.Current.Properties["sql"];

            Application.Current.Properties["ListBox_Student"] = ListBox_Student;
            Application.Current.Properties["ListBox_Teacher"] = ListBox_Teacher;
            Application.Current.Properties["ListBox_Group"] = ListBox_Group;
            Application.Current.Properties["ListBox_Subject"] = ListBox_Subject;

            CurrentBox = ListBox_Student;
            CurrentBoxTab = 1;
        }

        internal void NavigationService_LoadCompleted(object sender, NavigationEventArgs e) {
            ListBox_Student.ItemsSource = Conn.GetStudents();
            ListBox_Teacher.ItemsSource = Conn.GetTeachers();
            ListBox_Group.ItemsSource = Conn.GetGroups();
            ListBox_Subject.ItemsSource = Conn.GetSubjects();

            NavigationService.LoadCompleted -= NavigationService_LoadCompleted;
        }

        // Log Out Function
        private void BTN_LogOut(object sender, RoutedEventArgs e) {
            Page_Login page = new Page_Login();
            _ = NavigationService.Navigate(page);
        }

        // ListBox Show/Hide Functions
        private void BTN_ShowStudentList(object sender, RoutedEventArgs e) {
            if (ListBox_Student.Visibility == Visibility.Visible)
                return;

            CurrentBox.Visibility = Visibility.Hidden;
            CurrentBox = ListBox_Student;
            CurrentBox.Visibility = Visibility.Visible;
            CurrentBoxTab = 1;
        }
        private void BTN_ShowTeacherList(object sender, RoutedEventArgs e) {
            if (ListBox_Teacher.Visibility == Visibility.Visible)
                return;

            CurrentBox.Visibility = Visibility.Hidden;
            CurrentBox = ListBox_Teacher;
            CurrentBox.Visibility = Visibility.Visible;
            CurrentBoxTab = 2;
        }
        private void BTN_ShowGroupList(object sender, RoutedEventArgs e) {
            if (ListBox_Group.Visibility == Visibility.Visible)
                return;

            CurrentBox.Visibility = Visibility.Hidden;
            CurrentBox = ListBox_Group;
            CurrentBox.Visibility = Visibility.Visible;
            CurrentBoxTab = 3;
        }
        private void BTN_ShowSubjectList(object sender, RoutedEventArgs e) {
            if (ListBox_Subject.Visibility == Visibility.Visible)
                return;

            CurrentBox.Visibility = Visibility.Hidden;
            CurrentBox = ListBox_Subject;
            CurrentBox.Visibility = Visibility.Visible;
            CurrentBoxTab = 4;
        }

        // ListBox Create New Entry / Delete Index Functions
        private void BTN_CreateNewEntry(object sender, RoutedEventArgs e) {
            switch(CurrentBoxTab) {
                case 1:
                    Dialog_Student New_Student = new Dialog_Student();
                    New_Student.ShowDialog();
                    break;
                case 2:
                    Dialog_Teacher New_Teacher = new Dialog_Teacher();
                    New_Teacher.ShowDialog();
                    break;
                case 3:
                    Dialog_Group New_Group = new Dialog_Group();
                    New_Group.ShowDialog();
                    break;
                case 4:
                    Dialog_Subject New_Subject = new Dialog_Subject();
                    New_Subject.ShowDialog();
                    break;
            }
        }
        private void BTN_DeleteSelectedItem(object sender, RoutedEventArgs e) {
            switch(CurrentBoxTab) {
                case 1:
                    User SelectedStudent = ListBox_Student.SelectedItem as User;
                    if(SelectedStudent == null) {
                        _ = MessageBox.Show("No student is selected!", "Error!");
                        return;
                    }

                    Conn.DeleteUser(SelectedStudent.Id);
                    ListBox_Student.ItemsSource = Conn.GetStudents();
                    Application.Current.Properties["users"] = Conn.GetUsers();
                    break;

                case 2:
                    User SelectedTeacher = ListBox_Teacher.SelectedItem as User;
                    if (SelectedTeacher == null) {
                        _ = MessageBox.Show("No teacher is selected!", "Error!");
                        return;
                    }

                    Conn.DeleteUser(SelectedTeacher.Id);
                    ListBox_Teacher.ItemsSource = Conn.GetTeachers();
                    Application.Current.Properties["users"] = Conn.GetUsers();
                    break;

                case 3:
                    Group SelectedGroup = ListBox_Group.SelectedItem as Group;
                    if (SelectedGroup == null) {
                        _ = MessageBox.Show("No group is selected!", "Error!");
                        return;
                    }

                    Conn.DeleteGroup(SelectedGroup.Id);
                    ListBox_Group.ItemsSource = Conn.GetGroups();
                    Application.Current.Properties["groups"] = Conn.GetGroups();
                    break;

                case 4:
                    Subject SelectedSubject = ListBox_Subject.SelectedItem as Subject;
                    if (SelectedSubject == null) {
                        _ = MessageBox.Show("No subject is selected!", "Error!");
                        return;
                    }

                    Conn.DeleteSubject(SelectedSubject.Id);
                    ListBox_Subject.ItemsSource = Conn.GetSubjects();
                    Application.Current.Properties["subjects"] = Conn.GetSubjects();
                    break;
            }
        }

        // Assign Entry Functions
        private void BTN_AssignTeacherToSubject(object sender, RoutedEventArgs e) {
            Dialog_AssignTeacherToSubject Teacher_To_Subject = new Dialog_AssignTeacherToSubject();
            Teacher_To_Subject.ShowDialog();
        }
        private void BTN_AssignStudentToGroup(object sender, RoutedEventArgs e) {
            Dialog_AssignStudentToGroup Student_To_Group = new Dialog_AssignStudentToGroup();
            Student_To_Group.ShowDialog();
        }
        private void BTN_AssignSubjectToGroup(object sender, RoutedEventArgs e) {
            Dialog_AssignSubjectToGroup Subject_To_Group = new Dialog_AssignSubjectToGroup();
            Subject_To_Group.ShowDialog();
        }

        // Grid Page Functions
        private void BTN_GridPage1(object sender, RoutedEventArgs e) {
            if (Grid_Page_1.Visibility == Visibility.Visible)
                return;

            Grid_Page_1.Visibility = Visibility.Visible;
            Grid_Page_2.Visibility = Visibility.Hidden;
        }
        private void BTN_GridPage2(object sender, RoutedEventArgs e) {
            if (Grid_Page_2.Visibility == Visibility.Visible)
                return;

            Grid_Page_2.Visibility = Visibility.Visible;
            Grid_Page_1.Visibility = Visibility.Hidden;
        }
    }
}
