using BurgerHut.Enum;


namespace BurgerHut.Classes{
    public class DaySpecial:Burger{
        Burger burger = new Burger();
        BurgerBuilder burgerBuilder= new BurgerBuilder();
        public void MakeCheeseburger(){
            
            burger = burgerBuilder
            .Start()
            .WithBun()
            .WithLattuce()
            .WithPickle()
            .WhichKindOfSauce(3)
            .WhichKindOfMeet(1)
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
                "Day Special\n"+
                "{0}{1}{2}{3}{4}{5}",
                bun, lattuce, pickle, cheese, meet, sauce
            );
        }


        
    }
}