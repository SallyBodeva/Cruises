namespace Cruises.Service
{
    using Cruises.Data;
    using Cruises.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class AdditionalService
    {
        private  AppDbContext context;
        public  City GetCityByName(string name)
        {
            using (context = new AppDbContext())
            {
                City c = this.context.Cities.FirstOrDefault(x => x.Name == name);
                return c;
            }
        }
    }
}
