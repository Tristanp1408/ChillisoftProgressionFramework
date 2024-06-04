using PDFfile;

namespace PDFfileTests;

public class UserBuilder
{
    public string _name = "Tristan";
    public string _surname = "Perumalsamy";
    public string _emailAddress = "tristan.perumalsamy@chillisoft.co.za";

    public static UserBuilder Create()
    {
        return new UserBuilder();
    }

    public UserBuilder withName(string name)
    {
        _name = name;
        return this;
    }

    public UserBuilder withSurname(string surname)
    {
        _surname = surname;
        return this;
    }

    public UserBuilder withEmailAddress(string emailAddress)
    {
        _emailAddress = emailAddress;
        return this;
    }

    public User Build()
    {
        return new User(_name, _surname, _emailAddress);
    }
}