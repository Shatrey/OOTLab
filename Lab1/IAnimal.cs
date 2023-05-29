namespace Lab1
{
    internal interface IAnimal
    {
        void MakeSound();
    }

    internal class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("gaw");
        }
    }

    internal class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("meow");
        }
    }
}
