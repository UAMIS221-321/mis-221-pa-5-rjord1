
namespace mis_221_pa_5_rjord1
{
    public class Booking
    {
        private int sessionId;
        private string customerName;
        private string customerEmail;
        private string trainingDate;
        private int trainerId;
        static private int ID;
        private string trainerName;
        private string sessionStatus = "Booked";
        static private int count;

        static public void SetCount(int count){
            Booking.count = count;
        }

        static public int GetCount(){
            return count;
        }

        static public void IncCount(){
            Booking.count ++;
        }


        public Booking(){

        }

        public Booking(int sessionId, string customerName, string customerEmail, string trainingDate,int trainerID, string sessionStatus){
            this.sessionId = ID;
            ID++;
            this.customerName = customerName;
            this.customerEmail = customerEmail;
            this.trainingDate = trainingDate;
            this.trainerId = trainerID;
            
            this.sessionStatus = sessionStatus;
        }

        public void SetSessionId(int sessionId){
            this.sessionId = sessionId;
        }

        public int GetSessionId(){
            return sessionId;
        }

        public void SetCustomerName(string customerName){
            this.customerName = customerName;
        }

        public string GetCustomerName(){
            return customerName;
        }

        public void SetCustomerEmail(string customerEmail){
            this.customerEmail = customerEmail;
        }

        public string GetCustomerEmail(){
            return customerEmail;
        }

        public void SetTrainingDate(string trainingDate){
            this.trainingDate = trainingDate;
        }

        public string GetTrainingDate(){
            return trainingDate;
        }

        public void SetTrainingId(int trainerID){
            this.trainerId = trainerID;
        }

        public int GetTrainingId(){
            return trainerId;
        }

        public void SetTrainerName(string trainerName){
            this.trainerName = trainerName;
        }

        public string GetTrainerName(){
            return trainerName;
        }

        public void SetSessionStatus(string sessionStatus){
            this.sessionStatus = sessionStatus;
        }

        public string GetSessionStatus(){
            return sessionStatus;
        }

        public override string ToString()
        {
            return $"Session Id: {sessionId}\tCustomer Name: {customerName}\tCustomer Email: {customerEmail}\tTraining Date: {trainingDate}\tTrainer Id: {trainerId}\tTrainer Name: {trainerName}\tSession Status: {sessionStatus}";
        }

        public string ToFile(){
            return $"{sessionId}#{customerName}#{customerEmail}#{trainingDate}#{trainerId}#{trainerName}#{sessionStatus}";
        }

    }
}