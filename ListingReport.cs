using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis_221_pa_5_rjord1
{
    public class ListingReport
    {
        Listing [] listings;

        public ListingReport(Listing[] listings){
            this.listings = listings;
        }

        public void PrintAllListingsFromFile(){
            for(int i = 0; i < ListingUtility.GetCount(); i++){
                if(listings[i].GetActive() == true){
                    System.Console.WriteLine(listings[i].ToString());
                }

            }
        }
    }
}