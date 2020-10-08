namespace staff_qualification_Forms
{
    public class StaffDb
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public PositionsDb Position { get; set; }
    }
}
