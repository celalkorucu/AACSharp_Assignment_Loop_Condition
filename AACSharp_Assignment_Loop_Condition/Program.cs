// See https://aka.ms/new-console-template for more information
using AACSharp_Assignment_Loop_Condition.classes;

Console.WriteLine("Hello, World!");

User user = new User();
user.age = 72;
string categorize = user.Categorize();
Console.WriteLine(categorize);



Car car = new Car();
car.age = 9;
string categorizeCar = car.Categorize();
Console.WriteLine(categorizeCar);


int i = 0;
while (i < 5)
{
    Console.WriteLine("While Döngüsü: " + i);
    i++;
}

int j = 0;
do
{
    Console.WriteLine("Do-While Döngüsü: " + j);
    j++;
} while (j < 5);

// While döngüsünde koşul sağlanmazsa işlemler hiç yapılmaz
// do-While da ise en az bir kez yapılır.

Worker worker = new Worker();
worker.name = "Celal";
worker.surname = "Korucu";
worker.job = "Bilgisayar Mühendisi";
worker.age = 22;
worker.wage = 100000;
worker.department = "Genel Müdür";


Worker worker2 = new Worker();
worker2.name = "Serhat";
worker2.surname = "Yörük";
worker2.job = "Mimar";
worker2.age = 22;
worker2.wage = 80000;
worker2.department = "Müdür";

Worker worker3 = new Worker();
worker3.name = "Esra";
worker3.surname = "Çinici";
worker3.job = "Mimar";
worker3.age = 22;
worker3.wage = 10000;
worker3.department = "Stajyer";


List<Worker> workers = new List<Worker>();
workers.Add(worker);
workers.Add(worker2);
workers.Add(worker3);

Worker.SumWage(workers);


Car car1 = new Car();
car1.fuelConsumption = 5.07;

Car car2 = new Car();
car2.fuelConsumption = 4.07;

Car car3 = new Car();
car3.fuelConsumption = 6.77;

Car car4 = new Car();
car4.fuelConsumption = 4.57;

Car car5 = new Car();
car5.fuelConsumption = 2.47;


List<Car> cars = new List<Car>();
cars.Add(car1);
cars.Add(car2);
cars.Add(car3);
cars.Add(car4);
cars.Add(car5);


double sum = Car.Sum(cars);
Console.WriteLine(sum);




