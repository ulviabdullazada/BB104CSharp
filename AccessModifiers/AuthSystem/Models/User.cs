namespace AuthSystem.Models
{
    public class User : Person
    {
        //private - sadece oz class-i daxilinde gorsenir. Class memberlar ucun defaultdur.
        //private protected - oz assemblysi daxilinde protected xusiyyeti dasiyir. Diger assembly-de gorsenmir.
        //protected - oz class-i ve onun inherit etdiyi class-larda gorsenir
        //internal - sadece oz assembly-si daxilinde her yerde gorsenir. Classla ucun defaultdur.
        //protected internal - oz assembly-si daxilinde her yerde gorsenir, diger assembly-da miras alinan zaman gorsenir
        //public - her yerde gorsenir
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public void Register()
        {
            Age = 123;
        }
    }
}
