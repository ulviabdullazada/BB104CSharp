namespace Encapsulation.Models;
class User
{
    private string _username;
    private string _password;
    //property
    public int Age { get; init; }

    //private int _age;

    //public int Age
    //{
    //    get { return _age; }
    //    set { _age = value; }
    //}


    public string Password
    {
        get { return _password; }
        set
        {
            if (value.Length < 6)
            {
                Console.WriteLine("Shifre 6 simvoldan chox olmalidir");
                return;
            }
            _password = value;
        }
    }
    
    public User(string username)
    {
        SetUsername(username);
    }

    public string GetUsername()
    {
        return _username;
    }
    public void SetUsername(string value)
    {
        foreach (var sym in value)
        {
            if (!Char.IsLower(sym))
            {
                Console.WriteLine("Username sadece kicik herflerden ibaret olmalidir");
                return;
            }
        }
        _username = value;
    }
}
