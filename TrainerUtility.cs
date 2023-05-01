using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis_221_pa_5_rjord1
{
    public class TrainerUtility
    {
        static int MAX_IDCOUNT = 100;
        private Trainer [] trainer = new Trainer[MAX_IDCOUNT];

        static public int count;

        public TrainerUtility(Trainer [] trainer){
            this.trainer = trainer;
        }

        static public void SetCount (int count){
            TrainerUtility.count = count;
        }

        static public int GetCount (){
            return count;
        }

        static public void IncCount(){
            TrainerUtility.count ++;
        }

        // public void GetAllTrainers(){
        //     Trainer.SetCount(0);
        //     System.Console.WriteLine("Please enter Trainer Name. Enter stop to stop.");
        //     string userInput = Console.ReadLine();
        //     while(userInput.ToUpper() != "STOP"){
        //         trainer[Trainer.GetCount()] = new Trainer();
        //         trainer[Trainer.GetCount()].SetTrainerName(userInput);
        //         System.Console.WriteLine("Please enter the Mailing Address.");
        //         trainer[Trainer.GetCount()].SetTrainerMailing(Console.ReadLine());
        //         System.Console.WriteLine("Please enter the Email.");
        //         trainer[Trainer.GetCount()].SetTrainerEmail(Console.ReadLine());
        //         // trainer[Trainer.GetCount()].SetTrainerId(++)
        //         Trainer.IncCount();

                
        //         System.Console.WriteLine("Please enter Trainer Name. Enter stop to stop.");
        //         userInput = Console.ReadLine();
        //     }
        // }

        public void GetAllTrainersFromFile(){
            StreamReader inFile = new StreamReader("trainer.txt");

            TrainerUtility.SetCount(0);
            string line = inFile.ReadLine();
            while(line != null){
                string [] temp = line.Split('#');
                trainer[TrainerUtility.GetCount()] = new Trainer(int.Parse(temp[0]),temp[1],temp[2],temp[3],bool.Parse(temp[4]));
                TrainerUtility.IncCount();
                line = inFile.ReadLine();
            }

            inFile.Close();


        }

        public void AddTrainer(){
            System.Console.WriteLine("Please enter the trainer name:");
            Trainer newTrainer = new Trainer();
            // newTrainer.SetTrainerId(true);
            newTrainer.SetTrainerName(Console.ReadLine());
            System.Console.WriteLine("Please enter the trainer mailing address:");
            newTrainer.SetTrainerMailing(Console.ReadLine());
            System.Console.WriteLine("Please enter the trainer email address:");
            newTrainer.SetTrainerEmail(Console.ReadLine());
            newTrainer.SetActive(true);
            newTrainer.SetTrainerId(TrainerUtility.GetCount());
            trainer[TrainerUtility.GetCount()] = newTrainer;
            TrainerUtility.IncCount();

            SaveTrainers();
        }

        private void SaveTrainers(){
            StreamWriter outFile = new StreamWriter("trainer.txt");

            for(int i = 0; i < TrainerUtility.GetCount(); i ++){
                outFile.WriteLine(trainer[i].ToFile());
            }
            
            outFile.Close();
        }

        public int Find(string searchVal){
            for(int i = 0; i < TrainerUtility.GetCount(); i++){
                if(trainer[i].GetTrainerName().ToUpper() == searchVal.ToUpper()){
                    return i;
                }
            }

            return -1;
        }

        public void UpdateTrainer(){
            System.Console.WriteLine("What is the name of the trainer you want to edit?");
            string searchVal = Console.ReadLine();
            int foundIndex = Find(searchVal);

            if(foundIndex != -1){
            System.Console.WriteLine("Please enter the trainer name:");
            trainer[foundIndex].SetTrainerName(Console.ReadLine());
            System.Console.WriteLine("Please enter the trainer mailing address:");
            trainer[foundIndex].SetTrainerMailing(Console.ReadLine());
            System.Console.WriteLine("Please enter the trainer email address:");
            trainer[foundIndex].SetTrainerEmail(Console.ReadLine());

            SaveTrainers();
            }

            else{
                System.Console.WriteLine("Trainer not found!");
            }
        }

        public void DeleteTrainer(){
            System.Console.WriteLine("What is the name of the trainer you would like to delete?");
            string searchVal = Console.ReadLine();
            int foundIndex = Find(searchVal);

            if(foundIndex != -1){
                
                trainer[foundIndex].SetNotActive(true);

                SaveTrainers();
            }

            else{
                System.Console.WriteLine("Trainer not found!");
            }
            
        }
    }
}