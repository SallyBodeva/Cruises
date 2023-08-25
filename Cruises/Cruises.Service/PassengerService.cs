﻿namespace Cruises.Service
{
    using Cruises.Data;
    using Cruises.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
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
        public int GetPassengerIdByPhoneNum(string phoneNum)
        {
            using (context = new AppDbContext())
            {
                Passenger p = context.Passengers.FirstOrDefault(x => x.PhoneNumber == phoneNum);
                return p.Id;
            }
        }
        public string GetPassengerNameById(int id)
        {
            using (context = new AppDbContext())
            {
                Passenger p = context.Passengers.FirstOrDefault(x => x.Id == id);
                string fullName = $"{p.FirstName} {p.LastName}";
                return fullName;
            }
        }
        public string GetPassengerPhoneById(int id)
        {
            using (context = new AppDbContext())
            {
                Passenger p = context.Passengers.FirstOrDefault(x => x.Id == id);
                return p.PhoneNumber;
            }
        }
        public bool IsPassengerStudent(int id)
        {
            using (context = new AppDbContext())
            {
                Passenger p = context.Passengers.FirstOrDefault(x => x.Id == id);
                return p.IsStudent;
            }
        }
        public bool IsPassengerRetiree(int id)
        {
            using (context = new AppDbContext())
            {
                Passenger p = context.Passengers.FirstOrDefault(x => x.Id == id);
                return p.IsRetiree;
            }
        }
        public decimal  GetLastTiocketPriceById()
        {
            using (context = new AppDbContext())
            {
                Reservation p = context.Reservations.OrderByDescending(x=>x.Id).First();
                decimal price = p.Voyage.TicketPrice;
                return price;
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
                    msg.AppendLine($"\tStudent: {p.IsStudent}");
                    msg.AppendLine($"\tRetiree: {p.IsRetiree}");
                    return msg.ToString().TrimEnd();
                }
                else
                {
                    return $"{nameof(Passenger)} not found!";
                }
            }
        }
        public string GetAllPassengersInfo(int page = 1, int count = 10)
        {
            StringBuilder msg = new StringBuilder();
            string firstRow = $"| {"Id",-4} | {"First name",-12} | {"Last name",-12} | {"Age",-8} | {"Phone number",-12} | {"Student",-10} | {"Retiree",-10} |";

            string line = $"|{new string('-', firstRow.Length - 2)}| ";

            using (context = new AppDbContext())
            {
                List<Passenger> passengers = context.Passengers.Skip((page - 1) * count).Take(count).ToList();
                msg.AppendLine(firstRow);
                msg.AppendLine(line);
                foreach (var p in passengers)
                {
                    string info = $"| {p.Id,-4} | {p.FirstName,-12} | {p.LastName,-12} | {p.Age,-8} | {p.PhoneNumber,-12} | {p.IsStudent,-10} | {p.IsRetiree,-10} |";
                    msg.AppendLine(info);
                    msg.AppendLine(line);
                }
                int pageCount = (int)Math.Ceiling(context.Passengers.Count() / (decimal)count);
                msg.AppendLine($"Page: {page} / {pageCount}");
            }

            return msg.ToString().TrimEnd();

        }
        public int GetPassengersPagesCount(int count = 10)
        {
            using (context = new AppDbContext())
            {
                return (int)Math.Ceiling(context.Passengers.Count() / (double)count);
            }
        }
        public bool IsPassengerAlreayOurClient(string phoneNum)
        {
            using (context= new AppDbContext())
            {
                Passenger p = context.Passengers.FirstOrDefault(x => x.PhoneNumber == phoneNum);
                List<Passenger> passengers = context.Passengers.ToList();
                if (passengers.Contains(p))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public string MatchPassengerToVoyage(int passengeId, int voyageId, DateTime date)
        {
            using (context = new AppDbContext())
            {
                Passenger p = context.Passengers.Find(passengeId);
                Voyage v = context.Voyages.Find(voyageId);
                if (p == null)
                {
                    return "Passenger not found!";
                }
                if (v == null)
                {
                    return "Voyage not found!";
                }
                context.Reservations.Add(new Reservation() { Passenger = p, Voyage = v, ReservationDate = date });
                context.SaveChanges();
                return "Reservation created!";
            }
        }
    }
}
