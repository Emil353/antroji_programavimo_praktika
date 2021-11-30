namespace Antras_Praktinias_Darbas.Object {
    public class Subject {
        public int Id { get; set; }
        public string SubjectName { get; set; }

        public Subject() { }
        public Subject(int Value1, string Value2) {
            Id = Value1;
            SubjectName = Value2;
        }
    }
}
