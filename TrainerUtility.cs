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

        static public void SetCount (int count){ // Trianer utility count used to store officail count
            TrainerUtility.count = count;
        }

        static public int GetCount (){
            return count;
        }

        static public void IncCount(){
            TrainerUtility.count ++;
        }

        public void GetAllTrainersFromFile(){ //Gets all file data and reads it in memory
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

        public void AddTrainer(){ // Allows you to add to current object array
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

        private void SaveTrainers(){ //Uses of the toFile method to store all Edited and Added data to file
            StreamWriter outFile = new StreamWriter("trainer.txt");

            for(int i = 0; i < TrainerUtility.GetCount(); i ++){
                outFile.WriteLine(trainer[i].ToFile());
            }
            
            outFile.Close();
        }

        public int Find(string searchVal){ //If the correct search Val will return 'i' value
            for(int i = 0; i < TrainerUtility.GetCount(); i++){
                if(trainer[i].GetTrainerName().ToUpper() == searchVal.ToUpper()){
                    return i;
                }
            }

            return -1;
        }

        public void UpdateTrainer(){ //Allows you to edit a current array
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

        public void DeleteTrainer(){//Allows you to soft delete a current array
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