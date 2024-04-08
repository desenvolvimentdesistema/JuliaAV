namespace JuliaAV;


public class Personagem
{
        protected string Arquivo;
        protected double Drink;
        protected double Food;
        protected double Play;
        public string GetArquivo()
        {
            return Arquivo;
        }
        public double GetDrink()
        {
            return Drink;
        }
        public double  GetFood()
        {
            return Food;
        }
        public double GetPlay()
        {
            return Play;
        }
}