using PostNumbers;

Console.Write("Введите число: ");

char[] number = Console.ReadLine().ToCharArray();

Numbers number1 = new Numbers();

Console.WriteLine("Числов в почтовой системе исчесления: ");
number1.TranslationPostman(number);