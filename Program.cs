using System;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Man man = new Man(true);
            man.hello();
            num = man.YouHave();
            string[] x = new string [num];
            int[] y = new int [num];
            int[] z = new int [num];

            x = man.DogsName(num); 
            y = man.DogFsurLength(num);
            z = man.DogsAge(num);

            
            man.oldify();
            for (int i = 0; i < num; i ++)
            {
                Dog dog = new Dog(x[i]);
                dog.say();
                dog.oldify();
            }
            
        }
    }
    
    public class Man
    {
        public int age, numOFdogs = 0;
        // true - man, false - woman 
        public bool hDog = false, gender = false;
        public string name;
        public Man(bool gender)
        {
            this.gender = gender;
        }
        public void hello()
        {
            Console.WriteLine("Как Вас зовут?");
            name = Console.ReadLine();
            Console.WriteLine("Сколько Вам лет?");
            age = int.Parse(Console.ReadLine());
        }
        
        public int YouHave()
        {
            Console.WriteLine("Если у Вас есть собака, введите цифру один");
            numOFdogs = int.Parse(Console.ReadLine());
            if (numOFdogs == 1)
            {
                hDog = true;
            }
            Console.WriteLine("Сколько у Вас есть собак?");
            numOFdogs = int.Parse(Console.ReadLine());
            return numOFdogs;
        }
        
        public string[] DogsName(int numOFdogs){
        string[]x = new string[numOFdogs]; 
        string nameD;
        for (int i = 0; i < numOFdogs; i ++){
            Console.WriteLine("Как зовут Вашу собаку номер " + (i+1) + "?");
            nameD = Console.ReadLine();
            x[i] = nameD;
        }
        return x;
        }
        
        public int[] DogFsurLength(int numOFdogs){
        int[]x = new int[numOFdogs]; 
        int fLD;
        for (int i = 0; i < numOFdogs; i ++){
            Console.WriteLine("Какая длина шерсти у Вашей собаки номер  " + (i+1) + "?");
            fLD = int.Parse(Console.ReadLine());
            x[i] = fLD;
        }
        return x;
        }
        
        public int[] DogsAge(int numOFdogs){
        int[]x = new int[numOFdogs]; 
        int ageD;
        for (int i = 0; i < numOFdogs; i ++){
            Console.WriteLine("Сколько лет Вашей собаке номер " + (i+1) + "?");
            ageD = int.Parse(Console.ReadLine());
            x[i] = ageD;
        }
        return x;
        }
        
        public void oldify()
        {
            this.age += 1;
            Console.WriteLine("Прошёл год\n" + this.name + ",Вам теперь " + this.age + " лет");
        }
    }

    public class Dog
    {
        
        public int age, furLength;
        public string name;

        public Dog(string name)
        {
            this.name = name;

        }
        public void go()
        {
            Console.WriteLine("Собака гуляет");
        }
        public void say()
        {
            Console.WriteLine(this.name + ": гав-гав");
        
        }
        public void oldify()
        {
            age += 1;
            furLength += 5;
            Console.WriteLine(this.name + " теперь " + age + " лет, шерсть отросла до " + furLength + " см.");
        }
    }
}
