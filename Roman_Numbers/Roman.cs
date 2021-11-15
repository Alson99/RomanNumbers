using System;
using System.Collections.Generic;
using System.Text;

namespace roman_numbers
{

    class Roman
    {
        //функции

        int[] Traduction(int num)
        {
            int count = 0;
            int[] arr = new int[32];
            int ss = 0;
            while (ss < some.Length)
            {
                while (num >= some[ss])
                {
                    num -= some[ss];
                    arr[count] = some[ss];
                    count++;
                }
                ss++;
            }
            return arr;
        }

        int Into_int(int[] arr)
        {
            int num = 0;
            int i = 0;
            while (arr[i] != 0)
            {
                if (arr[i] < arr[i + 1]) arr[i] = -arr[i];
                i++;
            }
            i = 0;
            while (arr[i] != 0)
            {
                num += arr[i++];
            }
            return num;
        }

        //словари
        int[] some = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };


        Dictionary<int, string> roman_digits = new Dictionary<int, string>
        {
            {1, "I" },
            {4, "IV" },
            {5, "V" },
            {9, "IX" },
            {10, "X" },
            {40, "XL" },
            {50, "L" },
            {90, "XC" },
            {100, "C" },
            {400, "CD" },
            {500, "D" },
            {900, "CM" },
            {1000, "M" }
        };

        Dictionary<char, int> digits = new Dictionary<char, int>
        {
            {'I', 1},
            {'V' , 5},
            {'X' , 10},
            {'L' , 50},
            {'C' , 100 },
            {'D' , 500 },
            {'M' , 1000 }
        };

        // переменные-свойства // properties

        public int X { get; set; }
        public int type_of_it { get; set; }

        //введение конструкторов // the constructors

        public Roman()
        {
            type_of_it = 0;
            X = 0;
        }

        public Roman(Roman rom)
        {
            type_of_it = rom.type_of_it;
            X = rom.X;
        }
        public Roman(int value)
        {
            type_of_it = 0;
            if (value > 3999 || value < 0)
            { throw new Exception("Число вне допустимого диапазона значений!"); }
            else
            {
                X = value;
            }
        }

  
        public Roman(string str)
        {
            type_of_it = 1;
            int i = 0;
            int[] arr = new int[50];
            int h = str.Length;

            for (int k = 0; k < h - 3; k++)
            {
                if (str[k] == str[k + 1] && str[k + 2] == str[k + 1] && str[k] != 'I') throw new Exception();
            }

            while (i < h)
            {
                arr[i] = digits[str[i]];
                i++;
            }

            for (int k = 0; k < h - 2; k++)
            {
                if (arr[k] <= arr[k + 1] && arr[k] <= arr[k + 2] && arr[k] != 1 ) throw new Exception("Некорректная строка");
            }
            X = Into_int(arr);
        }

        //операторы

        static public Roman operator +(Roman r1, Roman r2)
        {
            Roman r3 = new Roman(r1.X + r2.X);
            return (r3);
        }

        static public Roman operator -(Roman r1, Roman r2)
        {
            Roman r3 = new Roman(r1.X - r2.X);
            return (r3);
        }

        static public Roman operator *(Roman r1, Roman r2)
        {
            Roman r3 = new Roman(r1.X * r2.X);
            return (r3);
        }

        static public Roman operator /(Roman r1, Roman r2)
        {
            int i = 0;
            i = r1.X / r2.X;
            //Math.DivRem(r1.X, r2.X, out i);
            Roman r3 = new Roman(i);
            return (r3);
        }

        static public bool operator >(Roman r1, Roman r2)
        {
            if (r1.X > r2.X)
                return true;
            return false;
        }

        static public bool operator <(Roman r1, Roman r2)
        {
            if (r1.X < r2.X)
                return true;
            return false;
        }

        static public bool operator ==(Roman r1, Roman r2)
        {
            if (r1.X == r2.X) 
            return true;
            return false;
        }

        static public bool operator !=(Roman r1, Roman r2)
        {
            if (r1.X != r2.X)
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode();
        }

        //переопределение тустринг

        public override String ToString()
        {
            StringBuilder s = new StringBuilder();
            int[] arr = Traduction(X);
            int i = 0;

            while (arr[i] != 0)
            {
                s.Append(roman_digits[arr[i]]);
                i++;
            }
            if (type_of_it == 1) { s.AppendJoin(' ', " Into Arabic is : ", X); }
            return s.ToString();
        }
    }
}
