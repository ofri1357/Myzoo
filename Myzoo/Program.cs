using Myzoo;

Dog dog = new Dog() { Name = "Humus", Weight = 5 };
Cat cat = new Cat() { Name = "Pita", Weight = 4 };
Donkey donkey = new Donkey() { Name = "Schug", Weight = 100 };


List<Animal> animals = new List<Animal>() { dog, cat, donkey };
foreach (var animal in animals)
{
    Console.WriteLine(animal.SayHello());
    Thread.Sleep(1000);
}