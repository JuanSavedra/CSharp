using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling {
    class Reservation {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut) { 
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration() {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public string UpdateDates(DateTime checkIn, DateTime checkOut) {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now) {
               return "Error in reservation: Reservation dates for update must be future dates";
            }
            
            if (checkOut <= checkIn) {
                return "Error in reservation: Check-out date must be after check-in";
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
            return null; //Nenhum erro
        }

        public override string ToString() {
            return $"Reservation: Room {RoomNumber}, " +
                $"check-in: {CheckIn.ToString("dd/MM/yyyy")}, " +
                $"check-out: {CheckOut.ToString("dd/MM/yyyy")}, " +
                $"duration: {Duration()} " +
                $"nights"; 
        }
    }
}
