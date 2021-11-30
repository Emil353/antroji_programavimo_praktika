using System.Windows;
using System.Collections.Generic;

using Antras_Praktinias_Darbas.SQL;
using Antras_Praktinias_Darbas.Pages;
using Antras_Praktinias_Darbas.Object;

namespace Antras_Praktinias_Darbas {
    public partial class MainWindow : Window {
        User CurrentUser;
        List<User> UserList;
        List<Group> GroupList;
        List<Subject> SubjectList;

        SQL_Connection Conn;

        public MainWindow() {
            InitializeComponent();
            InitializeFrame();
            ConnectToDatabase();
            SetGlobalProperties();
        }

        public void InitializeFrame() {
            _NavigationFrame.Navigate(new Page_Login());
        }

        public void ConnectToDatabase() {
            Conn = new SQL_Connection("localhost", "academic_system", "root", "");
            CurrentUser = null;
            UserList = new List<User>();
            GroupList = new List<Group>();
            SubjectList = new List<Subject>();

            UserList = Conn.GetUsers();
            GroupList = Conn.GetGroups();
            SubjectList = Conn.GetSubjects();
        }

        public void SetGlobalProperties() {
            Application.Current.Properties["sql"] = Conn;
            Application.Current.Properties["users"] = UserList;
            Application.Current.Properties["groups"] = GroupList;
            Application.Current.Properties["subjects"] = SubjectList;
            Application.Current.Properties["current"] = CurrentUser;
        }
    }
}
