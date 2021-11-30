using System.Windows;

using Antras_Praktinias_Darbas.SQL;
using Antras_Praktinias_Darbas.Object;

namespace Antras_Praktinias_Darbas.Dialog.Assign {
    /// <summary>
    /// Interaction logic for Dialog_AssignTeacherToSubject.xaml
    /// </summary>
    public partial class Dialog_AssignTeacherToSubject : Window {
        SQL_Connection Conn;

        public Dialog_AssignTeacherToSubject() {
            InitializeComponent();
            Conn = (SQL_Connection)Application.Current.Properties["sql"];

            ListBox_Teacher.ItemsSource = Conn.GetTeachers();
            ComboBox_Subject.ItemsSource = Conn.GetSubjects();
        }

        private void BTN_Cancel(object sender, RoutedEventArgs e) {
            Close();
        }
        private void BTN_AssignTeacherToSubject(object sender, RoutedEventArgs e) {
            User SelectedTeacher = ListBox_Teacher.SelectedItem as User;
            Subject SelectedSubject = ComboBox_Subject.SelectedItem as Subject;

            string Error = "";

            if (SelectedTeacher == null)
                Error += "No subject selected!" + "\r\n";
            if (SelectedSubject == null)
                Error += "No group selected!" + "\r\n";

            if (Error.Length != 0) {
                _ = MessageBox.Show(Error, "Exception!");
                return;
            }

            string FullName = SelectedTeacher.FirstName + " " + SelectedTeacher.LastName;

            if (Conn.CountTeacherInSubject(SelectedTeacher.Id, SelectedSubject.Id) > 0) {
                _ = MessageBox.Show("Teacher '" + FullName + "' is already assigned to subject - " + SelectedSubject.SubjectName, "Error!");
                return;
            }

            Conn.AssignTeacherToSubject(FullName, SelectedTeacher.Id, SelectedSubject.SubjectName, SelectedSubject.Id);


            Close();
            _ = MessageBox.Show("Teacher '" + FullName  + "' has been assigned to subject - " + SelectedSubject.SubjectName, "Success!");
        }
    }
}
