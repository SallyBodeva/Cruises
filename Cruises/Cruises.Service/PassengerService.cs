using Cruises.Data;
using Cruises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cruises.Service
{
    public class PassengerService
    {
        private AppDbContext context;

        public string AddPassenger(string firstName, string lastName, string phoneNumber, int age, bool isSudent, bool isRetiree)
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
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                msg.AppendLine($"Invalid {nameof(phoneNumber)}!");
                isValid = false;
            }
            if (age <= 0)
            {
                msg.AppendLine($"Invalid {nameof(age)}!");
                isValid = false;
            }
            using (context = new AppDbContext())
            {
                if (isValid)
                {
                    Passenger p = new Passenger()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        PhoneNumber = phoneNumber,
                        Age = age,
                        IsStudent = isSudent,
                        IsRetiree = isRetiree
                    };
                    this.context.Passengers.Add(p);
                    this.context.SaveChanges();
                    msg.AppendLine($"Passenger {firstName} {lastName} got on board!");
                }
                return msg.ToString().TrimEnd();
            }
        }
        public string DeletePassengerById(int id)
        {
            using (context = new AppDbContext())
            {
                Passenger p = this.context.Passengers.FirstOrDefault(x => x.Id == id);
                if (p == null)
                {
                    return $"{nameof(Passenger)} not found!";
                }
                context.Passengers.Remove(p);
                context.SaveChanges();
                return $"{nameof(Passenger)} {p.FirstName} {p.LastName} got off board!";
            }
        }
        public Passenger GetPassengerById(int id)
        {
            using (context = new AppDbContext())
            {
                return context.Passengers.FirstOrDefault(x => x.Id == id);
            }
        }
        public string GetPassengerInfoById(int id)
        {
            Passenger p = null;
            using (context = new AppDbContext())
            {
                p = context.Passengers.Find(id);

                if (p != null)
                {
                    StringBuilder msg = new StringBuilder();
                    msg.AppendLine($"{nameof(Passenger)} info: ");
                    msg.AppendLine($"\tId: {p.Id}");
                    msg.AppendLine($"\tFirst name: {p.FirstName}");
                    msg.AppendLine($"\tLast name: {p.LastName}");
                    msg.AppendLine($"\tAge: {p.Age}");
                    msg.AppendLine($"\tPhone number: {p.PhoneNumber}");
                    msg.AppendLine($"\t Student: {p.IsStudent}");
                    msg.AppendLine($"\t Retiree: {p.IsRetiree}");
                    return msg.ToString().TrimEnd();
                }
                else
                {
                    return $"{nameof(Passenger)} not found!";
                }
            }
        }
    }
}
