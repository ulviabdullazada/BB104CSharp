using AuthSystem.Models;

namespace AccessModifiers
{
    class AppUser : User
    {
        public void Login()
        {
            Age = 1238123;
        }
    }
}
