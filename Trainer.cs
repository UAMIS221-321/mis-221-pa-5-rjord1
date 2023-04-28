using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis_221_pa_5_rjord1
{
    public class Trainer
    {
        private int trainerId;
        private string trainerName;
        private string trainerMailing;
        private string trainerEmail;
        private bool active;
        static private int ID;

        static private int count;


        public Trainer(){

        }

        public Trainer(int trainerId, string trainerName, string trainerMailing, string trainerEmail, bool active){
            this.trainerId = ID;
            ID++;
            this.trainerName = trainerName;
            this.trainerMailing = trainerMailing;
            this.trainerEmail = trainerEmail;
            this.active = active;

        }

        public void SetTrainerId(bool rrainerId){
            this.trainerId = trainerId;
        }

        

        public int GetTrainerId(){
            return trainerId;
        }

        public void SetTrainerName(string trainerName){
            this.trainerName = trainerName;
        }

        public string GetTrainerName(){
            return trainerName;
        }

        public void SetTrainerMailing(string trainerMailing){
            this.trainerMailing = trainerMailing;
        }

        public string GetTrainerMailing(){
            return trainerMailing;
        }

        public void SetTrainerEmail(string trainerEmail){
            this.trainerEmail = trainerEmail;
        }

        public string GetTrainerEmail(){
            return trainerEmail;
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
            return $"- Trainer name: {trainerName}\tTrainer mailing address: {trainerMailing}\tTrainer email: {trainerEmail}\tTrainer ID number: {trainerId}";
        }

        public string ToFile(){
            return $"{trainerId}#{trainerName}#{trainerMailing}#{trainerEmail}#{active}";
        }


    }
}

