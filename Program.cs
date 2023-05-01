using mis_221_pa_5_rjord1;

Trainer[] trainer = new Trainer[100];

Listing[] listings = new Listing[100];

Booking[] bookings = new Booking[100];

Report[] reports = new Report[100];

// TrainerUtility utility = new TrainerUtility (trainer);
// TrainerReport report = new TrainerReport (trainer);
// ListingUtility Lutility = new ListingUtility (listings);
// ListingReport Lreport = new ListingReport (listings);
// BookingUtility Butility = new BookingUtility (bookings);

int userchoice = MainMenuSelection();
while(userchoice != 5){
            RouteChoice(userchoice, trainer, listings, bookings, reports);
            userchoice = MainMenuSelection();
            
        }
        if (userchoice == 5){
            ExitApp();
        }

static void MainMenu(){
    System.Console.WriteLine(@"
  _______        _         _      _ _                      _____ _                           _             
 |__   __|      (_)       | |    (_) |            /\      / ____| |                         (_)            
    | |_ __ __ _ _ _ __   | |     _| | _____     /  \    | |    | |__   __ _ _ __ ___  _ __  _  __ _ _ __  
    | | '__/ _` | | '_ \  | |    | | |/ / _ \   / /\ \   | |    | '_ \ / _` | '_ ` _ \| '_ \| |/ _` | '_ \ 
    | | | | (_| | | | | | | |____| |   <  __/  / ____ \  | |____| | | | (_| | | | | | | |_) | | (_| | | | |
    |_|_|  \__,_|_|_| |_| |______|_|_|\_\___| /_/    \_\  \_____|_| |_|\__,_|_| |_| |_| .__/|_|\__,_|_| |_|
                                                                                      | |                  
                                                                                      |_|                  
");
    System.Console.WriteLine("Select from the menu: \n1. Manage Trainer Data\n2. Manage Listing Data\n3. Manage Customer Booking Data\n4. Run System Reports\n5. Exit The Application");

}

static int MainMenuSelection(){
    Console.Clear();
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

static void RouteChoice(int userchoice, Trainer [] trainer, Listing [] listings, Booking [] bookings, Report [] reports){
    TrainerUtility utility = new TrainerUtility (trainer);
    TrainerReport report = new TrainerReport (trainer);
    ListingUtility Lutility = new ListingUtility (listings);
    ListingReport Lreport = new ListingReport (listings);
    BookingUtility Butility = new BookingUtility (bookings);
    BookingReport Breport = new BookingReport (listings, bookings);
    ReportUtility Rutility = new ReportUtility(reports);
    if(userchoice == 1){
        Console.Clear();
        System.Console.WriteLine(@"
 ____  ____   __   __  __ _  ____  ____    __  __ _  ____  __  ____  _  _   __  ____  __  __   __ _ 
(_  _)(  _ \ / _\ (  )(  ( \(  __)(  _ \  (  )(  ( \(  __)/  \(  _ \( \/ ) / _\(_  _)(  )/  \ (  ( \
  )(   )   //    \ )( /    / ) _)  )   /   )( /    / ) _)(  O ))   // \/ \/    \ )(   )((  O )/    /
 (__) (__\_)\_/\_/(__)\_)__)(____)(__\_)  (__)\_)__)(__)  \__/(__\_)\_)(_/\_/\_/(__) (__)\__/ \_)__)
");
        utility.GetAllTrainersFromFile();
        report.PrintAllTrainers();
        System.Console.WriteLine("1. Add New Trainer\n2. Edit Current Trainer\n3. Delete Trainer");
        System.Console.WriteLine("Enter -1 to return to main menu");
        int userSelection = int.Parse(Console.ReadLine());
        while(userSelection == 1 || userSelection == 2 || userSelection == 3 && userSelection != 1){
            if(userSelection == 1){
                Console.Clear();
                System.Console.WriteLine(@"
 ____  ____   __   __  __ _  ____  ____    __  __ _  ____  __  ____  _  _   __  ____  __  __   __ _ 
(_  _)(  _ \ / _\ (  )(  ( \(  __)(  _ \  (  )(  ( \(  __)/  \(  _ \( \/ ) / _\(_  _)(  )/  \ (  ( \
  )(   )   //    \ )( /    / ) _)  )   /   )( /    / ) _)(  O ))   // \/ \/    \ )(   )((  O )/    /
 (__) (__\_)\_/\_/(__)\_)__)(____)(__\_)  (__)\_)__)(__)  \__/(__\_)\_)(_/\_/\_/(__) (__)\__/ \_)__)
");
                report.PrintAllTrainers();
                utility.AddTrainer();
                Console.Clear();
                System.Console.WriteLine(@"
 ____  ____   __   __  __ _  ____  ____    __  __ _  ____  __  ____  _  _   __  ____  __  __   __ _ 
(_  _)(  _ \ / _\ (  )(  ( \(  __)(  _ \  (  )(  ( \(  __)/  \(  _ \( \/ ) / _\(_  _)(  )/  \ (  ( \
  )(   )   //    \ )( /    / ) _)  )   /   )( /    / ) _)(  O ))   // \/ \/    \ )(   )((  O )/    /
 (__) (__\_)\_/\_/(__)\_)__)(____)(__\_)  (__)\_)__)(__)  \__/(__\_)\_)(_/\_/\_/(__) (__)\__/ \_)__)
");
                report.PrintAllTrainers(); 
                System.Console.WriteLine("1. Add New Trainer\n2. Edit Current Trainer\n3. Delete Trainer");
                System.Console.WriteLine("Enter -1 to return to main menu");
                userSelection = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            if(userSelection == 2){
                Console.Clear();
                System.Console.WriteLine(@"
 ____  ____   __   __  __ _  ____  ____    __  __ _  ____  __  ____  _  _   __  ____  __  __   __ _ 
(_  _)(  _ \ / _\ (  )(  ( \(  __)(  _ \  (  )(  ( \(  __)/  \(  _ \( \/ ) / _\(_  _)(  )/  \ (  ( \
  )(   )   //    \ )( /    / ) _)  )   /   )( /    / ) _)(  O ))   // \/ \/    \ )(   )((  O )/    /
 (__) (__\_)\_/\_/(__)\_)__)(____)(__\_)  (__)\_)__)(__)  \__/(__\_)\_)(_/\_/\_/(__) (__)\__/ \_)__)
");
                report.PrintAllTrainers();
                utility.UpdateTrainer();
                Console.Clear();
                System.Console.WriteLine(@"
 ____  ____   __   __  __ _  ____  ____    __  __ _  ____  __  ____  _  _   __  ____  __  __   __ _ 
(_  _)(  _ \ / _\ (  )(  ( \(  __)(  _ \  (  )(  ( \(  __)/  \(  _ \( \/ ) / _\(_  _)(  )/  \ (  ( \
  )(   )   //    \ )( /    / ) _)  )   /   )( /    / ) _)(  O ))   // \/ \/    \ )(   )((  O )/    /
 (__) (__\_)\_/\_/(__)\_)__)(____)(__\_)  (__)\_)__)(__)  \__/(__\_)\_)(_/\_/\_/(__) (__)\__/ \_)__)
");
                report.PrintAllTrainers();
                System.Console.WriteLine("1. Add New Trainer\n2. Edit Current Trainer\n3. Delete Trainer");
                System.Console.WriteLine("Enter -1 to return to main menu");
                userSelection = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            if(userSelection == 3){
                Console.Clear();
                System.Console.WriteLine(@"
 ____  ____   __   __  __ _  ____  ____    __  __ _  ____  __  ____  _  _   __  ____  __  __   __ _ 
(_  _)(  _ \ / _\ (  )(  ( \(  __)(  _ \  (  )(  ( \(  __)/  \(  _ \( \/ ) / _\(_  _)(  )/  \ (  ( \
  )(   )   //    \ )( /    / ) _)  )   /   )( /    / ) _)(  O ))   // \/ \/    \ )(   )((  O )/    /
 (__) (__\_)\_/\_/(__)\_)__)(____)(__\_)  (__)\_)__)(__)  \__/(__\_)\_)(_/\_/\_/(__) (__)\__/ \_)__)
");
                report.PrintAllTrainers();
                utility.DeleteTrainer();
                Console.Clear();
                System.Console.WriteLine(@"
 ____  ____   __   __  __ _  ____  ____    __  __ _  ____  __  ____  _  _   __  ____  __  __   __ _ 
(_  _)(  _ \ / _\ (  )(  ( \(  __)(  _ \  (  )(  ( \(  __)/  \(  _ \( \/ ) / _\(_  _)(  )/  \ (  ( \
  )(   )   //    \ )( /    / ) _)  )   /   )( /    / ) _)(  O ))   // \/ \/    \ )(   )((  O )/    /
 (__) (__\_)\_/\_/(__)\_)__)(____)(__\_)  (__)\_)__)(__)  \__/(__\_)\_)(_/\_/\_/(__) (__)\__/ \_)__)
");
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
        System.Console.WriteLine(@"
  ___    __       __   __                 ___        ___                           __   __             
 |   |  |__.-----|  |_|__.-----.-----.   |   .-----.'  _.-----.----.--------.---.-|  |_|__.-----.-----.
 |.  |  |  |__ --|   _|  |     |  _  |   |.  |     |   _|  _  |   _|        |  _  |   _|  |  _  |     |
 |.  |__|__|_____|____|__|__|__|___  |   |.  |__|__|__| |_____|__| |__|__|__|___._|____|__|_____|__|__|
 |:  1   |                     |_____|   |:  |                                                         
 |::.. . |                               |::.|                                                         
 `-------'                               `---'                                                         
                                                                                                       
");
        Lutility.GetAllListingsFromFile();
        utility.GetAllTrainersFromFile();
        Lreport.PrintAllListingsFromFile();
        System.Console.WriteLine("1. Add New Listing\n2. Edit Current Listing\n3. Delete Current Listing");
        System.Console.WriteLine("Enter -1 to return to main menu");
        int userSelection = int.Parse(Console.ReadLine());
        while(userSelection == 1 || userSelection == 2 || userSelection == 3 && userSelection != 1){
            if(userSelection == 1){
                Console.Clear();
                System.Console.WriteLine(@"
  ___    __       __   __                 ___        ___                           __   __             
 |   |  |__.-----|  |_|__.-----.-----.   |   .-----.'  _.-----.----.--------.---.-|  |_|__.-----.-----.
 |.  |  |  |__ --|   _|  |     |  _  |   |.  |     |   _|  _  |   _|        |  _  |   _|  |  _  |     |
 |.  |__|__|_____|____|__|__|__|___  |   |.  |__|__|__| |_____|__| |__|__|__|___._|____|__|_____|__|__|
 |:  1   |                     |_____|   |:  |                                                         
 |::.. . |                               |::.|                                                         
 `-------'                               `---'                                                         
                                                                                                       
");
                System.Console.WriteLine("Current Listing...");
                Lreport.PrintAllListingsFromFile();
                System.Console.WriteLine("Current Trianers...");
                report.PrintAllTrainers();
                Lutility.AddListing(trainer);
                Console.Clear();
                System.Console.WriteLine(@"
  ___    __       __   __                 ___        ___                           __   __             
 |   |  |__.-----|  |_|__.-----.-----.   |   .-----.'  _.-----.----.--------.---.-|  |_|__.-----.-----.
 |.  |  |  |__ --|   _|  |     |  _  |   |.  |     |   _|  _  |   _|        |  _  |   _|  |  _  |     |
 |.  |__|__|_____|____|__|__|__|___  |   |.  |__|__|__| |_____|__| |__|__|__|___._|____|__|_____|__|__|
 |:  1   |                     |_____|   |:  |                                                         
 |::.. . |                               |::.|                                                         
 `-------'                               `---'                                                         
                                                                                                       
");
                Lreport.PrintAllListingsFromFile();
                System.Console.WriteLine("1. Add New Listing\n2. Edit Current Listing\n3. Delete Current Listing");
                System.Console.WriteLine("Enter -1 to return to main menu");
                userSelection = int.Parse(Console.ReadLine());
            }
            if(userSelection == 2){
                Console.Clear();
                System.Console.WriteLine(@"
  ___    __       __   __                 ___        ___                           __   __             
 |   |  |__.-----|  |_|__.-----.-----.   |   .-----.'  _.-----.----.--------.---.-|  |_|__.-----.-----.
 |.  |  |  |__ --|   _|  |     |  _  |   |.  |     |   _|  _  |   _|        |  _  |   _|  |  _  |     |
 |.  |__|__|_____|____|__|__|__|___  |   |.  |__|__|__| |_____|__| |__|__|__|___._|____|__|_____|__|__|
 |:  1   |                     |_____|   |:  |                                                         
 |::.. . |                               |::.|                                                         
 `-------'                               `---'                                                         
                                                                                                       
");
                Lreport.PrintAllListingsFromFile();
                Lutility.UpdateListings();
                Console.Clear();
                System.Console.WriteLine(@"
  ___    __       __   __                 ___        ___                           __   __             
 |   |  |__.-----|  |_|__.-----.-----.   |   .-----.'  _.-----.----.--------.---.-|  |_|__.-----.-----.
 |.  |  |  |__ --|   _|  |     |  _  |   |.  |     |   _|  _  |   _|        |  _  |   _|  |  _  |     |
 |.  |__|__|_____|____|__|__|__|___  |   |.  |__|__|__| |_____|__| |__|__|__|___._|____|__|_____|__|__|
 |:  1   |                     |_____|   |:  |                                                         
 |::.. . |                               |::.|                                                         
 `-------'                               `---'                                                         
                                                                                                       
");
                Lreport.PrintAllListingsFromFile();
                System.Console.WriteLine("1. Add New Listing\n2. Edit Current Listing\n3. Delete Current Listing");
                System.Console.WriteLine("Enter -1 to return to main menu");
                userSelection = int.Parse(Console.ReadLine());
            }
            if(userSelection == 3){
                Console.Clear();
                System.Console.WriteLine(@"
  ___    __       __   __                 ___        ___                           __   __             
 |   |  |__.-----|  |_|__.-----.-----.   |   .-----.'  _.-----.----.--------.---.-|  |_|__.-----.-----.
 |.  |  |  |__ --|   _|  |     |  _  |   |.  |     |   _|  _  |   _|        |  _  |   _|  |  _  |     |
 |.  |__|__|_____|____|__|__|__|___  |   |.  |__|__|__| |_____|__| |__|__|__|___._|____|__|_____|__|__|
 |:  1   |                     |_____|   |:  |                                                         
 |::.. . |                               |::.|                                                         
 `-------'                               `---'                                                         
                                                                                                       
");
                Lreport.PrintAllListingsFromFile();
                Lutility.DeleteListing();
                Console.Clear();
                System.Console.WriteLine(@"
  ___    __       __   __                 ___        ___                           __   __             
 |   |  |__.-----|  |_|__.-----.-----.   |   .-----.'  _.-----.----.--------.---.-|  |_|__.-----.-----.
 |.  |  |  |__ --|   _|  |     |  _  |   |.  |     |   _|  _  |   _|        |  _  |   _|  |  _  |     |
 |.  |__|__|_____|____|__|__|__|___  |   |.  |__|__|__| |_____|__| |__|__|__|___._|____|__|_____|__|__|
 |:  1   |                     |_____|   |:  |                                                         
 |::.. . |                               |::.|                                                         
 `-------'                               `---'                                                         
                                                                                                       
");
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
        Console.Clear();
        System.Console.WriteLine(@"
    ____              __   _                ____      ____                           __  _           
   / __ )____  ____  / /__(_)___  ____ _   /  _/___  / __/___  _________ ___  ____ _/ /_(_)___  ____ 
  / __  / __ \/ __ \/ //_/ / __ \/ __ `/   / // __ \/ /_/ __ \/ ___/ __ `__ \/ __ `/ __/ / __ \/ __ \
 / /_/ / /_/ / /_/ / ,< / / / / / /_/ /  _/ // / / / __/ /_/ / /  / / / / / / /_/ / /_/ / /_/ / / / /
/_____/\____/\____/_/|_/_/_/ /_/\__, /  /___/_/ /_/_/  \____/_/  /_/ /_/ /_/\__,_/\__/_/\____/_/ /_/ 
                               /____/                                                                
");
        Lutility.GetAllListingsFromFile();
        Butility.GetAllBookingsFromFile(bookings);
        System.Console.WriteLine("Sessions Booked....");
        BookingReport.PrintAllBookings(bookings);
        System.Console.WriteLine("1. Veiw All Avaliable Sessions\n2. Book A Session\n3. Edit Session Status\nEnter -1 to return to main menu");
        int userSelection = int.Parse(Console.ReadLine());
        while(userSelection == 1 || userSelection == 2 || userSelection == 3 && userSelection != 1){
            if(userSelection == 1){
                Console.Clear();
                System.Console.WriteLine(@"
    ____              __   _                ____      ____                           __  _           
   / __ )____  ____  / /__(_)___  ____ _   /  _/___  / __/___  _________ ___  ____ _/ /_(_)___  ____ 
  / __  / __ \/ __ \/ //_/ / __ \/ __ `/   / // __ \/ /_/ __ \/ ___/ __ `__ \/ __ `/ __/ / __ \/ __ \
 / /_/ / /_/ / /_/ / ,< / / / / / /_/ /  _/ // / / / __/ /_/ / /  / / / / / / /_/ / /_/ / /_/ / / / /
/_____/\____/\____/_/|_/_/_/ /_/\__, /  /___/_/ /_/_/  \____/_/  /_/ /_/ /_/\__,_/\__/_/\____/_/ /_/ 
                               /____/                                                                
");
                BookingReport.PrintAllAvailableSessions(listings);
                System.Console.WriteLine("1. Veiw All Avaliable Sessions\n2. Book A Session\n3. Edit Session Status\nEnter -1 to return to main menu");
                userSelection = int.Parse(Console.ReadLine());
            }
            if(userSelection == 2){
                Console.Clear();
                System.Console.WriteLine(@"
    ____              __   _                ____      ____                           __  _           
   / __ )____  ____  / /__(_)___  ____ _   /  _/___  / __/___  _________ ___  ____ _/ /_(_)___  ____ 
  / __  / __ \/ __ \/ //_/ / __ \/ __ `/   / // __ \/ /_/ __ \/ ___/ __ `__ \/ __ `/ __/ / __ \/ __ \
 / /_/ / /_/ / /_/ / ,< / / / / / /_/ /  _/ // / / / __/ /_/ / /  / / / / / / /_/ / /_/ / /_/ / / / /
/_____/\____/\____/_/|_/_/_/ /_/\__, /  /___/_/ /_/_/  \____/_/  /_/ /_/ /_/\__,_/\__/_/\____/_/ /_/ 
                               /____/                                                                
");
                BookingReport.PrintAllAvailableSessions(listings);
                Butility.BookASession(listings, trainer);
                Console.Clear();
                System.Console.WriteLine(@"
    ____              __   _                ____      ____                           __  _           
   / __ )____  ____  / /__(_)___  ____ _   /  _/___  / __/___  _________ ___  ____ _/ /_(_)___  ____ 
  / __  / __ \/ __ \/ //_/ / __ \/ __ `/   / // __ \/ /_/ __ \/ ___/ __ `__ \/ __ `/ __/ / __ \/ __ \
 / /_/ / /_/ / /_/ / ,< / / / / / /_/ /  _/ // / / / __/ /_/ / /  / / / / / / /_/ / /_/ / /_/ / / / /
/_____/\____/\____/_/|_/_/_/ /_/\__, /  /___/_/ /_/_/  \____/_/  /_/ /_/ /_/\__,_/\__/_/\____/_/ /_/ 
                               /____/                                                                
");
                System.Console.WriteLine("Sessions Booked....");
                BookingReport.PrintAllBookings(bookings);
                System.Console.WriteLine("1. Veiw All Avaliable Sessions\n2. Book A Session\n3. Edit Session Status\nEnter -1 to return to main menu");
                userSelection = int.Parse(Console.ReadLine());
            }
            if(userSelection == 3){
                Console.Clear();
                System.Console.WriteLine(@"
    ____              __   _                ____      ____                           __  _           
   / __ )____  ____  / /__(_)___  ____ _   /  _/___  / __/___  _________ ___  ____ _/ /_(_)___  ____ 
  / __  / __ \/ __ \/ //_/ / __ \/ __ `/   / // __ \/ /_/ __ \/ ___/ __ `__ \/ __ `/ __/ / __ \/ __ \
 / /_/ / /_/ / /_/ / ,< / / / / / /_/ /  _/ // / / / __/ /_/ / /  / / / / / / /_/ / /_/ / /_/ / / / /
/_____/\____/\____/_/|_/_/_/ /_/\__, /  /___/_/ /_/_/  \____/_/  /_/ /_/ /_/\__,_/\__/_/\____/_/ /_/ 
                               /____/                                                                
");
                BookingReport.PrintAllBookings(bookings);
                Butility.ChangeBookingStatus();
                Console.Clear();
                System.Console.WriteLine(@"
    ____              __   _                ____      ____                           __  _           
   / __ )____  ____  / /__(_)___  ____ _   /  _/___  / __/___  _________ ___  ____ _/ /_(_)___  ____ 
  / __  / __ \/ __ \/ //_/ / __ \/ __ `/   / // __ \/ /_/ __ \/ ___/ __ `__ \/ __ `/ __/ / __ \/ __ \
 / /_/ / /_/ / /_/ / ,< / / / / / /_/ /  _/ // / / / __/ /_/ / /  / / / / / / /_/ / /_/ / /_/ / / / /
/_____/\____/\____/_/|_/_/_/ /_/\__, /  /___/_/ /_/_/  \____/_/  /_/ /_/ /_/\__,_/\__/_/\____/_/ /_/ 
                               /____/                                                                
");
                System.Console.WriteLine("Session Status Changed...");
                BookingReport.PrintAllBookings(bookings);
                System.Console.WriteLine("1. Veiw All Avaliable Sessions\n2. Book A Session\n3. Edit Session Status\nEnter -1 to return to main menu");
                userSelection = int.Parse(Console.ReadLine());
            }

        }
        if(userSelection == -1){
            System.Console.WriteLine("Back to main menu...");
        }
    }
    if(userchoice == 4){
        Console.Clear();
        System.Console.WriteLine(@"
 ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄ 
▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌
▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌ ▀▀▀▀█░█▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ 
▐░▌       ▐░▌▐░▌          ▐░▌       ▐░▌▐░▌       ▐░▌▐░▌       ▐░▌     ▐░▌     ▐░▌          
▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄█░▌▐░▌       ▐░▌▐░█▄▄▄▄▄▄▄█░▌     ▐░▌     ▐░█▄▄▄▄▄▄▄▄▄ 
▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌       ▐░▌▐░░░░░░░░░░░▌     ▐░▌     ▐░░░░░░░░░░░▌
▐░█▀▀▀▀█░█▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌       ▐░▌▐░█▀▀▀▀█░█▀▀      ▐░▌      ▀▀▀▀▀▀▀▀▀█░▌
▐░▌     ▐░▌  ▐░▌          ▐░▌          ▐░▌       ▐░▌▐░▌     ▐░▌       ▐░▌               ▐░▌
▐░▌      ▐░▌ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌          ▐░█▄▄▄▄▄▄▄█░▌▐░▌      ▐░▌      ▐░▌      ▄▄▄▄▄▄▄▄▄█░▌
▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░▌          ▐░░░░░░░░░░░▌▐░▌       ▐░▌     ▐░▌     ▐░░░░░░░░░░░▌
 ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀            ▀▀▀▀▀▀▀▀▀▀▀  ▀         ▀       ▀       ▀▀▀▀▀▀▀▀▀▀▀ 
                                                                                           
");
        Lutility.GetAllListingsFromFile();
        Butility.GetAllBookingsFromFile(bookings);
        System.Console.WriteLine("Which Report would you like to view? Select from the menu below:");
        System.Console.WriteLine("1. Individual Customer Report\n2. Historical Customer Report\n3. Historical Revenue Report");
        System.Console.WriteLine("Enter -1 to return to main menu");
        int userSelection = int.Parse(Console.ReadLine());
        while(userSelection == 1 || userSelection == 2 || userSelection == 3 && userSelection != 1){
            if(userSelection == 1){
                Console.Clear();
                System.Console.WriteLine(@"
 ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄ 
▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌
▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌ ▀▀▀▀█░█▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ 
▐░▌       ▐░▌▐░▌          ▐░▌       ▐░▌▐░▌       ▐░▌▐░▌       ▐░▌     ▐░▌     ▐░▌          
▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄█░▌▐░▌       ▐░▌▐░█▄▄▄▄▄▄▄█░▌     ▐░▌     ▐░█▄▄▄▄▄▄▄▄▄ 
▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌       ▐░▌▐░░░░░░░░░░░▌     ▐░▌     ▐░░░░░░░░░░░▌
▐░█▀▀▀▀█░█▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌       ▐░▌▐░█▀▀▀▀█░█▀▀      ▐░▌      ▀▀▀▀▀▀▀▀▀█░▌
▐░▌     ▐░▌  ▐░▌          ▐░▌          ▐░▌       ▐░▌▐░▌     ▐░▌       ▐░▌               ▐░▌
▐░▌      ▐░▌ ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌          ▐░█▄▄▄▄▄▄▄█░▌▐░▌      ▐░▌      ▐░▌      ▄▄▄▄▄▄▄▄▄█░▌
▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░▌          ▐░░░░░░░░░░░▌▐░▌       ▐░▌     ▐░▌     ▐░░░░░░░░░░░▌
 ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀            ▀▀▀▀▀▀▀▀▀▀▀  ▀         ▀       ▀       ▀▀▀▀▀▀▀▀▀▀▀ 
                                                                                           
");
                System.Console.WriteLine("Current Sessions...");
                BookingReport.PrintAllBookings(bookings);
                Rutility.IndividualCustomerReport();
                System.Console.WriteLine("1. Individual Customer Report\n2. Historical Customer Report\n3. Historical Revenue Report");
                System.Console.WriteLine("Enter -1 to return to main menu");
                userSelection = int.Parse(Console.ReadLine());
            }
            if(userSelection == 2){

            }
            if(userSelection == 3){

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