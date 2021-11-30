using System;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;

using Antras_Praktinias_Darbas.SQL;
using Antras_Praktinias_Darbas.Object;

namespace Antras_Praktinias_Darbas.Dialog {
    public partial class Dialog_Subject : Window {
        SQL_Connection Conn;

        public Dialog_Subject() {
            InitializeComponent();
            Conn = (SQL_Connection)Application.Current.Properties["sql"];
        }

        private void BTN_Cancel(object sender, RoutedEventArgs e) {
            TextBox_SubjectName.Text = "";
            Close();
        }

        private void BTN_CreateNewSubject(object sender, RoutedEventArgs e) {
            String Error = "";
            Boolean Check = false;

            if (String.IsNullOrEmpty(TextBox_SubjectName.Text))
                Error += "Please enter a username!";

            if (Error.Length != 0) {
                _ = MessageBox.Show(Error, "Exception!");
                return;
            }

            List<Subject> SubjectList = Conn.GetSubjects();

            foreach (Subject target in (List<Subject>)Application.Current.Properties["subjects"]) {
                if (TextBox_SubjectName.Text.Equals(target.SubjectName))
                    Check = true;
            }

            if (Check == true) {
                _ = MessageBox.Show("A user with this first and last name already exist.", "Cannot create a new student!");
                return;
            }

            Conn.AddSubject(TextBox_SubjectName.Text);

            Close();

            _ = MessageBox.Show("New subject has been created.", "Success!");
            Application.Current.Properties["subjects"] = Conn.GetSubjects();

            ListBox Box = (ListBox)Application.Current.Properties["ListBox_Subjects"];
            Box.ItemsSource = Conn.GetSubjects();
        }
    }
}
