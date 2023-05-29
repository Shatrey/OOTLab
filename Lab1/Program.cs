using Lab1;

//Написати програмне забезпечення, що описує застосування породжуючий патерн 
//Фабричний метод.

var dogFactory = new DogFactory();
var dog = dogFactory.CreateAnimal();
dog.MakeSound();

var catFactory = new CatFactory();
var cat = catFactory.CreateAnimal();
cat.MakeSound();