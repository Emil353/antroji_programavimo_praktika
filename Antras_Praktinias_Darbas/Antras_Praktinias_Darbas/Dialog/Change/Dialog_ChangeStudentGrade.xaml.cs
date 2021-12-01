using System;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;

using Antras_Praktinias_Darbas.SQL;
using Antras_Praktinias_Darbas.Object;

namespace Antras_Praktinias_Darbas.Dialog.Change {
    public partial class Dialog_ChangeStudentGrade : Window {
        SQL_Connection Conn;
        public User Student { get; set; }
        public Subject Subject { get; set; }
        public Grade CurrentGrade { get; set; }
        public ListBox Grades { get; set; }


        public Dialog_ChangeStudentGrade() {
            InitializeComponent();
            Conn = (SQL_Connection)Application.Current.Properties["sql"];
        }

        private void BTN_Cancel(object sender, RoutedEventArgs e) {
            TextBox_UpdatedScore.Text = "";
            Close();
        }
        private void BTN_ChangeGrade(object sender, RoutedEventArgs e) {
            String Error = "";

            if (String.IsNullOrEmpty(TextBox_UpdatedScore.Text))
                Error += "Please enter a score!";

            if (Error.Length != 0) {
                _ = MessageBox.Show(Error, "Exception!");
                return;
            }

            double Score = Convert.ToDouble(TextBox_UpdatedScore.Text);

            Conn.ChangeGrade(CurrentGrade.Id, Score);

            Close();

            _ = MessageBox.Show("Grade has been changed.", "Success!");

            Grades.ItemsSource = Conn.GetStudentGradesFromSubject(Student.Id, Subject.Id);
        }
    }
}
