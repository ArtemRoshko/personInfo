// See https://aka.ms/new-console-template for more information
using System;
using System.Data;

class Person
{
    public int ID { get; set; }
    public string IdentificationCode { get; set; }
    public string PassportNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Gender { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Person(int id, string idCode, string passport, string firstName, string lastName, string phone, string email, string gender, DateTime dob)
    {
        ID = id;
        IdentificationCode = idCode;
        PassportNumber = passport;
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phone;
        Email = email;
        Gender = gender;
        DateOfBirth = dob;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Iдентифiкацiйний код: {IdentificationCode}");
        Console.WriteLine($"Номер паспорта: {PassportNumber}");
        Console.WriteLine($"Ім'я: {FirstName}");
        Console.WriteLine($"Прiзвище: {LastName}");
        Console.WriteLine($"Номер телефону: {PhoneNumber}");
        Console.WriteLine($"Електронна адреса: {Email}");
        Console.WriteLine($"Стать: {Gender}");
        Console.WriteLine($"Дата народження: {DateOfBirth.ToShortDateString()}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введiть данi для особи 1:");

        Console.Write("ID: ");
        int id1 = int.Parse(Console.ReadLine());

        Console.Write("Iдентифiкацiйний код: ");
        string idCode1 = Console.ReadLine();

        Console.Write("Номер паспорта: ");
        string passport1 = Console.ReadLine();

        Console.Write("Iм'я: ");
        string firstName1 = Console.ReadLine();

        Console.Write("Прiзвище: ");
        string lastName1 = Console.ReadLine();

        Console.Write("Номер телефону: ");
        string phone1 = Console.ReadLine();

        Console.Write("Електронна адреса: ");
        string email1 = Console.ReadLine();

        Console.Write("Стать: ");
        string gender1 = Console.ReadLine();

        Console.Write("Дата народження (рррр-мм-дд): ");
        DateTime dob1 = DateTime.Parse(Console.ReadLine());

        Person person1 = new Person(id1, idCode1, passport1, firstName1, lastName1, phone1, email1, gender1, dob1);
        Person person2 = new Person(2, "67890", "CD789012", "Iван", "Iванов", "0991234567", "ivan@email.com", "Чоловiк", new DateTime(1985, 8, 25));
        Console.Clear();
        Console.WriteLine("\nIнформація про особу 1:");
        person1.DisplayInfo();

        Console.WriteLine("\nIнформація про особу 2:");
        person2.DisplayInfo();
    }
}
