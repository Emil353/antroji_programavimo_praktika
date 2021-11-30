using System.Windows;

using Antras_Praktinias_Darbas.SQL;
using Antras_Praktinias_Darbas.Object;

namespace Antras_Praktinias_Darbas.Dialog.Assign {
    public partial class Dialog_AssignSubjectToGroup : Window {
        SQL_Connection Conn;

        public Dialog_AssignSubjectToGroup() {
            InitializeComponent();
            Conn = (SQL_Connection)Application.Current.Properties["sql"];

            ListBox_Subject.ItemsSource = Conn.GetSubjects();
            ComboBox_Group.ItemsSource = Conn.GetGroups();
        }

        private void BTN_Cancel(object sender, RoutedEventArgs e) {
            Close();
        }
        private void BTN_AssignSubjectToGroup(object sender, RoutedEventArgs e) {
            Subject SelectedSubject = ListBox_Subject.SelectedItem as Subject;
            Group SelectedGroup = ComboBox_Group.SelectedItem as Group;

            string Error = "";

            if (SelectedSubject == null)
                Error += "No subject selected!" + "\r\n";
            if (SelectedGroup == null)
                Error += "No group selected!" + "\r\n";

            if (Error.Length != 0) {
                _ = MessageBox.Show(Error, "Exception!");
                return;
            }

            if(Conn.CountSubjectInGroup(SelectedGroup.Id, SelectedSubject.Id) > 0) {
                _ = MessageBox.Show("Subject '" + SelectedSubject.SubjectName + "' is already assigned to group - " + SelectedGroup.GroupName, "Error!");
                return;
            }

            Conn.AssignSubjectToGroup(SelectedGroup.GroupName, SelectedGroup.Id, SelectedSubject.SubjectName, SelectedSubject.Id);

            Close();
            _ = MessageBox.Show("Subject '" + SelectedSubject.SubjectName + "' has been assigned to group - " + SelectedGroup.GroupName, "Success!");
        }
    }
}
