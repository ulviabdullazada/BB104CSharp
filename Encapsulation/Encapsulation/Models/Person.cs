namespace Encapsulation.Models;
class Person
{
    //sadece yarandigi class daxilinde elchatandir
    private readonly string _finCode; //initalize
    public string Name = "xxx";
    public string Surname = "xxx";
    //yarandigi class ve derived classda elchatandir
    protected string EyeColor = "asdasd";
    public Person(string finCode)
    {
        _finCode = finCode;
    }
    public Person()
    {
        _finCode = Guid.NewGuid().ToString().Substring(0,7);
    }
    public string GetInfo()
    {
        return $"{_finCode} - {Name} {Surname}";
    }
}
