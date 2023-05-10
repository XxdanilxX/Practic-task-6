// See https://aka.ms/new-console-template for more information
namespace practic6
{
    public interface IParent
    {
        void Info();
        double Value();
    }
    public class Child1 : IParent
    {
        double speed;
        double height;
        double value;
        public Child1(double speed, double height)
        {
            this.speed = speed;
            this.height = height;
            
        }
        
        public double Value()
        {
            value = (speed * 1000) + (height * 100);
            return value;
        }
        public void Info()
        {
            Console.WriteLine("Пасажирський літак: Швидкість: {0} Висота: {1} Вартість: ", speed, height);
        }
    }
    public class Child2 : IParent
    {
        double speed;
        double height;
        double value;
        public Child2(double speed, double height)
        {
            this.speed = speed;
            this.height = height;
            
        }
        
        public double Value()
        {
            value= (speed * 3000) + (height * 200);
            return value;
        }
        public void Info()
        {
            Console.WriteLine("Винищувач: Швидкість: {0} Висота: {1} Вартість: ", speed, height);
        }
    }
    public class Child3 : IParent
    {
        double speed;
        double height;
        double value;
        int bombs;
        public Child3(double speed, double height, int bombs)
        {
            this.speed = speed;
            this.height = height;
            this.bombs = bombs;
            
        }
        
       
        public double Value()
        {
            value = (speed * 1500) + (height * 150) + (bombs * 50);
            return value;
        }
        public void Info()
        {
            Console.WriteLine("Бомбардувальник: Швидкість: {0} Висота: {1} Кількість бомб: {2} Вартість: ", speed, height, bombs);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            IParent obj = null;
            Random o = new Random();
            double speed, height,value;
            int bombs,f;
            for (int i = 1; i <=5; i++)
            {
                f = o.Next(1, 4);
                if (f == 1)
                {
                    speed = o.Next(400, 800);
                    height = o.Next(3000, 5000);
                    
                    obj = new Child1(speed, height);
                }
                if (f == 2)
                {
                 
                    speed = o.Next(800, 1200);
                    height = o.Next(6000, 10000);
                    
                    obj = new Child2(speed, height);
                }
                if (f == 3)
                {
                    speed = o.Next(600, 800);
                    height = o.Next(8000, 10000);
                    bombs=o.Next(6, 20);
                    
                    obj = new Child3(speed, height,bombs);
                }
                obj.Info();
                string v=Convert.ToString(obj.Value());
                Console.WriteLine(v);
            }
        }
    }
}
