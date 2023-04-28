
namespace mis_221_pa_5_rjord1
{
    public class BookingUtility
    {
        
        static int SESSION_MAXCOUNT = 100;
        private Booking [] bookings = new Booking[SESSION_MAXCOUNT];

        private Listing [] listings = new Listing[SESSION_MAXCOUNT];

        private Trainer [] trainers = new Trainer[SESSION_MAXCOUNT];

        static public int count;

        public BookingUtility(Booking [] bookings){
            this.bookings = bookings;
        }

        static public void SetCount (int count){
            BookingUtility.count = count;
        }

        static public int GetCount (){
            return count;
        }

        static public void IncCount(){
            BookingUtility.count ++;
        }

        public void GetAllBookingsFromFile(Booking [] bookings){
            StreamReader inFile = new StreamReader("transactions.txt");

            // BookingUtility.SetCount(0);
            Booking.SetCount(0);
            string line = inFile.ReadLine();
            while(line != null){
                string [] temp = line.Split('#');
                bookings[BookingUtility.GetCount()] = new Booking(int.Parse(temp[0]),temp[1],temp[2],temp[3],int.Parse(temp[4]),temp[5]);
                Booking.IncCount();
                line = inFile.ReadLine();
            }

            inFile.Close();


        }

        private void SaveBooking(Booking [] bookings){
            StreamWriter outFile = new StreamWriter("transactions.txt");

            for(int i = 0; i < Booking.GetCount(); i ++){
                outFile.WriteLine(bookings[i].ToFile());
            }
            
            outFile.Close();
        }

        public int Find(string searchVal,Listing [] listings){
            for(int i = 0; i < ListingUtility.GetCount(); i++){
                if(listings[i].GetListingId() == int.Parse(searchVal)){
                    return i;
                }
            }

            return -1;
        }

        public void BookASession(Listing [] listings, Trainer [] trainers){
            
            System.Console.WriteLine("Please enter the Listing ID:");
            string searchVal = Console.ReadLine();
            int foundIndex = Find(searchVal, listings);

            if(foundIndex != -1){
            Booking newSession = new Booking();
            System.Console.WriteLine("Enter Session ID: ");
            newSession.SetSessionId(int.Parse(Console.ReadLine()));
            System.Console.WriteLine("Please enter the customer name:");
            newSession.SetCustomerName(Console.ReadLine());
            System.Console.WriteLine("Please enter the customer email:");
            newSession.SetCustomerEmail(Console.ReadLine());
            
            newSession.SetTrainingDate(listings[foundIndex].GetSessionDate());

            int mytrainer = 


            newSession.SetTrainingId(trainers[foundIndex].GetTrainerId());
            newSession.SetTrainerName(listings[foundIndex].GetTrainerName());
            System.Console.WriteLine("You are now booked for your session!");
            newSession.SetSessionStatus("Booked");
            

            bookings[Booking.GetCount()] = newSession;
            BookingUtility.IncCount();
            Booking.IncCount();

            SaveBooking(bookings);
            }
            else{
                System.Console.WriteLine("Session not found!");
            }
        }



    }
}