using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cerati
{
    class Reservation
    {
        //Parametri
        public string Name { get; set; }
        public string City { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public string RoomType { get; set; }
        public int Temp { get; set; }
        public string SheetSet { get; set; }
        public bool CleanTowelsDaily { get; set; }
        public bool OledTv { get; set; }

        //Calcola il prezzo con i dati inseriti
        public float CalcPrice()
        {
            float price = 0;

            int guests = Adults + Children;

            int duration = (int)(CheckOutDate - CheckInDate).Days;

            int PricePerNight = 0;
            switch(RoomType)
            {
                case "STANDARD":
                    PricePerNight = 50;
                    break;
                case "SUPERIOR":
                    PricePerNight = 75;
                    break;
                case "DELUXE":
                    PricePerNight = 100;
                    break;
            }
                    
            if(duration > 6)    
            {
                int temp = duration - 6;
                        
                price += (PricePerNight * Children * 6) / 2;   
                price += (PricePerNight * Adults * 6);
        
                price += ((PricePerNight * Children * temp) / 2) * 0.95f;          
                price += ((PricePerNight * Adults * temp)) * 0.95f;
            } else
            {
                price += (PricePerNight * Children * duration) / 2;
                price += (PricePerNight * Adults * duration);
            }

            float optionals = 0;

            if (CleanTowelsDaily) optionals += price * 0.10f;
            if (OledTv) optionals += price * 0.20f;


            return price + optionals;
        }

        //Crea il testo di conferma prenotazione
        public string ConfirmationText()
        {
            string result = "Booking confirmation\r\n--------------------\r\n";

            result += "Guest name: " + Name + ", from " + City + "\r\n";
            result += "Check-in: " + CheckInDate.ToShortDateString() + "\r\n";
            result += "Check-out: " + CheckOutDate.ToShortDateString() + "\r\n";
            result += "Nights: " + (int)(CheckOutDate - CheckInDate).TotalDays + "\r\n";
            result += "Number of guests: " + Adults + " adults, " + Children + " children" + "\r\n";
            result += "Room type: " + RoomType + ", " + Temp.ToString() + "°" + "\r\n";
            result += "Sheet Set: " + SheetSet + "\r\n";
            result += "Optionals: ";
            if (CleanTowelsDaily) result += "Clean Towels Dayly, ";
            if (OledTv) result += "Oled TV";

            result += "\r\n\r\n" + "FINAL PRICE: " + CalcPrice() + " EUR";


            return result;
        }

    }
}
