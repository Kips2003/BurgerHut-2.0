namespace BurgerHut.Classes{
    public class RunProgram{
        public static void Run(){
///////////////////////////////////////////////
            Console.Clear();
            
            System.Console.WriteLine(
                "******** WELCOME TO BURGERHUT ********"
            );
            System.Console.WriteLine(
                "      press any key to continue"
            );
            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();
/////////////////////////////////////////////////

            System.Console.WriteLine(
                "******** Menu ********"
            );
            System.Console.WriteLine(
                "1.Hamburger \n2.Cheeseburger \n3.Day Special \n4.Special Order"    
            );
            System.Console.WriteLine();

            System.Console.WriteLine(
                "Choose your order by pressing number"
            );
            char pickedNumber = '0';;
            while(pickedNumber!='1' && pickedNumber != '2'&& pickedNumber != '3' && pickedNumber != '4'){
                key = Console.ReadKey();
                pickedNumber = key.KeyChar;
                System.Console.WriteLine();
                if(pickedNumber!='1' && pickedNumber != '2'&& pickedNumber != '3' && pickedNumber != '4'){
                    System.Console.WriteLine("You Pressed the wrong number \n Try Again!");
                }
            }
            Console.Clear();
//////////////////////////////////////////////////////////////////   

            Burger burger;

            switch(pickedNumber){
                case '1':
                    burger = new Hamburger();
                    System.Console.WriteLine(burger.ToString());
                    return;
                case '2':
                    burger = new Cheeseburger();
                    System.Console.WriteLine(burger.ToString());
                    return;
                case '3':
                    burger = new DaySpecial();
                    System.Console.WriteLine(burger.ToString());
                    return;
                case '4':
                    burger = new SpecialOrder();
                    System.Console.WriteLine(burger.ToString());
                    return;
                    
            }
        }
    }
}