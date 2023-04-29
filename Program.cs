using mis_221_pa_5_rjord1;

Trainer[] trainer = new Trainer[100];

Listing[] listings = new Listing[100];

Booking[] bookings = new Booking[100];

// TrainerUtility utility = new TrainerUtility (trainer);
// TrainerReport report = new TrainerReport (trainer);
// ListingUtility Lutility = new ListingUtility (listings);
// ListingReport Lreport = new ListingReport (listings);
// BookingUtility Butility = new BookingUtility (bookings);

int userchoice = MainMenuSelection();
while(userchoice != 5){
            RouteChoice(userchoice, trainer, listings, bookings);
            userchoice = MainMenuSelection();
            
        }
        if (userchoice == 5){
            ExitApp();
        }

static void MainMenu(){
    System.Console.WriteLine("Welcome to Train Like a Champian Trainer Booking System!");
    System.Console.WriteLine("Select from the menu: \n1. Manage Trainer Data\n2. Manage Listing Data\n3. Manage Customer Booking Data\n4. Run System Reports\n5. Exit The Application");

}

static int MainMenuSelection(){
    MainMenu();
    int userchoice = int.Parse(Console.ReadLine());
    if (ValidMenuChoice(userchoice)){
            return (userchoice);
        }
        else return 0;
}

static bool ValidMenuChoice(int userchoice){ // Is valid check method
    if (userchoice == 1||userchoice == 2|| userchoice ==3 || userchoice == 4 || userchoice == 5) {
        return true;
    }
    else return false;

}

static void ExitApp(){
        System.Console.WriteLine("GoodBye!");
    }

static void Invalid(){
        System.Console.WriteLine("Wrong entry. Pick again from the menu");
}

