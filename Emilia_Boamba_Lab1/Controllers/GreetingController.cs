using Microsoft.AspNetCore.Mvc;

namespace Emilia_Boamba_Lab1.Controllers;

public class GreetingController : Controller
{
    // GET
    public string Index()
    {
        return "Welcome";
    }

    public string GetGreeting()
    {
        return "Hello there!";
    }

    public string ShowDescription(string name, int age)
    {
        return GetGreeting() + "My name is " + name + " and I am " + age.ToString() + " years old.";
    }
}