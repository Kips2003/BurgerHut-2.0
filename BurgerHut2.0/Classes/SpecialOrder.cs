using BurgerHut.Enum;


namespace BurgerHut.Classes{
    public class SpecialOrder:Burger{
        Burger burger = new Burger();
        BurgerBuilder burgerBuilder = new BurgerBuilder();

        void MakeSpecialOrder(){
            burger = burgerBuilder
            .Start()
            .WithBun()
            .WithLattuce()
            .Build();

            ConsoleKeyInfo key;
            char pickedNumber = '0';
            System.Console.WriteLine("******* Building Burger *******");

            System.Console.WriteLine("Cheese?\n1.Yes\n2.No\n(press the number)");
            while(pickedNumber != '1' && pickedNumber != '2'){
                key = Console.ReadKey();
                pickedNumber = key.KeyChar;
                System.Console.WriteLine();
                if(pickedNumber!='1' && pickedNumber != '2'){
                    System.Console.WriteLine("You Pressed the wrong number \n Try Again!");
                }
                else{
                    if(pickedNumber == '1'){
                        burger = burgerBuilder
                        .WithCheese()
                        .Build();
                    }
                }
            }
            Console.Clear();

/////////////////////////////////////////////////////////////
            pickedNumber = '0';
            System.Console.WriteLine("******* Building Burger *******");


            System.Console.WriteLine("Pickle?\n1.Yes\n2.No\n(press the number)");
            while(pickedNumber != '1' && pickedNumber != '2'){
                key = Console.ReadKey();
                pickedNumber = key.KeyChar;
                System.Console.WriteLine();
                if(pickedNumber!='1' && pickedNumber != '2'){
                    System.Console.WriteLine("You Pressed the wrong number \n Try Again!");
                }
                else{
                    if(pickedNumber == '1'){
                        burger = burgerBuilder
                        .WithPickle()
                        .Build();
                    }
                }
            }
            Console.Clear();

//////////////////////////////////////////////////////////////////////
            pickedNumber = '0';
            int MeetInInt = -1;
            System.Console.WriteLine("******* Building Burger *******");

            System.Console.WriteLine("Which kind of Meet?\n1.Chicken\n2.Beed\n3.None\n(press the number)"); 
            while(pickedNumber != '1' && pickedNumber != '2' && pickedNumber != '3'){
                key = Console.ReadKey();
                pickedNumber = key.KeyChar;
                System.Console.WriteLine();
                if(pickedNumber!='1' && pickedNumber != '2' && pickedNumber != '3'){
                    System.Console.WriteLine("You Pressed the wrong number \n Try Again!");
                }
                else{
                    MeetInInt = Convert.ToInt32(pickedNumber)-48;
                    burger = burgerBuilder
                    .WhichKindOfMeet(MeetInInt)
                    .Build();
                }
            }
            Console.Clear();

/////////////////////////////////////////////////////////////////////////////////
            pickedNumber = '0';
            int SauceInInt = -1;
            System.Console.WriteLine("******* Building Burger *******");

            System.Console.WriteLine("Which kind of Sauce?\n1.Hot Sauce\n2.Sweet Sauce\n3.Special Sauce\n4.None\n(press the number)"); 
            while(pickedNumber != '1' && pickedNumber != '2' && pickedNumber != '3' && pickedNumber !='4'){
                key = Console.ReadKey();
                pickedNumber = key.KeyChar;
                System.Console.WriteLine();
                if(pickedNumber!='1' && pickedNumber != '2' && pickedNumber != '3' && pickedNumber != '4'){
                    System.Console.WriteLine("You Pressed the wrong number \n Try Again!");
                }
                else{
                    SauceInInt = Convert.ToInt32(pickedNumber)-48;
                    burger = burgerBuilder
                    .WhichKindOfSauce(SauceInInt)
                    .Build();
                }
            }

            Console.Clear();
        }

        public override string ToString(){
            MakeSpecialOrder();

            string? bun = null;
            if(burger.HasBun == true) bun = "Bun";

            string? lattuce = null;
            if(burger.HasLattuce == true) lattuce = ", Lattuce";

            string? pickle = null;
            if(burger.HasPickle == true) pickle = ", Pickle";

            string? cheese = null;
            if(burger.HasCheese == true) cheese = ", cheese";

            string? meet = null;
            if(burger.HasMeet != Meet.None) meet = ", "+burger.HasMeet.ToString();

            string? sauce = null;
            if(burger.HasSauce != Sauce.None) sauce = ", "+burger.HasSauce.ToString();
            return string.Format(
                "Your Order:\n"+
                "Day Special\n"+
                "{0}{1}{2}{3}{4}{5}",
                bun, lattuce, pickle, cheese, meet, sauce
            );
        }
    }
}