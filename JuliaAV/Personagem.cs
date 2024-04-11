namespace JuliaAV;


public class Personagem
{
        protected string Arquivo;
        protected double Drink;
        protected double Food;
        protected double Play;

        public Personagem()
        {
            Drink=0.5;
            Food=0.5;
            Play=0.5;
        }

        public void SetDrink( double d)
        {
            if (d<=1 && d>=0)
            {
                Drink=d;
            }
            else if(d > 1)
            {
                Drink=1;
            }
            else
            {
                Drink=0;
            }
        }
        public double GetDrink()
        {
            return Drink;
        }
        public void SetFood( double f)
        {
            if (f<=1 && f>=0)
            {
                Food=f;
            }
            else if(f > 1)
            {
                Food=1;
            }
            else
            {
                Food=0;
            }
        }
        public double GetFood()
        {
            return Food;
        }
         public void SetPlay( double p)
        {
            if (p<=1 && p>=0)
            {
                Play=p;
            }
            else if(p > 1)
            {
                Play=1;
            }
            else
            {
                Play=0;
            }
        }
        public double GetPlay()
        {
            return Play;
        }
}