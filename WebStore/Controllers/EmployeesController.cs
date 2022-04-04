using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers;

public class EmployeesController : Controller
{
    private static readonly List<Employee> _employees = new()
    {
        new Employee()
        {
            Age = 23,
            Birthday = new DateTime(1991, 05, 20),
            DepartamentName = "Vanzari",
            FirstName = "Aurel",
            LastName = "Cavaz",
            Id = 1,
            PatronimicName = "Joricovici"
        },
        new Employee()
        {
            Age = 23,
            Birthday = new DateTime(1991, 05, 20),
            DepartamentName = "Administrare",
            FirstName = "Ion",
            LastName = "Frunze",
            Id = 2,
            PatronimicName = "Ionovici"
        },
        new Employee()
        {
            Age = 23,
            Birthday = new DateTime(1991, 05, 20),
            DepartamentName = "Auxiliar",
            FirstName = "Iura",
            LastName = "Streltov",
            Id = 3,
            PatronimicName = "Hersono"
        },
    };

    public IActionResult Details(int id)
    {
        var employee = _employees.FirstOrDefault(x => x.Id == id);

        if (employee == null) return NotFound();

        return View(employee);
    }
    public IActionResult Index()
    {
        return View(_employees);
    }
}