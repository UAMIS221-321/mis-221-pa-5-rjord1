using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis_221_pa_5_rjord1
{
    public class BookingReport
    {
        private Listing [] listings;

        private Booking [] bookings;

        public BookingReport(Listing[] listings, Booking [] bookings){
            this.listings = listings;
            this.bookings = bookings;
        }

        public static void PrintAllAvailableSessions(Listing [] listings){
            for(int i = 0; i < ListingUtility.GetCount(); i++){
                if(listings[i].GetActive() == true && listings[i].GetSessionTaken() == false){
                    System.Console.WriteLine(listings[i].ToString());
                }

            }
        }

        public static void PrintAllBookings(Booking [] bookings){
            for(int i = 0; i < Booking.GetCount(); i++){
              
                 System.Console.WriteLine(bookings[i].ToString());

            }
        }


    }
}