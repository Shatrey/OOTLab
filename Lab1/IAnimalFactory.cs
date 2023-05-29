namespace Lab1
{
    interface IAnimalFactory
    {
        IAnimal CreateAnimal();
    }

    class DogFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal()
        {
            return new Dog();
        }
    }

    class CatFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal()
        {
            return new Cat();
        }
    }
}
