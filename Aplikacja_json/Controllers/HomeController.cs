using Microsoft.AspNetCore.Mvc;
using Aplikacja_JSON.Models;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Aplikacja_JSON.Controllers
{
    public class HomeController : Controller
    {
        private readonly string _filePath = "Data/persons.json";

        [HttpGet]
        public IActionResult Index()
        {
            List<Person> persons = new List<Person>();
            if (System.IO.File.Exists(_filePath))
            {
                string json = System.IO.File.ReadAllText(_filePath);
                persons = JsonConvert.DeserializeObject<List<Person>>(json);
            }

            return View(persons);
        }

        [HttpPost]
        public IActionResult AddPerson(Person person)
        {
            List<Person> persons = new List<Person>();
            if (System.IO.File.Exists(_filePath))
            {
                string json = System.IO.File.ReadAllText(_filePath);
                persons = JsonConvert.DeserializeObject<List<Person>>(json);
            }

            persons.Add(person);

            string updatedJson = JsonConvert.SerializeObject(persons, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(_filePath, updatedJson);

            return RedirectToAction("Index");
        }
    }
}
