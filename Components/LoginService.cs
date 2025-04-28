namespace DotnetProjekt.Components
{
    public class LoginService
    {
        private bool _loggedIn = false;
        private string _email = "";
        private float _romanianGrade = 0;
        private float _mandatoryGrade = 0;
        private float _chosenGrade = 0;
        private float _nativeGrade = 0;

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
            _romanianGrade = 0;
            _mandatoryGrade = 0;
            _chosenGrade = 0;
            _nativeGrade = 0;
            OnLoginStateChange?.Invoke(_loggedIn);
        } 

        public string GetEmail()
        {
            return _email;
        }

        public void SetGrades(float romanianGrade, float mandatoryGrade, float chosenGrade, float nativeGrade)
        {
            _romanianGrade = romanianGrade;
            _mandatoryGrade = mandatoryGrade;
            _chosenGrade = chosenGrade;
            _nativeGrade = nativeGrade;
        }

        public float GetRomanianGrade() => _romanianGrade;
        public float GetMandatoryGrade() => _mandatoryGrade;
        public float GetChosenGrade() => _chosenGrade;
        public float GetNativeGrade() => _nativeGrade;
    }
}
