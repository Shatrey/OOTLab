namespace Lab2
{
    internal class Wolf : ICloneable
    {
        public AnimalInfo Info { get; set; }

        public void MakeSound()
        {
            Console.WriteLine($"{Info.Name} age is {Info.Age}");
        }

        public object Clone()
        {
            var copy = (Wolf)MemberwiseClone();
            copy.Info = new AnimalInfo
            {
                Name = Info.Name,
                Age = Info.Age,
            };

            return copy;
        }
    }

    internal class AnimalInfo
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