static void RouteChoice(int userchoice, Trainer [] trainer, Listing [] listings, Booking [] bookings){
    TrainerUtility utility = new TrainerUtility (trainer);
    TrainerReport report = new TrainerReport (trainer);
    ListingUtility Lutility = new ListingUtility (listings);
    ListingReport Lreport = new ListingReport (listings);
    BookingUtility Butility = new BookingUtility (bookings);
    BookingReport Breport = new BookingReport (listings, bookings);
    if(userchoice == 1){
        Console.Clear();
        System.Console.WriteLine("Here you have Access to all trainer date.\nSelect from the menu below:");
        utility.GetAllTrainersFromFile();
        report.PrintAllTrainers();
        System.Console.WriteLine("1. Add New Trainer\n2. Edit Current Trainer\n3. Delete Trainer");
        System.Console.WriteLine("Enter -1 to return to main menu");
        int userSelection = int.Parse(Console.ReadLine());
        while(userSelection == 1 || userSelection == 2 || userSelection == 3 && userSelection != 1){
            if(userSelection == 1){
                Console.Clear();
                report.PrintAllTrainers();
                utility.AddTrainer();
                Console.Clear();
                report.PrintAllTrainers(); 
                System.Console.WriteLine("1. Add New Trainer\n2. Edit Current Trainer\n3. Delete Trainer");
                System.Console.WriteLine("Enter -1 to return to main menu");
                userSelection = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            if(userSelection == 2){
                Console.Clear();
                report.PrintAllTrainers();
                utility.UpdateTrainer();
                Console.Clear();
                report.PrintAllTrainers();
                System.Console.WriteLine("1. Add New Trainer\n2. Edit Current Trainer\n3. Delete Trainer");
                System.Console.WriteLine("Enter -1 to return to main menu");
                userSelection = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            if(userSelection == 3){
                Console.Clear();
                report.PrintAllTrainers();
                utility.DeleteTrainer();
                Console.Clear();
                report.PrintAllTrainers();
                System.Console.WriteLine("1. Add New Trainer\n2. Edit Current Trainer\n3. Delete Trainer");
                System.Console.WriteLine("Enter -1 to return to main menu");
                userSelection = int.Parse(Console.ReadLine());
                Console.Clear();
            }
        }
        if(userSelection == -1){
            System.Console.WriteLine("Back to main menu...");
        }
    }
    if(userchoice == 2){
        Console.Clear();
        System.Console.WriteLine("Here you have Access to all listing date.\nSelect from the menu below:");
        Lutility.GetAllListingsFromFile();
        utility.GetAllTrainersFromFile();
        Lreport.PrintAllListingsFromFile();
        System.Console.WriteLine("1. Add New Listing\n2. Edit Current Listing\n3. Delete Current Listing");
        System.Console.WriteLine("Enter -1 to return to main menu");
        int userSelection = int.Parse(Console.ReadLine());
        while(userSelection == 1 || userSelection == 2 || userSelection == 3 && userSelection != 1){
            if(userSelection == 1){
                Console.Clear();
                System.Console.WriteLine("Current Listing...");
                Lreport.PrintAllListingsFromFile();
                System.Console.WriteLine("Current Trianers...");
                report.PrintAllTrainers();
                Lutility.AddListing(trainer);
                Console.Clear();
                Lreport.PrintAllListingsFromFile();
                System.Console.WriteLine("1. Add New Listing\n2. Edit Current Listing\n3. Delete Current Listing");
                System.Console.WriteLine("Enter -1 to return to main menu");
                userSelection = int.Parse(Console.ReadLine());
            }
            if(userSelection == 2){
                Console.Clear();
                Lreport.PrintAllListingsFromFile();
                Lutility.UpdateListings();
                Console.Clear();
                Lreport.PrintAllListingsFromFile();
                System.Console.WriteLine("1. Add New Listing\n2. Edit Current Listing\n3. Delete Current Listing");
                System.Console.WriteLine("Enter -1 to return to main menu");
                userSelection = int.Parse(Console.ReadLine());
            }
            if(userSelection == 3){
                Console.Clear();
                Lreport.PrintAllListingsFromFile();
                Lutility.DeleteListing();
                Console.Clear();
                Lreport.PrintAllListingsFromFile();
                System.Console.WriteLine("1. Add New Listing\n2. Edit Current Listing\n3. Delete Current Listing");
                System.Console.WriteLine("Enter -1 to return to main menu");
                userSelection = int.Parse(Console.ReadLine());
            }

        }
        if(userSelection == -1){
            System.Console.WriteLine("Back to main menu...");
        }
    }
    if(userchoice == 3){
        System.Console.WriteLine("Here you have Access to all booking date.\nSelect from the menu below:");
        Lutility.GetAllListingsFromFile();
        System.Console.WriteLine("1. Veiw All Avaliable Sessions\n2. Book A Session\nEnter -1 to return to main menu");
        int userSelection = int.Parse(Console.ReadLine());
        while(userSelection == 1 || userSelection == 2 && userSelection != 1){
            if(userSelection == 1){
                Console.Clear();
                BookingReport.PrintAllAvailableSessions(listings);
                System.Console.WriteLine("1. Veiw All Avaliable Sessions\n2. Book A Session\nEnter -1 to return to main menu");
                userSelection = int.Parse(Console.ReadLine());
            }
            if(userSelection == 2){
                Console.Clear();
                BookingReport.PrintAllAvailableSessions(listings);
                Butility.BookASession(listings, trainer);
                Console.Clear();
                System.Console.WriteLine("Sessions Booked....");
                BookingReport.PrintAllBookings(bookings);
                System.Console.WriteLine("1. Veiw All Avaliable Sessions\n2. Book A Session\nEnter -1 to return to main menu");
                userSelection = int.Parse(Console.ReadLine());
            }
        }
        if(userSelection == -1){
            System.Console.WriteLine("Back to main menu...");
        }
    }
    if(userchoice == 4){
        System.Console.WriteLine("Which Report would you like tp view? Select from the menu below:");
        System.Console.WriteLine("1. Individual Customer Report\n 2. Historical Customer Report\n 3. Historical Revenue Report");
        System.Console.WriteLine("Enter -1 to return to main menu");
        int userSelection = int.Parse(Console.ReadLine());
        while(userSelection == 1 || userSelection == 2 || userSelection == 3 && userSelection != 1){
            if(userchoice == 1){

            }
            if(userchoice == 2){

            }
            if(userchoice == 3){

            }
        }
        if(userSelection == -1){
            System.Console.WriteLine("Back to main menu...");
        }
    }
    else if (userchoice != 1 && userchoice !=2 && userchoice != 3 && userchoice != 4 && userchoice != 5){
        Invalid();
    }

}


// BookingReport Breport = new BookingReport (listings, bookings);

// utility.GetAllTrainersFromFile();
// report.PrintAllTrainers();

// System.Console.WriteLine("Add a new trainer..");

// utility.AddTrainer();
// report.PrintAllTrainers();

// utility.UpdateTrainer();
// report.PrintAllTrainers();

// utility.DeleteTrainer();
// report.PrintAllTrainers();

// Lutility.GetAllListingsFromFile();
// Lreport.PrintAllListingsFromFile();

// System.Console.WriteLine("Add a new listing...");

// Lutility.AddListing();
// Lreport.PrintAllListingsFromFile();

// Lutility.UpdateListings();
// Lreport.PrintAllListingsFromFile();

// Lutility.DeleteListing();
// Lreport.PrintAllListingsFromFile();

// Breport.PrintAllAvailableSessions();

// Butility.BookASession();
// Breport.PrintAllBookings();



// BookingReport.PrintAllAvailableSessions(listings);

// Butility.BookASession(listings, trainer);
// Butility.GetAllBookingsFromFile(bookings);
// BookingReport.PrintAllBookings(bookings);