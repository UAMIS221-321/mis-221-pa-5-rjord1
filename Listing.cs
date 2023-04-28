namespace mis_221_pa_5_rjord1
{
    public class Listing
    {
        private int listingId;
        private string trainerName;
        private string sessionDate;
        private string sessionTime;
        private string sessionCost;
        private bool sessionTaken;
        static private int ID;
        private bool active;


        public Listing(){

        }

        public Listing(string trainerName, string sessionDate, string sessionTime, string sessionCost, bool sessionTaken, bool active){
            this.listingId = ID;
            ID ++;
            this.trainerName = trainerName;
            this.sessionDate = sessionDate;
            this.sessionTime = sessionTime;
            this.sessionCost = sessionCost;
            this.sessionTaken = sessionTaken;
            this.active = active;
            
        }

        public void SetListingId(int listingId){
            
            this.listingId = listingId;
        }

        // public int CreateListingID(){
        //     Random RandomId = new Random();
        //     int listingId = RandomId.Next(1,1000);
        //     return listingId;
        // }
        // // public int GetListingId(){
        // //     return listingId;
        // // }

        public int GetListingId(){
        
        return listingId;
    }
        public void SetTrainerName(string trainerName){
            this.trainerName = trainerName;
        }
        public string GetTrainerName(){
            return trainerName;
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
            return $"- Lising ID: {listingId}\tTrainer Name: {trainerName}\tSession Date: {sessionDate}\tSession Time: {sessionTime}\tSession Cost: ${sessionCost}\tSession Taken: {sessionTaken}";
        }

        public string ToFile(){
           return $"{trainerName}#{sessionDate}#{sessionTime}#{sessionCost}#{sessionTaken}#{active}";
        }




    }
}