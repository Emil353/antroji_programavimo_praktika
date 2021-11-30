using System.Windows;

using Antras_Praktinias_Darbas.SQL;
using Antras_Praktinias_Darbas.Object;

namespace Antras_Praktinias_Darbas.Dialog.Assign {
    public partial class Dialog_AssignStudentToGroup : Window {
        SQL_Connection Conn;

        public Dialog_AssignStudentToGroup() {
            InitializeComponent();
            Conn = (SQL_Connection)Application.Current.Properties["sql"];

            ListBox_Student.ItemsSource = Conn.GetStudents();
            ComboBox_Group.ItemsSource = Conn.GetGroups();
        }

        private void BTN_Cancel(object sender, RoutedEventArgs e) {
            Close();
        }
        private void BTN_AssignStudentToGroup(object sender, RoutedEventArgs e) {
            User SelectedUser = ListBox_Student.SelectedItem as User;
            Group SelectedGroup = ComboBox_Group.SelectedItem as Group;

            string Error = "";

            if (SelectedUser == null)
                Error += "No student selected!" + "\r\n";
            if (SelectedGroup == null)
                Error += "No group selected!" + "\r\n";

            if(Error.Length != 0) {
                _ = MessageBox.Show(Error, "Exception!");
                return;
            }

            string StudentFullName = SelectedUser.FirstName + " " + SelectedUser.LastName;

            if (Conn.CountStudentInGroup(SelectedUser.Id, SelectedGroup.Id) > 0) {
                _ = MessageBox.Show("Student '" + StudentFullName + "' is already assigned to group - " + SelectedGroup.GroupName, "Error!");
                return;
            }

            Conn.RemoveStudentFromGroup(SelectedUser.Id);
            Conn.AssignStudentToGroup(StudentFullName, SelectedUser.Id, SelectedGroup.GroupName, SelectedGroup.Id);

            Close();
            _ = MessageBox.Show("Student " + StudentFullName + " has been assigned to group - " + SelectedGroup.GroupName, "Success!");
        }
    }
}
