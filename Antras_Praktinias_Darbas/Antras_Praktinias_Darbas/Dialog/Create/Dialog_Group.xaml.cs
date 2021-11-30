using System;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;

using Antras_Praktinias_Darbas.SQL;
using Antras_Praktinias_Darbas.Object;

namespace Antras_Praktinias_Darbas.Dialog {
    public partial class Dialog_Group : Window {
        SQL_Connection Conn;

        public Dialog_Group() {
            InitializeComponent();
            Conn = (SQL_Connection)Application.Current.Properties["sql"];
        }

        private void BTN_Cancel(object sender, RoutedEventArgs e) {
            TextBox_GroupName.Text = "";
            Close();
        }

        private void BTN_CreateNewGroup(object sender, RoutedEventArgs e) {
            String Error = "";
            Boolean Check = false;

            if (String.IsNullOrEmpty(TextBox_GroupName.Text))
                Error += "Please enter a username!";

            if (Error.Length != 0) {
                _ = MessageBox.Show(Error, "Exception!");
                return;
            }

            foreach (Group target in (List<Group>)Application.Current.Properties["groups"]) {
                if (TextBox_GroupName.Text.Equals(target.GroupName))
                    Check = true;
            }

            if (Check == true) {
                _ = MessageBox.Show("A user with this first and last name already exist.", "Cannot create a new student!");
                return;
            }

            Conn.AddGroup(TextBox_GroupName.Text);

            Close();

            _ = MessageBox.Show("New group has been created.", "Success!");
            Application.Current.Properties["groups"] = Conn.GetGroups();

            ListBox Box = (ListBox)Application.Current.Properties["ListBox_Group"];
            Box.ItemsSource = Conn.GetGroups();
        }
    }
}
