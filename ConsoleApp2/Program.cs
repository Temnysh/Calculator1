namespace Calculator
{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            double firstN = double.Parse(Console.ReadLine());
            double answer = firstN;

            do
            {
                Console.WriteLine("Введите оператор: ");
                int oper = char.Parse(Console.ReadLine());
                Console.WriteLine("Введите следующее число: ");
                double nextN = double.Parse(Console.ReadLine());

                if (oper == '+') 
                {
                    answer = answer + nextN;
                    WriteAnswer(answer);
                }
                else if (oper == '-') 
                {
                    answer = answer - nextN;
                    WriteAnswer(answer);
                }
                else if (oper == '*') 
                {
                    answer = answer * nextN;
                    WriteAnswer(answer);
                }
                else if (oper == '/') 
                {
                    answer = answer / nextN;
                    WriteAnswer(answer);
                }
                else 
                {
                    Console.WriteLine("Введен несчитываемый оператор: " + oper);
                    Console.WriteLine("Используйте + * / - ");
                   
                }

                Console.WriteLine("Введите Y, если нужно продолжить выражение дальше или N, если это всё ");
                char YorN2 = char.Parse(Console.ReadLine());
                bool A2 = false;

                if (YorN2 == 'N') 
                { 
                    A2 = false; 
                }
                else if (YorN2 == 'Y')
                {
                    A2 = true;
                }
                else
                {
                    Console.WriteLine("Введен не Y и не N");
                    Console.WriteLine("Программа будет остановлена");
                    return;
                }

                if (!A2)
                {
                    return; 
                }
            }
            while (true);
        }

        public static void WriteAnswer(double answer)
        {
            Console.WriteLine("Ответ: " + answer);
        }
    }
}
