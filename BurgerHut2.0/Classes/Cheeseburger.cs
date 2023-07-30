using BurgerHut.Enum;


namespace BurgerHut.Classes{
    public class Cheeseburger:Burger{
        BurgerBuilder burgerBuilder = new BurgerBuilder();
        Burger burger = new Burger();
        public void MakeCheeseburger(){
            
            burger = burgerBuilder
            .Start()
            .WithBun()
            .WithCheese()
            .WithLattuce()
            .WithPickle()
            .WhichKindOfSauce(1)
            .WhichKindOfMeet(3)
            .Build();
        }

        public override string ToString(){
            MakeCheeseburger();

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
                "Cheeseburger\n"+
                "{0}{1}{2}{3}{4}{5}",
                bun, lattuce, pickle, cheese, meet, sauce
            );
        }


        
    }
}