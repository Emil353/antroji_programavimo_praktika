using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;

using Antras_Praktinias_Darbas.Object;

namespace Antras_Praktinias_Darbas.Pages {
    public partial class Page_Login : Page {
        public Page_Login() {
            InitializeComponent();
        }

        private void BTN_Login(object sender, RoutedEventArgs e) {
            foreach (User Target in (List<User>)Application.Current.Properties["users"]) {
                if(TextBox_Username.Text.Equals(Target.Username) && TextBox_Password.Text.Equals(Target.Password)) {
                    TextBox_Username.Text = "";
                    TextBox_Password.Text = "";

                    switch (Target.UserType) {
                        case 1:
                            Page_Admin PageAdmin = new Page_Admin();
                            NavigationService.LoadCompleted += PageAdmin.NavigationService_LoadCompleted;
                            _ = NavigationService.Navigate(PageAdmin, Target);
                            break;
                        case 2:
                            Page_Teacher PageTeacher = new Page_Teacher();
                            NavigationService.LoadCompleted += PageTeacher.NavigationService_LoadCompleted;
                            _ = NavigationService.Navigate(PageTeacher, Target);
                            break;
                        case 3:
                            Page_Student PageStudent = new Page_Student();
                            NavigationService.LoadCompleted += PageStudent.NavigationService_LoadCompleted;
                            _ = NavigationService.Navigate(PageStudent, Target);
                            break;
                    }
                    return;
                }
            }

            _ = MessageBox.Show("Wrong username or password!", "Cannot connect!");
        }
    }
}
