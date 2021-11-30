using System;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;

using Antras_Praktinias_Darbas.SQL;
using Antras_Praktinias_Darbas.Object;

namespace Antras_Praktinias_Darbas.Dialog {
    public partial class Dialog_Teacher : Window {
        SQL_Connection Conn;

        public Dialog_Teacher() {
            InitializeComponent();
            Conn = (SQL_Connection)Application.Current.Properties["sql"];
        }

        private void BTN_Cancel(object sender, RoutedEventArgs e) {
            TextBox_FirstName.Text = "";
            TextBox_LastName.Text = "";

            Close();
        }

        private void BTN_CreateNewUser(object sender, RoutedEventArgs e) {
            String Error = "";
            Boolean Check = false;

            if (String.IsNullOrEmpty(TextBox_FirstName.Text))
                Error += "Please enter a username!" + "\r\n";
            if (String.IsNullOrEmpty(TextBox_LastName.Text))
                Error += "Please enter a password!" + "\r\n";

            if (Error.Length != 0) {
                _ = MessageBox.Show(Error, "Exception!");
                return;
            }

            List<User> UserList = Conn.GetUsers();

            foreach (User target in (List<User>)Application.Current.Properties["users"]) {
                if (TextBox_FirstName.Text.Equals(target.FirstName) && TextBox_LastName.Text.Equals(target.LastName))
                    Check = true;
            }

            if (Check == true) {
                _ = MessageBox.Show("A user with this first and last name already exist.", "Cannot create a new student!");
                return;
            }

            Conn.AddUser(TextBox_FirstName.Text, TextBox_LastName.Text, TextBox_FirstName.Text.ToLower(), TextBox_LastName.Text.ToLower(), 2);

            Close();

            _ = MessageBox.Show("New teacher has been created.", "Success!");
            Application.Current.Properties["users"] = Conn.GetUsers();

            ListBox Box = (ListBox)Application.Current.Properties["ListBox_Teacher"];
            Box.ItemsSource = Conn.GetTeachers();
        }
    }
}
