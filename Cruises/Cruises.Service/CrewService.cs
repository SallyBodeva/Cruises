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
        public string GetAllCrewMembersInfo(int page = 1, int count = 10)
        {
            StringBuilder msg = new StringBuilder();
            string firstRow = $"| {"Id",-4} | {"First name",-12} | {"Last name",-12} | {"Age",-8} | {"Rating",-15} | {"Position",-15} |";

            string line = $"|{new string('-', firstRow.Length - 2)}|";

            using (context = new AppDbContext())
            {
                List<CrewMember> crewMembers = context.CrewMembers.Skip((page - 1) * count).Take(count).ToList();
                msg.AppendLine(firstRow);
                msg.AppendLine(line);
                foreach (var c in crewMembers)
                {
                    string info = $"| {c.Id,-4} | {c.FirstName,-12} | {c.LastName,-12} | {c.Age,-8} | {c.Rating,-15} | {c.Position,-15} |";
                    msg.AppendLine(info);
                    msg.AppendLine(line);
                }
                int pageCount = (int)Math.Ceiling(context.CrewMembers.Count() / (decimal)count);
                msg.AppendLine($"Page: {page} / {pageCount}");
            }

            return msg.ToString().TrimEnd();
        }
        public string GetCrewMemebrInfo(int id)
        {
            CrewMember c = null;
            using (context = new AppDbContext())
            {
                c = context.CrewMembers.Find(id);
            }
            if (c != null)
            {
                StringBuilder masege = new StringBuilder();
                masege.AppendLine($"Employee info: ");
                masege.AppendLine($"\tId: {c.Id}");
                masege.AppendLine($"\tFirst name: {c.FirstName}");
                masege.AppendLine($"\tLast name: {c.LastName}");
                masege.AppendLine($"\tAge: {c.Age}");
                masege.AppendLine($"\tRating: {c.Rating}");
                masege.AppendLine($"\tPosition: {c.Position}");
                return masege.ToString().TrimEnd();
            }
            else
            {
                return $"Crew member not found!";
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
            using (context = new AppDbContext())
            {
                CrewMember cm = context.CrewMembers.FirstOrDefault(x => x.Id == id);
                return cm;
            }
        }

        public List<string> GetCrewInfo()
        {
            using (context = new AppDbContext())
            {
                List<string> list = context.CrewMembers.Select(x => $"{x.Id} - {x.FirstName} {x.LastName}").ToList();
                return list;
            }
        }
        public string AddVoayeTeam(int voyageId, List<int> teamId)
        {
            StringBuilder message = new StringBuilder();
            using (context = new AppDbContext())
            {
                Voyage v = context.Voyages.Find(voyageId);
                if (v == null)
                {
                    message.AppendLine($"{nameof(Voyage)} not found!");
                    return message.ToString().TrimEnd();
                }
                List<CrewMember> crew = new List<CrewMember>();
                foreach (var id in teamId)
                {
                    CrewMember cM = context.CrewMembers.Find(id);
                    if (cM != null)
                    {
                        crew.Add(cM);
                    }
                }
                if (crew.Count == 0)
                {
                    message.AppendLine($"{nameof(CrewMember)}s not found!");
                    return message.ToString().TrimEnd();
                }
                message.AppendLine($"{voyageId} {v.Name} team: ");
                foreach (var crewMember in crew)
                {
                    context.VoyageCrewMembers.Add(new VoyageCrewMember
                    {
                        Voyage = v,
                        CrewMember = crewMember
                    });
                    message.AppendLine($"\t{crewMember.FirstName} {crewMember.LastName}");
                }
                context.SaveChanges();
                return message.ToString().TrimEnd();
            }
        }
    }
}
