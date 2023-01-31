﻿using Exercicio9.Entities;
using Exercicio9.Entities.Exceptions;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine($"Reservation: {reservation}");

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine($"Reservation: {reservation}");
            }
            catch (DomainException e) //Exceção que eu criei
            {
                Console.WriteLine($"Error in reservation: {e.Message}");
            }
            catch (FormatException e) //Padrão do sistema;
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            catch (Exception e) //exceção genérica(captura qualquer erro que tiver)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}