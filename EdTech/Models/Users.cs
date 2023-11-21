namespace EdTech.Models
{
    public class Users
    {
        public int id { get; set; }

        public string UserType { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string FullName { get; set; }

        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }

        public DateTime ModifiedAt { get; set; }

        public bool isDeleted { get; set; }



    }
}
