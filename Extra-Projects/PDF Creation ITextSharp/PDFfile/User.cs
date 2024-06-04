namespace PDFfile;

public class User
{
    public string Name { get; set;  }
    public string Surname { get; set; }
    public string EmailAddress { get; set; }

    public User(string name,string surname, string emailAddress)
    {
        Name = name;
        Surname = surname;
        EmailAddress = emailAddress;
    }
}