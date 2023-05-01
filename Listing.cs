namespace mis_221_pa_5_rjord1
{
    public class Listing
    {
        //Instance Variable
        private int listingId;
        private string trainerName;
        private string sessionDate;
        private string sessionTime;
        private string sessionCost;
        private bool sessionTaken;
        private int trainerId;
        static private int ID;
        private bool active;
        static private int count;


        public Listing(){//Constructor with no argument

        }

        public Listing(int listingId,string trainerName, int trainerId, string sessionDate, string sessionTime, string sessionCost, bool sessionTaken, bool active){ //constructor with argument
            this.listingId = ID;
            ID ++;//Everytime a new Listing is made the ID count is incrimented
            this.trainerName = trainerName;
            this.trainerId = trainerId;
            this.sessionDate = sessionDate;
            this.sessionTime = sessionTime;
            this.sessionCost = sessionCost;
            this.sessionTaken = sessionTaken;
            this.active = active;
            
        }

        static public void SetCount(int count){
            Listing.count = count;
        }

        static public int GetCount(){
            return count;
        }

        static public void IncCount(){
            Listing.count ++;
        }




        public void SetListingId(int listingId){
            
            this.listingId = listingId;
        }

        public int GetListingId(){
        
        return listingId;
    }
        public void SetTrainerName(string trainerName){
            this.trainerName = trainerName;
        }
        public string GetTrainerName(){
            return trainerName;
        }

        public void SetTrainingId(int trainerID){
            this.trainerId = trainerID;
        }

        public int GetTrainingId(){
            return trainerId;
        }
        public void SetSessionDate(string sessionDate){
            this.sessionDate = sessionDate;
        }
        public string GetSessionDate(){
            return sessionDate;
        }

        public void SetSessionTime(string sessionTime){
            this.sessionTime = sessionTime;
        }
        public string GetSessionTime(){
            return sessionTime;
        }

        public void SetSessionCost(string sessionCost){
            this.sessionCost = sessionCost;
        }
        public string GetSessionCost(){
            return sessionCost;
        }

        public void SessionTaken(bool sessionTaken){
            this.sessionTaken = true;
        }

        public void SessionNotTaken(bool sessionTaken){
            this.sessionTaken = false;
        }
        public bool GetSessionTaken(){
            
            return sessionTaken;
        }

        

         public void SetActive(bool active){
            this.active = true;
        }

        public void SetNotActive(bool active){
            this.active = false;
        }

        public bool GetActive(){
            return active;
        }

        public override string ToString()
        {
            return $"- Lising ID: {listingId}\tTrainer Name: {trainerName}\tTrainer Id: {trainerId}\tSession Date: {sessionDate}\tSession Time: {sessionTime}\tSession Cost: ${sessionCost}\tSession Taken: {sessionTaken}";
        }

        public string ToFile(){
           return $"{listingId}#{trainerName}#{trainerId}#{sessionDate}#{sessionTime}#{sessionCost}#{sessionTaken}#{active}";
        }




    }
}