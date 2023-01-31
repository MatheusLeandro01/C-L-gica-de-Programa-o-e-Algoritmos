using Exercicio9.Entities;
using Exercicio9.Entities.Exceptions;

namespace Exercicio9.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if (CheckOut <= CheckIn)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (CheckIn < now || CheckOut < now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }
            if (CheckOut <= CheckIn)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }
            CheckIn = checkin;
            CheckOut = checkout;
        }
        public override string ToString()
        {
            return $"Room {RoomNumber}, check-in: {CheckIn.ToString("dd/MM/yyyy")}, check-out: {CheckOut.ToString("dd/MM/yyyy")}, " +
                $"{Duration()} nights.";
        }

    }
}
