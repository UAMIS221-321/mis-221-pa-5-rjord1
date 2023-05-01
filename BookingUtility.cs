
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

        static public void SetCount (int count){ // Booking utility count used to store officail count
            BookingUtility.count = count;
        }

        static public int GetCount (){
            return count;
        }

        static public void IncCount(){
            BookingUtility.count ++;
        }

        public void GetAllBookingsFromFile(Booking [] bookings){ //Gets all file data and reads it in memory
            StreamReader inFile = new StreamReader("transactions.txt");

            // BookingUtility.SetCount(0);
            Booking.SetCount(0);
            string line = inFile.ReadLine();
            while(line != null){
                string [] temp = line.Split('#');
                bookings[BookingUtility.GetCount()] = new Booking(int.Parse(temp[0]),temp[1],temp[2],temp[3],int.Parse(temp[4]),temp[5],temp[6]);
                BookingUtility.IncCount();
                Booking.IncCount();
                line = inFile.ReadLine();
            }

            inFile.Close();


        }

        private void SaveBooking(Booking [] bookings){ //Uses of the toFile method to store all Edited and Added data to file
            StreamWriter outFile = new StreamWriter("transactions.txt");

            for(int i = 0; i < Booking.GetCount(); i ++){
                outFile.WriteLine(bookings[i].ToFile());
            }
            
            outFile.Close();
        }

        public int Find(string searchVal,Listing [] listings){ //Specifically pulls from the listing array
            for(int i = 0; i < ListingUtility.GetCount(); i++){
                if(listings[i].GetListingId() == int.Parse(searchVal)){
                    return i;
                }
            }

            return -1;
        }

        public int FindBooking(string searchVal){ //If the correct search Val will return 'i' value
            for(int i = 0; i < BookingUtility.GetCount(); i++){
                if(bookings[i].GetSessionId() == int.Parse(searchVal)){
                    return i;
                }
            }

            return -1;
        }

        public void BookASession(Listing [] listings, Trainer [] trainers){ // Allows you to add to current object array
            
            System.Console.WriteLine("Please enter the Listing ID:");
            string searchVal = Console.ReadLine();
            int foundIndex = Find(searchVal, listings);

            if(foundIndex != -1){
            Booking newSession = new Booking();
            newSession.SetSessionId(BookingUtility.GetCount());
            System.Console.WriteLine("Please enter the customer name:");
            newSession.SetCustomerName(Console.ReadLine());
            System.Console.WriteLine("Please enter the customer email:");
            newSession.SetCustomerEmail(Console.ReadLine());
            
            newSession.SetTrainingDate(listings[foundIndex].GetSessionDate());
            newSession.SetTrainingId(listings[foundIndex].GetTrainingId());
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

        public void ChangeBookingStatus(){ //Allows you to edit a current array
            System.Console.WriteLine("Enter the session ID that you would like to edit:");
            string searchVal = Console.ReadLine();
            int foundIndex = FindBooking(searchVal);

            if(foundIndex != -1){
                
                System.Console.WriteLine("1. This session was completed\n2. This session was canceled");
                int userSelection = int.Parse(Console.ReadLine());
                if(userSelection == 1){
                    bookings[foundIndex].SetSessionStatus("Completed");
                }
                if(userSelection == 2){
                    bookings[foundIndex].SetSessionStatus("Canceled");
                }

                SaveBooking(bookings);

            }
            else{
                System.Console.WriteLine("Session not found!");
            }

        }



    }
}