namespace DotnetProjekt.Components
{
    public class LoginService
    {
        private bool _loggedIn = false;
        private string _email = "";

        public event Action<bool> OnLoginStateChange;

        public bool IsLoggedIn()
        {
            return _loggedIn;
        }

        public void Login(string email)
        {
            _loggedIn = true;
            _email = email;
            OnLoginStateChange?.Invoke(_loggedIn);
        }

        public void Logout()
        {
            _loggedIn = false;
            _email = "";
            OnLoginStateChange?.Invoke(_loggedIn);
        } 

        public string GetEmail()
        {
            return _email;
        }
    }
}
