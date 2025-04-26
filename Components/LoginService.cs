namespace DotnetProjekt.Components
{
    public class LoginService
    {
        private bool _loggedIn = false;

        public event Action<bool> OnLoginStateChange;

        public bool IsLoggedIn()
        {
            return _loggedIn;
        }

        public void Login()
        {
            _loggedIn = true;
            OnLoginStateChange?.Invoke(_loggedIn);
        }

        public void Logout()
        {
            _loggedIn = false;
            OnLoginStateChange?.Invoke(_loggedIn);
        } 
    }
}
