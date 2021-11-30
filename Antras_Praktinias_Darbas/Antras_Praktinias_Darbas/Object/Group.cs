namespace Antras_Praktinias_Darbas.Object {
    public class Group {
        public int Id { get; set; }
        public string GroupName { get; set; }

        public Group() { }
        public Group(int Value1, string Value2) {
            Id = Value1;
            GroupName = Value2;
        }
    }
}
