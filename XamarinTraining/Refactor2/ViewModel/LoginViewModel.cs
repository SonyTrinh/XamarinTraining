using GalaSoft.MvvmLight.Ioc;
using Refactor2.Manager;
using Refactor2.Service;
using System;
using System.Threading.Tasks;

namespace Refactor2.ViewModel
{
    public class LoginViewModel
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public readonly UserManager _userManager;

        public LoginViewModel(UserManager userManager)
        {
            _userManager = userManager;
        }

        public async Task<bool> Login()
        {
            if(!string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Password))
            {

                var isSuccess = await _userManager.Login(Email, Password);
                if (isSuccess)
                {
                    Console.WriteLine($"{_userManager.CurrentUser.DisplayName} has signed in.");
                    _userManager.SaveToken();
                }
                else
                {
                    Console.WriteLine("User not found.");
                }
                return isSuccess;
            }
            else
            {
                Console.WriteLine("Email and password are required.");
            }
            return false;
        }

        private void SaveToken(string token)
        {
            var serviceManager = SimpleIoc.Default.GetInstance<IServiceManager>();
            serviceManager.SaveToken(token);
        }
    }
}
