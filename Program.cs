
//main
using System.Net.WebSockets;

DisplayMenu();
string choice = GetUserChoice();
    while (choice !="4"){
        RouteEm(choice);
        DisplayMenu();
        choice = GetUserChoice();
        
    }
Exit();


//end main



static void DisplayMenu(){
    System.Console.WriteLine("Click any key to continue");
    Console.ReadLine();
    Console.Clear();
    Random random = new Random();
    int randomRows = random.Next(8,13);
    System.Console.WriteLine("1. Display a plain topping-less pizza slice\n2. Display cheese pizza slice \n3. Display pepperoni pizza\n4. Exit");
}

static string GetUserChoice(){
    return Console.ReadLine();
}

static void RouteEm(string choice){
    

    switch(choice){
        case "1":
            PlainPizza();
            break;
        case "2":
            CheesePizza();
            break;
        case "3":
            PepperoniPizza();
            break;
        case "4":
            Exit();
            break;
        default:
            InvalidInput();
            break;

    }
    
}


static void PlainPizza(){
     Random random = new Random();
    int randomRows = random.Next(8,13);
    System.Console.WriteLine($"Plain pizza {randomRows}x12");

    for(int i = randomRows; i >= 1; i--){
        for(int j = 1; j <= i; j++){
        Console.Write(" * ");
        }
        System.Console.WriteLine();

    }
}

static void CheesePizza(){
    Random random = new Random();
    int randomRows = random.Next(8,13);
    System.Console.WriteLine($"Cheese pizza {randomRows}x12");

    for(int i = randomRows; i >= 1; i--){
        
        for(int j = 1; j <= i; j++){
        if(i == randomRows){
            System.Console.Write(" * ");
        }
         else if(j==1){
            Console.Write(" * ");
         }
        else if(j == i){
            Console.Write(" * ");
        }
        
        else{
        Console.Write(" # ");
        }
        }
        System.Console.WriteLine();
    }
}

static void PepperoniPizza(){
    Random random = new Random();
    int randomRows = random.Next(8,13);
    System.Console.WriteLine($"Cheese pizza {randomRows}x12");

    for(int i = randomRows; i >= 1; i--){
        
        for(int j = 1; j <= i; j++){
        if(i == randomRows){
            System.Console.Write(" * ");
        }
         else if(j==1){
            Console.Write(" * ");
         }
        else if(j == i){
            Console.Write(" * ");
        }

        else {
            int number = random.Next(2);
            if(number == 1)
            Console.Write(" [] ");
            else{
                Console.Write(" # ");
            }
        }
        
        }
        System.Console.WriteLine();
        }
       
    }

  




static void Exit(){
    System.Console.WriteLine("Goodbye!");
}

static void InvalidInput(){
    System.Console.WriteLine("Invalid Input");
}





