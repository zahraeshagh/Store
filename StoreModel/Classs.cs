using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreModel
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Category
    {
        public int Id{ get; set; }
        public string Name {get; set; }

    }

    public class Company
    {
        public int Id { get; set; }
        public string PersianName { get; set; }
        public string EnglishName { get; set; }
        public int CountryId { get; set; }

    }

    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string ModelName { get; set; }
        public string Description { get; set; }
    }
}
