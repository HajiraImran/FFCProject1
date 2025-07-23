namespace FFCProject.Services
{
    public class UserStateService
    {
        public string Email { get; private set; }
        public string Username { get; private set; } // <-- use this instead

        public void SetUser(string email, string username)
        {
            Email = email;
            Username = username;
        }

        public void Clear()
        {
            Email = null;
            Username = null;
        }
    }
}
