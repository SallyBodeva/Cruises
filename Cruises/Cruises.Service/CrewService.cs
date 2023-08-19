namespace Cruises.Service
{
    using Cruises.Data;
    using Cruises.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class CrewService
    {
        private AppDbContext context;
        public string AddCrewMember(string firstName, string lastName, int age, double rating, string position)
        {
            StringBuilder msg = new StringBuilder();
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(firstName))
            {
                msg.AppendLine($"Invalid {nameof(firstName)}!");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(lastName))
            {
                msg.AppendLine($"Invalid {nameof(lastName)}!");
                isValid = false;
            }
            if (age <= 0)
            {
                msg.AppendLine($"Invalid {nameof(age)}!");
                isValid = false;
            }
            if (rating < 0)
            {
                msg.AppendLine($"Invalid {nameof(rating)}!");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(position))
            {
                msg.AppendLine($"Invalid {nameof(position)}!");
                isValid = false;
            }
            using (context = new AppDbContext())
            {
                if (isValid)
                {
                    CrewMember cm = new CrewMember()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        Rating = rating,
                        Position = position
                    };
                    this.context.CrewMembers.Add(cm);
                    this.context.SaveChanges();
                    msg.AppendLine($"A new crewmate {firstName} {lastName} got on board!");
                }
                return msg.ToString().TrimEnd();
            }
        }
        public string DeleteCrewMemberById(int id)
        {
            using (context = new AppDbContext())
            {
                CrewMember cm = context.CrewMembers.Find(id);
                if (cm == null)
                {
                    return $"{nameof(CrewMember)} not found!";
                }
                context.CrewMembers.Remove(cm);
                context.SaveChanges();
                return $"{nameof(CrewMember)} {cm.FirstName} {cm.LastName} was fired!";
            }
        }
        public string UpdateCrewMemberRatingById(int id, double newRating)
        {
            using (context = new AppDbContext())
            {
                CrewMember cm = this.context.CrewMembers.FirstOrDefault(x => x.Id == id);
                if (cm != null)
                {
                    cm.Rating = newRating;
                    context.Update(cm);
                    context.SaveChanges();
                    return $"{nameof(CrewMember)} {cm.FirstName} {cm.LastName} has new rating!";
                }
                else
                {
                    return "This voyage does not exist...";
                }
            }
        }
        public List<string> GetCrewMemberBasicInfo(int page = 1, int count = 10)
        {
            List<string> list = null;
            using (context = new AppDbContext())
            {
                list = context.CrewMembers
                    .Skip((page - 1) * count)
                    .Take(count).Select(x => $"{x.Id} - {x.FirstName} {x.LastName}")
                    .ToList();
            }
            return list;
        }
        public int GetCrewPagesCount(int count = 10)
        {
            using (context = new AppDbContext())
            {
                return (int)Math.Ceiling(context.CrewMembers.Count() / (double)count);
            }
        }
        public CrewMember GetCrewMemberById(int id)
        {
            using (context= new AppDbContext())
            {
                CrewMember cm= context.CrewMembers.FirstOrDefault(x => x.Id == id);
                return cm;
            }
        }

        public string AddShipCrew(int shipId, List<int> crewMemberIds)
        {
            StringBuilder message = new StringBuilder();
            using (context = new AppDbContext())
            {
                Ship s = context.Ships.Find(shipId);
                if (s == null)
                {
                    message.AppendLine($"{nameof(Ship)} not found!");
                    return message.ToString().TrimEnd();
                };
                List<CrewMember> members = new List<CrewMember>();
                foreach (var id in crewMemberIds)
                {
                    CrewMember cm = context.CrewMembers.Find(id);
                    if (cm != null)
                    {
                        members.Add(cm);
                    }
                }
                if (members.Count == 0)
                {
                    message.AppendLine($"{nameof(CrewMember)}s not found!");
                    return message.ToString().TrimEnd();
                }
                message.AppendLine($"{shipId} {s.Name} {s.Model} cabin crew: ");
                foreach (var member in members)
                {
                    context.ShipCrewMembers.Add(new ShipCrewMember
                    {
                        Ship = s,
                        CrewMember = member
                    });
                    message.AppendLine($"\t{member.FirstName} {member.LastName}");
                }
                context.SaveChanges();
                return message.ToString().TrimEnd();
            }
        }
    }
}
