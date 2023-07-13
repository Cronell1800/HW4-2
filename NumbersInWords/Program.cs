namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] units = { "", "bir", "ikki", "uch", "to'rt", "besh", "olti", "yetti", "sakkiz", "to'qqiz" };
            string[] tens = { "", "o'n", "yigirma", "o'ttiz", "qirq", "ellik", "oltmish", "yetmish", "sakson", "to'qson" };

            Console.WriteLine("Enter a number (0 to one million):");
            string input = Console.ReadLine();
            

            if (!int.TryParse(input, out int number) || number < 0 || number > 1000000) 
            {
                Console.WriteLine("Xatolik! Iltimos 0 va 1 000 000 oralig'ida son kiriting");
            } 
            else if (number == 0)
            {
                Console.WriteLine(number + " so'zda: nol");
            }
            else if (number == 1000000)
            {
                Console.WriteLine(number + " so'zda: million");
            }
            else if (number > 0 && number < 10)
            {
                Console.WriteLine(number + " so'zda: " + units[number]);
            }
            else if (number > 9 && number < 100)
            {
                Console.WriteLine(number + " so'zda: " + tens[number / 10] + units[number % 10]);
            }
            else if (number > 99 && number < 1000)
            {
                Console.WriteLine(number + " so'zda: " + 
                    units[number / 100] + " yuz " + 
                    tens[(number - (number / 100) * 100) / 10] + " " + 
                    units[(number - (number / 100) * 100) % 10]);
            }
            else if (number > 999 && number < 10000)
            {
                Console.WriteLine(number + " so'zda: " + 
                    units[number / 1000] + " ming " + 
                    units[(number - (number / 1000) * 1000) / 100] + " yuz " +
                    tens[(number - (number / 100) * 100) / 10] + " " +
                    units[(number - (number / 100) * 100) % 10]);
            }
            else if (number > 9999 && number < 100000)
            {
                Console.WriteLine(number + " so'zda: " +
                    tens[number / 10000] + " " +
                    units[(number - (number / 10000) * 10000) / 1000] + " ming " +
                    units[(number - (number / 1000) * 1000) / 100] + " yuz " +
                    tens[(number - (number / 100) * 100) / 10] + " " +
                    units[(number - (number / 100) * 100) % 10]);
            }
            else if (number > 99999 && number < 1000000)
            {
                Console.WriteLine(number + " so'zda: " +
                    units[number / 100000] + " yuz " +
                    tens[(number - (number / 100000) * 100000) / 10000] + " " +
                    units[(number - (number / 10000) * 10000) / 1000] + " ming " +
                    units[(number - (number / 1000) * 1000) / 100] + " yuz " +
                    tens[(number - (number / 100) * 100) / 10] + " " +
                    units[(number - (number / 100) * 100) % 10]);
            }
        }
    }
}







/*if (!int.TryParse(input, out int number) || number < 0 || number > 1000000)
            {
                Console.WriteLine("Invalid input! Please enter a number between 0 and one million.");
            }
            else if (number == 0)
            {
                Console.WriteLine("In words: zero");
            }
            else
            {
                string words = "";

                if (number % 100 < 20)
                {
                    words = units[number % 100];
                    number /= 100;
                }
                else
                {
                    words = units[number % 10];
                    number /= 10;

                    words = tens[number % 10] + " " + words;
                    number /= 10;
                }

                if (number > 0)
                {
                    words = units[number] + " hundred " + words;
                }

                int groupIndex = 0;
                while (number > 0)
                {
                    int group = number % 1000;
                    if (group != 0)
                    {
                        string groupWords = words;
                        if (!string.IsNullOrEmpty(words))
                        {
                            groupWords += " " + thousandsGroups[groupIndex];
                        }

                        if (group >= 100)
                        {
                            groupWords += units[group / 100] + " hundred ";
                            group %= 100;
                        }

                        if (group >= 20)
                        {
                            groupWords += tens[group / 10] + " ";
                            group %= 10;
                        }

                        if (group > 0)
                        {
                            groupWords += units[group] + " ";
                        }

                        words = groupWords;
                    }

                    number /= 1000;
                    groupIndex++;
                }

                Console.WriteLine("In words: " + words.Trim());
            }*/