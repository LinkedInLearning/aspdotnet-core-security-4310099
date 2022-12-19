namespace SecurityApp.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        //Id of the User (Manager) who hired this user
        public int HiringManagerId { get; set; }
    }
}
