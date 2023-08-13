namespace Cruises.Service
{
    using Cruises.Data;
    using Cruises.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class HarbourService
    {
        private AppDbContext context;

        public string CreateHarbour(string name, int cityId)
        {
            StringBuilder message = new StringBuilder();
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(name))
            {
                message.AppendLine("Inavlid name of the new Harbour");
                isValid = false;
            }
            if (cityId<1)
            {
                message.AppendLine("Inavlid id of the city");
                isValid = false;
            }
            using (context= new AppDbContext())
            {
                if (isValid)
                {
                    Harbour h = new Harbour()
                    {
                        Name = name,
                        CityId = cityId
                    };
                    message.AppendLine("Our EnchantedEscala-Cruises has a new harbour to moor at...");
                }
            }
            return message.ToString().TrimEnd();
        }
    }
}
