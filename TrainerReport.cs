namespace mis_221_pa_5_rjord1
{
    public class TrainerReport
    {
        Trainer [] trainers;

        public TrainerReport(Trainer[] trainers){
            this.trainers = trainers;
        }

        public void PrintAllTrainers(){
            for(int i = 0; i < TrainerUtility.GetCount(); i++){
                if(trainers[i].GetActive() == true){
                    System.Console.WriteLine(trainers[i].ToString());
                }

            }
        }
    }
}