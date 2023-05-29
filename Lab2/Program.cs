using Lab2;

var original = new Wolf();
original.Info = new AnimalInfo
{
    Age = 1,
    Name = "Original",
};

var clone = (Wolf)original.Clone();
clone.Info.Name = "Clone";


original.MakeSound();
clone.MakeSound();