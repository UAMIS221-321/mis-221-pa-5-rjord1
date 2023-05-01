
namespace mis_221_pa_5_rjord1
{
    public class Report
    {
        private string customerEmail;
        private string customerName;
        private int totalNumberOfSessions;
        private int revenue;

        public Report(){

        }

        public Report(string customerEmail, string customerNAme, int totalNumberOfSessions, int revenue){
            this.customerEmail = customerEmail;
            this.customerName = customerNAme;
            this.totalNumberOfSessions = totalNumberOfSessions;
            this.revenue = revenue;
        }

        public void SetCustomerEmail(){
            this.customerEmail = customerEmail;
        }

        public string GetCustomerEmail(string customerEmail){
            return customerEmail;
        }
        public void SetCustomerName(){
            this.customerName = customerName;
        }

        public string GetCustomerName(string customerName){
            return customerName;
        }

        public void SetTotalNumberOfSessions(){
            this.totalNumberOfSessions = totalNumberOfSessions;
        }
        public int GetTotalNumberOfSessions(){
            return totalNumberOfSessions;
        }

        public void SetRevenue(){
            this.revenue = revenue;
        }
        public int GetRevenue(){
            return revenue;
        }

        // public override string ToString()
        // {
        //     return 
        // }




    }
}