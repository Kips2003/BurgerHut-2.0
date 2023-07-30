using BurgerHut.Enum;


namespace BurgerHut.Classes{
    public class BurgerBuilder{
        private Burger _burger = new Burger();

        public BurgerBuilder Start(){
            _burger = new Burger();
            return this;
        }

        public BurgerBuilder WithBun(){
            _burger.HasBun = true;
            return this;
        }

        public BurgerBuilder WithLattuce(){
            _burger.HasLattuce = true;
            return this;
        }

        public BurgerBuilder WithPickle(){
            _burger.HasPickle = true;
            return this;
        }

        public BurgerBuilder WithCheese(){
            _burger.HasCheese = true;
            return this;
        }

        public BurgerBuilder WhichKindOfMeet(int num){
            _burger.HasMeet = (Meet)num;
            return this;
        }

        public BurgerBuilder WhichKindOfSauce(int num){
            _burger.HasSauce = (Sauce)num;
            return this;
        }

        public Burger Build(){
            return _burger;
        }
    }
}