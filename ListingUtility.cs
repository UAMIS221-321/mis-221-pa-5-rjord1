
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

        static public void SetCount (int count){ // Listing utility count used to store officail count
            ListingUtility.count = count;
        }

        static public int GetCount (){
            return count;
        }

        static public void IncCount(){
            ListingUtility.count ++;
        }

        public void GetAllListingsFromFile(){ //Gets all file data and reads it in memory
            StreamReader inFile = new StreamReader("listing.txt");

            ListingUtility.SetCount(0);
            string line = inFile.ReadLine();
            while(line != null){
                string [] temp = line.Split('#');
                listings[ListingUtility.GetCount()] = new Listing(int.Parse(temp[0]),temp[1],int.Parse(temp[2]),temp[3],temp[4],temp[5],bool.Parse(temp[6]),bool.Parse(temp[7]));
                ListingUtility.IncCount();
                line = inFile.ReadLine();
            }

            inFile.Close();


        }

        public int FindTrainer(string tSearchVal,Trainer [] trainers){ //Specifically pulls from the trainer array
            for(int i = 0; i < TrainerUtility.GetCount(); i++){
                if(trainers[i].GetTrainerId() == int.Parse(tSearchVal)){
                    return i;
                }
            }

            return -1;
        }

        public void AddListing(Trainer [] trainers){ // Allows you to add to current object array
            System.Console.WriteLine("Please enter the Trainer ID:");
            string tSearchVal = Console.ReadLine();
            int foundIndex = FindTrainer(tSearchVal, trainers);
            if(foundIndex != -1){
            Listing newListing = new Listing();
            newListing.SetTrainerName(trainers[foundIndex].GetTrainerName());
            System.Console.WriteLine("Please enter the date of the session:");
            newListing.SetSessionDate(Console.ReadLine());
            System.Console.WriteLine("Please enter the Time of the session:");
            newListing.SetSessionTime(Console.ReadLine());
            System.Console.WriteLine("Pleae enter the cost of the session:");
            newListing.SetSessionCost(Console.ReadLine());
            newListing.SetTrainingId(trainers[foundIndex].GetTrainerId());
            newListing.SessionNotTaken(true);
            newListing.SetActive(true);
            newListing.SetListingId(ListingUtility.GetCount());
            

            listings[ListingUtility.GetCount()] = newListing;
            ListingUtility.IncCount();
            Listing.IncCount();

            SaveListing();
            }
            else{
                System.Console.WriteLine("Trainer not found :()");
            }
        }

        private void SaveListing(){ //Uses of the toFile method to store all Edited and Added data to file
            StreamWriter outFile = new StreamWriter("listing.txt");

            for(int i = 0; i < ListingUtility.GetCount(); i ++){
                outFile.WriteLine(listings[i].ToFile());
            }
            
            outFile.Close();
        }

        public int Find(string searchVal){ //If the correct search Val will return 'i' value
            for(int i = 0; i < ListingUtility.GetCount(); i++){
                if(listings[i].GetListingId() == int.Parse(searchVal)){
                    return i;
                }
            }

            return -1;
        }

         public void UpdateListings(){ //Allows you to edit a current array
            System.Console.WriteLine("What is the Id of the listing you want to edit?");
            string searchVal = Console.ReadLine();
            int foundIndex = Find(searchVal);

            if(foundIndex != -1){
            System.Console.WriteLine("Enter 1 if the session is taken. Eneter 2 if the session is not taken.");
            string userchoice = Console.ReadLine();
            if(userchoice == "1"){
                listings[foundIndex].SessionTaken(true);
            }
            if(userchoice == "2"){
                listings[foundIndex].SessionNotTaken(true);
                System.Console.WriteLine("Please enter the date of the session:");
                listings[foundIndex].SetSessionDate(Console.ReadLine());
                System.Console.WriteLine("Please enter the Time of the session:");
                listings[foundIndex].SetSessionTime(Console.ReadLine());
                System.Console.WriteLine("Pleae enter the cost of the session:");
                listings[foundIndex].SetSessionCost(Console.ReadLine());
            }
            


           
            SaveListing();
            }

            else{
                System.Console.WriteLine("Listing not found!");
            }
        }

        public void DeleteListing(){ //Allows you to soft delete a current array
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