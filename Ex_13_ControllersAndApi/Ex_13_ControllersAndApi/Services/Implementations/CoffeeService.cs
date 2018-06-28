using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Ex_13_ControllersAndApi.Models.Api;
using Ex_13_ControllersAndApi.Services.Definitions;

namespace Ex_13_ControllersAndApi.Services.Implementations
{
    public class CoffeeService : IBeverageService
    {
        private List<Coffee> ListOfCoffees { get; set; } = new List<Coffee>()
        {
            new Coffee(){Id=1,Name="Antuka coffee",PlantingOrigin="Slovakia"},
            new Coffee(){Id=2,Name="Borat coffee",PlantingOrigin="Kazakhstan"}
        };
        public Beverage SingleById(int Id)
        {
            return ListOfCoffees.FirstOrDefault(x => x.Id == Id);  
        }

        public Beverage SingleByName(string name)
        {
            return ListOfCoffees.FirstOrDefault(x => x.Name == name);
        }

        public IEnumerable<Beverage> FindByName(string name)
        {
            return ListOfCoffees.Where(x => x.Name.Contains(name));
        }
        public IEnumerable<Beverage> All()
        {
            return ListOfCoffees;
        }
    }
}
