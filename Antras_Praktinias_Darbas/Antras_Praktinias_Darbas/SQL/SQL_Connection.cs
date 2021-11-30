using System;
using System.Windows;
using System.Collections.Generic;

using MySql.Data.MySqlClient;

using Antras_Praktinias_Darbas.Object;

namespace Antras_Praktinias_Darbas.SQL {
    class SQL_Connection {
        private readonly MySqlConnection Conn;

        // Constructor
        public SQL_Connection(string server, string database, string user, string password) {
            Conn = new MySqlConnection("SERVER=" + server + "; DATABASE=" + database + "; UID=" + user + "; PASSWORD=" + password);
        }

        // Open / Close Connection Functions
        private bool OpenConnection() {
            try {
                Conn.Open();
                return true;
            } catch (MySqlException ex) {
                switch (ex.Number) {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }

                return false;
            }
        }
        private bool CloseConnection() {
            try {
                Conn.Close();
                return true;
            } catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // User Functions
        public User GetUser(int UserId) {
            User Target = new User();

            string Query = "SELECT * FROM user WHERE id = @Value1";
            if (OpenConnection()) {
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                CMD.Parameters.AddWithValue("@Value1", UserId);
                MySqlDataReader DatabaseReader = CMD.ExecuteReader();

                while (DatabaseReader.Read()) {
                    int Id = (int)DatabaseReader["id"];
                    string FirstName = (string)DatabaseReader["first_name"];
                    string LastName = (string)DatabaseReader["last_name"];
                    string Username = (string)DatabaseReader["username"];
                    string Password = (string)DatabaseReader["password"];
                    int UserType = (int)DatabaseReader["user_type"];
                    Target = new User(Id, FirstName, LastName, Username, Password, UserType);
                }
                DatabaseReader.Close();
                _ = CloseConnection();
            }

            return Target;
        }
        public List<User> GetUsers() {
            List<User> List = new List<User>();
            string Query = "SELECT * FROM user";
            if(OpenConnection()) {
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                MySqlDataReader DatabaseReader = CMD.ExecuteReader();

                while(DatabaseReader.Read()) {
                    int Id = (int)DatabaseReader["id"];
                    string FirstName = (string)DatabaseReader["first_name"];
                    string LastName = (string)DatabaseReader["last_name"];
                    string Username = (string)DatabaseReader["username"];
                    string Password = (string)DatabaseReader["password"];
                    int UserType = (int)DatabaseReader["user_type"];

                    List.Add(new User(Id, FirstName, LastName, Username, Password, UserType));
                }
                DatabaseReader.Close();
                _ = CloseConnection();
            }
            return List;
        }
        public List<User> GetTeachers() {
            List<User> List = new List<User>();
            string Query = "SELECT * FROM user WHERE user_type = 2";
            if (OpenConnection()) {
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                MySqlDataReader DatabaseReader = CMD.ExecuteReader();

                while (DatabaseReader.Read()) {
                    int Id = (int)DatabaseReader["id"];
                    string FirstName = (string)DatabaseReader["first_name"];
                    string LastName = (string)DatabaseReader["last_name"];
                    string Username = (string)DatabaseReader["username"];
                    string Password = (string)DatabaseReader["password"];
                    int UserType = (int)DatabaseReader["user_type"];

                    List.Add(new User(Id, FirstName, LastName, Username, Password, UserType));
                }
                DatabaseReader.Close();
                _ = CloseConnection();
            }
            return List;
        }
        public List<User> GetStudents() {
            List<User> List = new List<User>();
            string Query = "SELECT * FROM user WHERE user_type = 3";
            if (OpenConnection()) {
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                MySqlDataReader DatabaseReader = CMD.ExecuteReader();

                while (DatabaseReader.Read()) {
                    int Id = (int)DatabaseReader["id"];
                    string FirstName = (string)DatabaseReader["first_name"];
                    string LastName = (string)DatabaseReader["last_name"];
                    string Username = (string)DatabaseReader["username"];
                    string Password = (string)DatabaseReader["password"];
                    int UserType = (int)DatabaseReader["user_type"];

                    List.Add(new User(Id, FirstName, LastName, Username, Password, UserType));
                }
                DatabaseReader.Close();
                _ = CloseConnection();
            }
            return List;
        }
        public void AddUser(string FirstName, string LastName, string Username, string Password, int UserType) {
            string Query = "INSERT INTO user(first_name, last_name, username, password, user_type) VALUES(@Value1, @Value2, @Value3, @Value4, @Value5)";
            if(OpenConnection()) {
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                CMD.Parameters.AddWithValue("@Value1", FirstName);
                CMD.Parameters.AddWithValue("@Value2", LastName);
                CMD.Parameters.AddWithValue("@Value3", Username);
                CMD.Parameters.AddWithValue("@Value4", Password);
                CMD.Parameters.AddWithValue("@Value5", UserType);
                try {
                    CMD.ExecuteNonQuery();
                } catch (MySqlException e) {
                    Console.WriteLine(e.ToString());
                } finally {
                    _ = CloseConnection();
                }
            }
        }
        public void DeleteUser(int Id) {
            string Query = "DELETE FROM user WHERE id = @Value1";
            if(OpenConnection()) {
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                CMD.Parameters.AddWithValue("@Value1", Id);
                try {
                    CMD.ExecuteNonQuery();
                } catch (MySqlException e) {
                    Console.WriteLine(e.ToString());
                } finally {
                    _ = CloseConnection();
                }
            }
        }

        // Group Functions
        public List<Group> GetGroups() {
            List<Group> List = new List<Group>();
            string Query = "SELECT * FROM groups";
            if(OpenConnection()) {
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                MySqlDataReader DatabaseReader = CMD.ExecuteReader();

                while(DatabaseReader.Read()) {
                    int Id = (int)DatabaseReader["id"];
                    string GroupName = (string)DatabaseReader["group_name"];

                    List.Add(new Group(Id, GroupName));
                }
                DatabaseReader.Close();
                _ = CloseConnection();
            }
            return List;
        }
        public void AddGroup(string GroupName) {
            string Query = "INSERT INTO groups(group_name) VALUES(@Value1)";
            if (OpenConnection()) {
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                CMD.Parameters.AddWithValue("@Value1", GroupName);
                try {
                    CMD.ExecuteNonQuery();
                } catch (MySqlException e) {
                    Console.WriteLine(e.ToString());
                } finally {
                    _ = CloseConnection();
                }
            }
        }
        public void DeleteGroup(int Id) {
            string Query = "DELETE FROM groups WHERE id = @Value1";
            if (OpenConnection()) {
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                CMD.Parameters.AddWithValue("@Value1", Id);
                try {
                    CMD.ExecuteNonQuery();
                } catch (MySqlException e) {
                    Console.WriteLine(e.ToString());
                } finally {
                    _ = CloseConnection();
                }
            }
        }
        public Group GetStudentGroup(int StudentId) {
            Group StudentGroup = new Group();
            string Query = "SELECT g.id, g.group_name FROM groups AS g, user AS u, student_to_group AS stg WHERE stg.student_id = u.id AND stg.group_id = g.id AND u.id = @Value1";
            
            if (OpenConnection()) {
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                CMD.Parameters.AddWithValue("@Value1", StudentId);
                MySqlDataReader DatabaseReader = CMD.ExecuteReader();

                while (DatabaseReader.Read()) {
                    int Id = (int)DatabaseReader[0];
                    string GroupName = (string)DatabaseReader[1];

                    StudentGroup.Id = Id;
                    StudentGroup.GroupName = GroupName;
                }
                DatabaseReader.Close();
                _ = CloseConnection();
            }

            return StudentGroup;
        }

        // Subject Functions
        public List<Subject> GetSubjects() {
            List<Subject> List = new List<Subject>();
            string Query = "SELECT * FROM subject";
            if (OpenConnection()) {
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                MySqlDataReader DatabaseReader = CMD.ExecuteReader();

                while (DatabaseReader.Read()) {
                    int Id = (int)DatabaseReader["id"];
                    string SubjectName = (string)DatabaseReader["subject_name"];
                    List.Add(new Subject(Id, SubjectName));
                }
                DatabaseReader.Close();
                _ = CloseConnection();
            }
            return List;
        }
        public List<Subject> GetGroupSubjects(int GroupId) {
            List<Subject> List = new List<Subject>();
            string Query = "SELECT stg.subject_id, stg.subject_name FROM subject_to_group AS stg WHERE stg.group_id = @Value1";
            if (OpenConnection()) {
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                CMD.Parameters.AddWithValue("@Value1", GroupId);
                MySqlDataReader DatabaseReader = CMD.ExecuteReader();

                while (DatabaseReader.Read()) {
                    int Id = (int)DatabaseReader[0];
                    string SubjectName = (string)DatabaseReader[1];
                    List.Add(new Subject(Id, SubjectName));
                }
                DatabaseReader.Close();
                _ = CloseConnection();
            }
            return List;
        }
        public void AddSubject(string SubjectName) {
            string Query = "INSERT INTO subject(subject_name) VALUES(@Value1)";
            if (OpenConnection()) {
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                CMD.Parameters.AddWithValue("@Value1", SubjectName);
                try {
                    CMD.ExecuteNonQuery();
                } catch (MySqlException e) {
                    Console.WriteLine(e.ToString());
                } finally {
                    _ = CloseConnection();
                }
            }
        }
        public void DeleteSubject(int Id) {
            string Query = "DELETE FROM subject WHERE id = @Value1";
            if (OpenConnection()) {
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                CMD.Parameters.AddWithValue("@Value1", Id);
                try {
                    CMD.ExecuteNonQuery();
                } catch (MySqlException e) {
                    Console.WriteLine(e.ToString());
                } finally {
                    _ = CloseConnection();
                }
            }
        }

        // Grade Functions
        public void AddGrade(string StudentName, int StudentId, string SubjectName, int SubjectId, string TeacherName, int TeacherId, double Score, string GradeType) {
            string Query = "INSERT INTO grade(student_name, student_id, subject_name, subject_id, teacher_name, teacher_id, score, grade_type) VALUES(@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7, @Value8)";
            if (OpenConnection()) {
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                CMD.Parameters.AddWithValue("@Value1", StudentName);
                CMD.Parameters.AddWithValue("@Value2", StudentId);
                CMD.Parameters.AddWithValue("@Value3", SubjectName);
                CMD.Parameters.AddWithValue("@Value4", SubjectId);
                CMD.Parameters.AddWithValue("@Value5", TeacherName);
                CMD.Parameters.AddWithValue("@Value6", TeacherId);
                CMD.Parameters.AddWithValue("@Value7", Score);
                CMD.Parameters.AddWithValue("@Value8", GradeType);
                try {
                    CMD.ExecuteNonQuery();
                } catch (MySqlException e) {
                    Console.WriteLine(e.ToString());
                } finally {
                    _ = CloseConnection();
                }
            }
        }
        public void RemoveGrade(int Id) {
            string Query = "DELETE FROM grade WHERE id = @Value1";
            if (OpenConnection()) {
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                CMD.Parameters.AddWithValue("@Value1", Id);
                try {
                    CMD.ExecuteNonQuery();
                } catch (MySqlException e) {
                    Console.WriteLine(e.ToString());
                } finally {
                    _ = CloseConnection();
                }
            }
        }
        public List<Grade> GetStudentGradesFromSubject(int StudentId, int SubjectId) {
            List<Grade> List = new List<Grade>();
            string Query = "SELECT * FROM grade WHERE student_id = @Value1 AND subject_id = @Value2";
            if (OpenConnection()) {
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                CMD.Parameters.AddWithValue("@Value1", StudentId);
                CMD.Parameters.AddWithValue("@Value2", SubjectId);
                MySqlDataReader DatabaseReader = CMD.ExecuteReader();

                while (DatabaseReader.Read()) {
                    int Id = (int)DatabaseReader["id"];

                    string StudentName = (string)DatabaseReader["student_name"];
                    int IdStudent = (int)DatabaseReader["student_id"];

                    string SubjectName = (string)DatabaseReader["subject_name"];
                    int IdSubject = (int)DatabaseReader["subject_id"];

                    string TeacherName = (string)DatabaseReader["teacher_name"];
                    int IdTeacher = (int)DatabaseReader["teacher_id"];

                    double Score = (double)DatabaseReader["score"];

                    string GradeType = (string)DatabaseReader["grade_type"];

                    List.Add(new Grade(Id, StudentName, IdStudent, SubjectName, IdSubject, TeacherName, IdTeacher, Score, GradeType));
                }
                DatabaseReader.Close();
                _ = CloseConnection();
            }

            return List;
        }


        // Assign Student To Group Functions
        public void AssignStudentToGroup(string StudentFullName, int StudentId, string GroupName, int GroupId) {
            string Query = "INSERT INTO student_to_group(student_name, student_id, group_name, group_id) VALUES(@Value1, @Value2, @Value3, @Value4)";
            if (OpenConnection()) {
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                CMD.Parameters.AddWithValue("@Value1", StudentFullName);
                CMD.Parameters.AddWithValue("@Value2", StudentId);
                CMD.Parameters.AddWithValue("@Value3", GroupName);
                CMD.Parameters.AddWithValue("@Value4", GroupId);
                try {
                    CMD.ExecuteNonQuery();
                } catch (MySqlException e) {
                    Console.WriteLine(e.ToString());
                } finally {
                    _ = CloseConnection();
                }
            }
        }
        public void RemoveStudentFromGroup(int StudentId) {
            string Query = "DELETE FROM student_to_group WHERE student_id = @Value1";
            if (OpenConnection()) {
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                CMD.Parameters.AddWithValue("@Value1", StudentId);
                try {
                    CMD.ExecuteNonQuery();
                } catch (MySqlException e) {
                    Console.WriteLine(e.ToString());
                } finally {
                    _ = CloseConnection();
                }
            }
        }
        public int CountStudentInGroup(int StudentId, int GroupId) {
            Int32 Count = 0;

            string Query = "SELECT COUNT(*) FROM student_to_group WHERE student_id = @Value1 AND group_id = @Value2";
            if (OpenConnection()) {
                MySqlCommand cmd = new MySqlCommand(Query, Conn);
                cmd.Parameters.AddWithValue("@Value1", StudentId);
                cmd.Parameters.AddWithValue("@Value2", GroupId);
                Count = Convert.ToInt32(cmd.ExecuteScalar());
                _ = CloseConnection();
            }

            return Count;
        }

        // Assign Subject To Group Functions
        public void AssignSubjectToGroup(string GroupName, int GroupId, string SubjectName, int SubjectId) {
            string Query = "INSERT INTO subject_to_group(group_name, group_id, subject_name, subject_id) VALUES(@Value1, @Value2, @Value3, @Value4)";
            if (OpenConnection()) {
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                CMD.Parameters.AddWithValue("@Value1", GroupName);
                CMD.Parameters.AddWithValue("@Value2", GroupId);
                CMD.Parameters.AddWithValue("@Value3", SubjectName);
                CMD.Parameters.AddWithValue("@Value4", SubjectId);
                try {
                    CMD.ExecuteNonQuery();
                } catch (MySqlException e) {
                    Console.WriteLine(e.ToString());
                } finally {
                    _ = CloseConnection();
                }
            }
        }
        public void RemoveSubjectFromGroup(int GroupId, int Subjectid) {
            string Query = "DELETE FROM subject_to_group WHERE group_id = @Value1 AND subject_id = @Value2";
            if (OpenConnection()) {
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                CMD.Parameters.AddWithValue("@Value1", GroupId);
                CMD.Parameters.AddWithValue("@Value2", Subjectid);
                try {
                    CMD.ExecuteNonQuery();
                } catch (MySqlException e) {
                    Console.WriteLine(e.ToString());
                } finally {
                    _ = CloseConnection();
                }
            }
        }
        public int CountSubjectInGroup(int GroupId, int SubjectId) {
            Int32 Count = 0;

            string Query = "SELECT COUNT(*) FROM subject_to_group WHERE group_id = @Value1 AND subject_id = @Value2";
            if (OpenConnection()) {
                MySqlCommand cmd = new MySqlCommand(Query, Conn);
                cmd.Parameters.AddWithValue("@Value1", GroupId);
                cmd.Parameters.AddWithValue("@Value2", SubjectId);
                Count = Convert.ToInt32(cmd.ExecuteScalar());
                _ = CloseConnection();
            }

            return Count;
        }

        // Assign Teacher To Subject Functions
        public void AssignTeacherToSubject(string TeacherFullName, int TeacherId, string SubjectName, int SubjectId) {
            string Query = "INSERT INTO teacher_to_subject(teacher_full_name, teacher_id, subject_name, subject_id) VALUES(@Value1, @Value2, @Value3, @Value4)";
            if (OpenConnection()) {
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                CMD.Parameters.AddWithValue("@Value1", TeacherFullName);
                CMD.Parameters.AddWithValue("@Value2", TeacherId);
                CMD.Parameters.AddWithValue("@Value3", SubjectName);
                CMD.Parameters.AddWithValue("@Value4", SubjectId);
                try {
                    CMD.ExecuteNonQuery();
                } catch (MySqlException e) {
                    Console.WriteLine(e.ToString());
                } finally {
                    _ = CloseConnection();
                }
            }
        }
        public int CountTeacherInSubject(int TeacherId, int SubjectId) {
            Int32 Count = 0;

            string Query = "SELECT COUNT(*) FROM teacher_to_subject WHERE teacher_id = @Value1 AND subject_id = @Value2";
            if (OpenConnection()) {
                MySqlCommand cmd = new MySqlCommand(Query, Conn);
                cmd.Parameters.AddWithValue("@Value1", TeacherId);
                cmd.Parameters.AddWithValue("@Value2", SubjectId);
                Count = Convert.ToInt32(cmd.ExecuteScalar());
                _ = CloseConnection();
            }

            return Count;
        }

        // Get Subjects Assigned To Teacher
        public List<Subject> GetTeacherSubjects(int TeacherId) {
            List<Subject> List = new List<Subject>();
            string Query = "SELECT s.id, s.subject_name FROM subject AS s, teacher_to_subject AS tts WHERE tts.teacher_id = @Value1 AND tts.subject_id = s.id";

            if (OpenConnection()) {
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                CMD.Parameters.AddWithValue("@Value1", TeacherId);
                MySqlDataReader DatabaseReader = CMD.ExecuteReader();

                while (DatabaseReader.Read()) {
                    int Id = (int)DatabaseReader[0];
                    string SubjectName = (string)DatabaseReader[1];
                    List.Add(new Subject(Id, SubjectName));
                }
                DatabaseReader.Close();
                _ = CloseConnection();
            }

            return List;
        }
        // Get Groups That Contain Subject
        public List<Group> GetGroupsWithSubject(int SubjectId) {
            List<Group> List = new List<Group>();
            string Query = "SELECT g.id, g.group_name FROM groups AS g, subject_to_group AS stg WHERE stg.group_id = g.id AND stg.subject_id = @Value1";

            if (OpenConnection()) {
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                CMD.Parameters.AddWithValue("@Value1", SubjectId);
                MySqlDataReader DataReader = CMD.ExecuteReader();

                while (DataReader.Read()) {
                    int Id = (int)DataReader[0];
                    string GroupName = (string)DataReader[1];

                    List.Add(new Group(Id, GroupName));
                }

                DataReader.Close();
                _ = CloseConnection();
            }



            return List;
        }
        // Get Students In The Given Group
        public List<User> GetStudentsInGroup(int GroupId) {
            List<User> List = new List<User>();
            string Query = "SELECT u.id, u.first_name, u.last_name, u.username, u.password, u.user_type FROM user AS u, student_to_group AS stg WHERE stg.student_id = u.id AND stg.group_id = @Value1";

            if (OpenConnection()) {
                MySqlCommand CMD = new MySqlCommand(Query, Conn);
                CMD.Parameters.AddWithValue("@Value1", GroupId);
                MySqlDataReader DatabaseReader = CMD.ExecuteReader();

                while (DatabaseReader.Read()) {
                    int Id = (int)DatabaseReader[0];
                    string FirstName = (string)DatabaseReader[1];
                    string LastName = (string)DatabaseReader[2];
                    string Username = (string)DatabaseReader[3];
                    string Password = (string)DatabaseReader[4];
                    int UserType = (int)DatabaseReader[5];

                    List.Add(new User(Id, FirstName, LastName, Username, Password, UserType));
                }
                DatabaseReader.Close();
                _ = CloseConnection();
            }

            return List;
        }





    }
}
