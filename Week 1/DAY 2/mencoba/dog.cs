namespace DogMaker
{
    public class Dog
    {	
        public string name;
        public int weight;
        
        public Dog(string name)
        {
            this.name = name;
        }
        
        public void Eat(string food)
        {
            Console.WriteLine($"{name} Eat {food}");
        }
        
        public void EatFood(string food)
        {
            Console.WriteLine($"{name} Eat {food}");
        }
    }			
}
