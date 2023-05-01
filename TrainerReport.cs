namespace mis_221_pa_5_rjord1
{
    public class TrainerReport
    {
        Trainer [] trainers;

        public TrainerReport(Trainer[] trainers){
            this.trainers = trainers;
        }

        public void PrintAllTrainers(){ //Gets all trianers from file that are active and prints to ToString
            for(int i = 0; i < TrainerUtility.GetCount(); i++){
                if(trainers[i].GetActive() == true){
                    System.Console.WriteLine(trainers[i].ToString());
                }

            }
        }
    }
}