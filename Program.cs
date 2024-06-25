using System;

namespace HW_12_21_06_2024
{
    //    Завдання 1
//    Створіть додаток, який відображає текстове повідомлення.Використовуйте механізми делегатів.Делегат має
//повертати void та приймати один параметр типу string
//(текст повідомлення). Для тестування додатка створіть
//різні методи виклику через делегат.
//Завдання 2
//Створіть додаток для виконання арифметичних операцій.Підтримувані операції:
//■ Додавання двох чисел;
//■ Віднімання двох чисел;
//■ Множення двох чисел.
//Код програми обов’язково має використати механізм
//делегатів.
//Завдання 3
//Створіть додатки для виконання арифметичних операцій.Підтримувані операції:
//■ Перевірка числа на парність;
//■ Перевірка числа на непарність;
//■ Перевірка на просте число;
//■ Перевірка на число Фібоначчі.
//Обов’язково використовуйте делегат типу Predicate.
//Завдання 4
//Реалізуйте додаток із другого практичного завдання
//за допомогою виклику Invoke.

    internal class Program
    {
        public delegate void StrDel(string text);
        public delegate int MathDel(int a, int b);
        Predicate<int> pred;
        static void Main(string[] args)
        {
            //    Завдання 1
            TextMessage message = new TextMessage();
            StrDel myDel = message.SayHello;
            myDel += message.AskAge;
            myDel += message.SayGoodBye;
            myDel.Invoke("Alex");
            //Завдання 2
            MyMath myMath = new MyMath();
            MathDel mathDel = myMath.Sum;
            mathDel += myMath.Mult;
            mathDel += myMath.Diff;
            foreach (var operation in mathDel.GetInvocationList())
            {
                Console.WriteLine(((MathDel)operation).Invoke(5, 2));
            }
            //Завдання 3
            MathTest mathTest = new MathTest();
            Predicate<int> predicate = mathTest.isParity;
            Console.WriteLine($"Is parity: {predicate(16)}");
            predicate = mathTest.isOddnes;
            Console.WriteLine($"Is oddnes: {predicate(15)}");
            predicate = mathTest.isPrime;
            Console.WriteLine($"Is prime: {predicate(12)}");
            predicate = mathTest.isFibonacci;
            Console.WriteLine($"Is Fibonacci number: {predicate(10946)}");
            Console.WriteLine($"Is Fibonacci number: {predicate(10947)}");
        }
    }
}
