using System;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;

using Antras_Praktinias_Darbas.SQL;
using Antras_Praktinias_Darbas.Object;

namespace Antras_Praktinias_Darbas.Dialog.Create {
    public partial class Dialog_Grade : Window {
        SQL_Connection Conn;
        public User Student { get; set; }
        public Subject Subject { get; set; }
        public User Teacher { get; set; }
        public ListBox Grades { get; set; }

        public Dialog_Grade() {
            InitializeComponent();
            Conn = (SQL_Connection)Application.Current.Properties["sql"];
        }

        private void BTN_Cancel(object sender, RoutedEventArgs e) {
            TextBox_Score.Text = "";
            TextBox_GradeType.Text = "";
            Close();
        }

        private void BTN_CreateNewGrade(object sender, RoutedEventArgs e) {
            String Error = "";

            if (String.IsNullOrEmpty(TextBox_Score.Text))
                Error += "Please enter a score!";

            if (String.IsNullOrEmpty(TextBox_GradeType.Text))
                Error += "Please enter a grade type!";

            if (Error.Length != 0) {
                _ = MessageBox.Show(Error, "Exception!");
                return;
            }

            string StudentFullName = Student.FirstName + " " + Student.LastName;
            string TeacherFullName = Teacher.FirstName + " " + Teacher.LastName;
            double Score = Convert.ToDouble(TextBox_Score.Text);

            Conn.AddGrade(StudentFullName, Student.Id, Subject.SubjectName, Subject.Id, TeacherFullName, Teacher.Id, Score, TextBox_GradeType.Text);

            Close();

            _ = MessageBox.Show("Grade submitted.", "Success!");

            Grades.ItemsSource = Conn.GetStudentGradesFromSubject(Student.Id, Subject.Id);
        }
    }
}
