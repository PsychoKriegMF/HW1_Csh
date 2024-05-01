namespace HW1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1");
            Console.WriteLine("Введите 'A' сторону прямоугольника -> ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 'B' сторону прямоугольника -> ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 'C' сторону квадрата -> ");
            int c = Convert.ToInt32(Console.ReadLine());


            if(c > a || c > b) 
            { 
                throw new Exception("Такой квадрат разместить нельзя!"); 
            }
            else
            {
                int count =  (a / c) * (b / c); 
                Console.WriteLine("В прямоугольник размером " + a + " на " + b +" можно поместить " + count + " квадратов");
                double remainder = a * b - count * c * c;
                Console.WriteLine("Остаток места = " + remainder);
            }

            Console.WriteLine("=============================================================");
            Console.WriteLine("Задача 2");

            double initalDeposit = 10000;
            double intermediate_deposit = initalDeposit;
            double targetDeposit = 11000;
            double interestRate;
            int months = 0;

            Console.WriteLine("Введите процентную ставку от 0 до 25:)");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out interestRate) && interestRate > 0 && interestRate < 25)
                {
                    break;
                }
                else { Console.WriteLine("Недопустимое значение!"); }
            }

            while (intermediate_deposit < targetDeposit)
            {
                intermediate_deposit += intermediate_deposit * (interestRate / 100);
                months++;
            }
            Console.WriteLine("Кол-во месяцев до желаемого результата: " + months);
            Console.WriteLine("Размер вклада по истечению месяцев: " + intermediate_deposit);


            Console.WriteLine("=============================================================");
            Console.WriteLine("Задача 3");

            int num1, num2;
            Console.WriteLine("Введите начальное число-> ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите последнее число-> ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                (num1, num2) = (num2, num1);
            }
            for (int i = num1; i <= num2; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }


            Console.WriteLine("=============================================================");
            Console.WriteLine("Задача 4");
            int n;
            int revers_n = 0;

            Console.WriteLine("Введите положительное число-> ");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                {
                    break;
                }
                else
                    Console.WriteLine("Не корректный ввод!");
            }

            while( n > 0)
            {
                revers_n = revers_n*10 + n%10;
                n/=10;
            }
            Console.WriteLine("Введенное число наоборот - " + revers_n);
        
        }
    }
}
