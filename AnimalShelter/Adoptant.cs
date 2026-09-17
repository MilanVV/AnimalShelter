namespace AnimalShelter;

public class Adoptant
{
    private string name;
    private string email;
    private string phoneNumber;

    public string getName()
    {
        return name;
    }
    public void setName(string name)
    {
        this.name = name;
    }

    public string getEmail()
    {
        return email;
    }
    public void setEmail(string email)
    {
        this.email = email;
    }

    public string getPhoneNumber()
    {
        return phoneNumber;
    }
    public void setPhoneNumber(string phoneNumber)
    {
        this.phoneNumber = phoneNumber;
    }

    public Adoptant(string name, string email, string phoneNumber)
    {
        this.name = name;
        this.email = email;
        this.phoneNumber = phoneNumber;
    }
}

