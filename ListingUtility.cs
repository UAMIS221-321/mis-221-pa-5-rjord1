
namespace mis_221_pa_5_rjord1
{
    public class ListingUtility
    {

        static int MAX_IDCOUNT = 100;


        private Listing [] listings = new Listing[MAX_IDCOUNT];

        static public int count;


        public ListingUtility(Listing [] listings){
            this.listings = listings;
        }

        static public void SetCount (int count){
            ListingUtility.count = count;
        }

        static public int GetCount (){
            return count;
        }

        static public void IncCount(){
            ListingUtility.count ++;
        }

        public void GetAllListingsFromFile(){
            StreamReader inFile = new StreamReader("listing.txt");

            ListingUtility.SetCount(0);
            string line = inFile.ReadLine();
            while(line != null){
                string [] temp = line.Split('#');
                listings[ListingUtility.GetCount()] = new Listing(temp[0],temp[1],temp[2],temp[3],bool.Parse(temp[4]),bool.Parse(temp[5]));
                ListingUtility.IncCount();
                line = inFile.ReadLine();
            }

            inFile.Close();


        }

        public void AddListing(){
            System.Console.WriteLine("Please enter the Training ID:");
            Listing newListing = new Listing();
            newListing.SetListingId(int.Parse(Console.ReadLine()));
            System.Console.WriteLine("Please enter the trainer name:");
            newListing.SetTrainerName(Console.ReadLine());
            System.Console.WriteLine("Please enter the date of the session:");
            newListing.SetSessionDate(Console.ReadLine());
            System.Console.WriteLine("Please enter the Time of the session:");
            newListing.SetSessionTime(Console.ReadLine());
            System.Console.WriteLine("Pleae enter the cost of the session:");
            newListing.SetSessionCost(Console.ReadLine());
            newListing.SessionNotTaken(true);
            newListing.SetActive(true);
            

            listings[ListingUtility.GetCount()] = newListing;
            ListingUtility.IncCount();

            SaveListing();
        }

        private void SaveListing(){
            StreamWriter outFile = new StreamWriter("listing.txt");

            for(int i = 0; i < ListingUtility.GetCount(); i ++){
                outFile.WriteLine(listings[i].ToFile());
            }
            
            outFile.Close();
        }

        public int Find(string searchVal){
            for(int i = 0; i < ListingUtility.GetCount(); i++){
                if(listings[i].GetListingId() == int.Parse(searchVal)){
                    return i;
                }
            }

            return -1;
        }

         public void UpdateListings(){
            System.Console.WriteLine("What is the Id of the listing you want to edit?");
            string searchVal = Console.ReadLine();
            int foundIndex = Find(searchVal);

            if(foundIndex != -1){
            System.Console.WriteLine("Please enter the trainer name:");
            listings[foundIndex].SetTrainerName(Console.ReadLine());
            System.Console.WriteLine("Please enter the date of the session:");
            listings[foundIndex].SetSessionDate(Console.ReadLine());
            System.Console.WriteLine("Please enter the Time of the session:");
            listings[foundIndex].SetSessionTime(Console.ReadLine());
            System.Console.WriteLine("Pleae enter the cost of the session:");
            listings[foundIndex].SetSessionCost(Console.ReadLine());
            System.Console.WriteLine("Enter 1 if the session is taken. Eneter 2 if the session is not taken.");
            string userchoice = Console.ReadLine();
            if(userchoice == "1"){
                listings[foundIndex].SessionTaken(true);
            }
            if(userchoice == "2"){
                listings[foundIndex].SessionNotTaken(true);
            }


           
            SaveListing();
            }

            else{
                System.Console.WriteLine("Listing not found!");
            }
        }

        public void DeleteListing(){
            System.Console.WriteLine("What is the ID of the listing you would like to delete?");
            string searchVal = Console.ReadLine();
            int foundIndex = Find(searchVal);

            if(foundIndex != -1){
                
                listings[foundIndex].SetNotActive(true);

                SaveListing();
            }

            else{
                System.Console.WriteLine("Listing not found!");
            }
            
        }




    }
}