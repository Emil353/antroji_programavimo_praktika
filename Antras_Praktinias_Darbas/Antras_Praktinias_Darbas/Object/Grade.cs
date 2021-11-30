using System;
using System.Collections.Generic;
using System.Text;

namespace Antras_Praktinias_Darbas.Object {
    public class Grade {
        public int Id { get; set; }
        public string StudentFullName { get; set; }
        public int StudentId { get; set; }
        public string SubjectName { get; set; }
        public int SubjectId { get; set; }
        public string TeacherFullName { get; set; }
        public int TeacherId { get; set; }
        public double Score { get; set; }
        public string GradeType { get; set; }

        public Grade(int Value1, string Value2, int Value3, string Value4, int Value5, string Value6, int Value7, double Value8, string Value9) {
            Id = Value1;

            StudentFullName = Value2;
            StudentId = Value3;

            SubjectName = Value4;
            SubjectId = Value5;

            TeacherFullName = Value6;
            TeacherId = Value7;

            Score = Value8;

            GradeType = Value9;
        }
    }
}
