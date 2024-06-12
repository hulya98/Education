namespace Education.DataAccess.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
