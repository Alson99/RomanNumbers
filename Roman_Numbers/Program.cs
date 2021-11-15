using System;

namespace roman_numbers
{
    class Program
    {
        static void Main(string[] args)
            
        {

            try
            {
                Console.WriteLine("Enter the arabic numbers: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("That number to Roman is: ");
                Roman v = new Roman(x);
                Console.WriteLine(v);
                Roman k = new Roman(17); 

                //Console.WriteLine(k);
                //Console.WriteLine(v + k);
                try {
                    
                    //Console.WriteLine(v + k);
                    Console.WriteLine("Enter the Roman numbers to translate it into Arabic: ");
                }


                catch { Console.WriteLine("Сложение некорректно"); }


                finally
                {

                    try
                    {
                       //Console.WriteLine(v - k);
                    }
                    catch { Console.WriteLine("Вычитание некорректно"); }
                    finally
                    {
                        try
                        {
                            //Console.WriteLine(v * k);
                        }
                        catch { Console.WriteLine("Умножение некорректно"); }
                        finally
                        {
                            try
                            {
                                //Console.WriteLine(v / k);
                            }
                            catch { Console.WriteLine("Деление некорректно"); }
                            finally
                            {

                               // Console.WriteLine(v > k ? "true" : "false");
                                //Console.WriteLine(v < k ? "true" : "false");
                                //Console.WriteLine(v == k ? "true" : "false");
                                //Console.WriteLine(v != k ? "true" : "false");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Вы ввели некорректное число");
            }
            string str = Console.ReadLine();
            str = str.ToUpper();
            try
            {
                Roman k = new Roman(str);
                Console.WriteLine(k);
            }
            catch
            {
                Console.WriteLine("You wrote the wrong number ! ");
            }

        }
    }
}
