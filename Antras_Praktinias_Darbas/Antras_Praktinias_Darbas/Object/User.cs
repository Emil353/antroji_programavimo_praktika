using System;
using System.Collections.Generic;
using System.Text;

namespace Antras_Praktinias_Darbas.Object {
    public class User {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }

        public User() { }
        public User(int Value1, string Value2, string Value3, string Value4, string Value5, int Value6) {
            Id = Value1;
            FirstName = Value2;
            LastName = Value3;
            Username = Value4;
            Password = Value5;
            UserType = Value6;
        }
    }
}
