namespace StudentsCoursCesi.Models.Entities
{
    public class Students
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
