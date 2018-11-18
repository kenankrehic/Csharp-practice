using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbanje_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 2, 4, 5, 6, 7 };
            int[] array2 = new int[] { 2, 4, 5, 6, 7 };
            int a = 0;
            for (a = 0; a < array1.length; a++)
            {
                console.write(array1[a] * array2[a]);
                console.write("\t");

            }
            console.readline();


            console.writeline("unesite neki broj");
            int a = int.parse(console.readline());

            if ((a % 3 == 0) || (a % 7 == 0))
            {
                console.writeline("true");
            }
            else
            {
                console.writeline("false");
            }
            console.readline();

            console.writeline("unesite prvi broj manji od 100");
            int a = int.parse(console.readline());
            console.writeline("unesite drugi broj veci od 200");
            int b = int.parse(console.readline());

            if ((a < 100) && (b > 200))
            {
                console.writeline("true");
            }
            else
            {
                console.writeline("false");
            }
            console.readline();

            console.writeline("unesite prvi broj izmedju -10 i 10");
            int a = int.parse(console.readline());
            console.writeline("unesite drugi broj izmedju -10 i 10");
            int b = int.parse(console.readline());

            if ((a > -10 && a < 10) && (b > -10 && b < 10))
            {
                console.writeline("true");
            }
            else
            {
                console.writeline("false");
            }
            console.readline();

            console.writeline("unesite prvi broj");
            int a = int.parse(console.readline());
            console.writeline("unesite drugi broj");
            int b = int.parse(console.readline());
            console.writeline("unesite treci broj");
            int c = int.parse(console.readline());

            if ((a > b) && (a > c))
            {
                console.writeline("prvi je najveci");


            }
            if ((b > a) && (b > c))
            {
                console.writeline("drugi je najveci");
            }

            if ((c > a) && (c > b))
            {
                console.writeline("treci je najveci");
            }
            if ((c < b) && (c < a))
            {
                console.writeline("treci je najmanji");
            }
            if ((b < a) && (b < c))
            {
                console.writeline("drugi je najmanji");
            }
            if ((a < b) && (a < c))
            {
                console.writeline("prvi je najmanji");
            }
            console.readline();

            console.writeline("unesite prvi broj");
            int a = int.parse(console.readline());
            console.writeline("unesite drugi broj");
            int b = int.parse(console.readline());

            if (math.abs(a - 20) > math.abs(b - 20))
            {
                console.writeline(b);
            }
            else if (math.abs(a - 20) < math.abs(b - 20))
            {
                console.writeline(a);
            }
            else if (a == b)
            {
                console.writeline(0);
            }
            else
            {
                console.writeline("brojevi su jednako udaljeni");
            }
            console.readline();

            console.writeline("unesite svoje ime");
            string a = console.readline();
            console.writeline("hello " + a);
            console.readline();

            console.writeline("unesite 2 broja");
            int a = int.parse(console.readline());
            int b = int.parse(console.readline());
            console.writeline("suma je " + (a + b));
            console.readline();

            console.writeline("unesite 2 broja");
            int a = int.parse(console.readline());
            int b = int.parse(console.readline());

            int c;
            c = a;
            a = b;
            b = c;




            console.writeline("poslije zamjene prvi broj je " + a + " a drugi broj je " + b);
            console.readline();

            console.writeline("unesite 3 broja za mnozenje");
            int a = int.parse(console.readline());
            int b = int.parse(console.readline());
            int c = int.parse(console.readline());

            console.writeline("multiplikacija 3 broja je " + (a * b * c));
            console.readline();

            console.writeline("unesite 2 broja");
            int a = int.parse(console.readline());
            int b = int.parse(console.readline());

            console.writeline("zbir brojeva je " + (a + b));
            console.writeline("minus brojeva je " + (a - b));
            console.writeline("mnozenje brojeva je " + a * b);
            console.writeline("djeljenje brojeva je " + a / b);
            console.readline();

            console.writeline("unesite broj");
            int a = int.parse(console.readline());
            console.writeline("a*0=" + a * 0);
            console.writeline(a + "*1=" + a * 1);
            console.writeline(a * 2);
            console.writeline(a * 3);
            console.writeline(a * 4);
            console.writeline(a * 5);
            console.writeline(a * 6);
            console.writeline(a * 7);
            console.writeline(a * 8);
            console.writeline(a * 9);
            console.writeline(a * 10);
            console.readline();

            console.writeline("enter 4 numbers");
            int a = int.parse(console.readline());
            int b = int.parse(console.readline());
            int c = int.parse(console.readline());
            int d = int.parse(console.readline());

            console.writeline("prosjek brojeva je " + (a + b + c + d) / 4);
            console.readline();

            console.writeline("unesi 3 broja");
            int x = int.parse(console.readline());
            int y = int.parse(console.readline());
            int z = int.parse(console.readline());

            console.writeline("rezultat brojeva " + x + " " + y + " " + z + ",(" + x + "+" + y + ")" + "*" + z + " je " + (x + y) * z);
            console.writeline(x * y + y * z);
            console.readline();

            console.writeline("enter your age");
            int a = int.parse(console.readline());
            console.writeline("you look older than " + a);
            console.readline();

            console.writeline("unesite broj");
            int a = int.parse(console.readline());
            console.writeline(a + " " + a + " " + a + " " + a);

            console.readline();

            console.writeline("unesite temp u celsiusima");
            int a = int.parse(console.readline());
            console.writeline("fahrenheit=" + (a * 1.8 + 32));
            console.writeline("kelvin=" + (a + 273.15));
            console.readline();

            console.writeline("unesite 2 broja");
            int a = int.parse(console.readline());
            int b = int.parse(console.readline());

            if ((a > 0) && (b < 0))
            {
                console.writeline("true");
            }
            else if ((b > 0) && (a < 0))
            {
                console.writeline("true");
            }
            else
            {
                console.writeline("false");
            }
            console.readline();

            console.writeline("unesite 2 broja");
            int a = int.parse(console.readline());
            int b = int.parse(console.readline());

            if (a != b)
            {
                console.writeline(a + b);
            }
            else if (a == b)
            {
                console.writeline((a + b) * 3);
            }
            console.readline();

            console.writeline("unesite prvi broj");
            int ee = int.parse(console.readline());
            console.writeline("unesite drugi broj");
            int ff = int.parse(console.readline());
            if (ee > ff)
            {
                console.writeline(math.abs(ee - ff) * 2);
            }
            else
                console.writeline(math.abs(ee - ff));
            console.readline();

            console.writeline("unesite prvi broj");
            int a = int.parse(console.readline());
            console.writeline("unesite drugi broj");
            int b = int.parse(console.readline());

            if ((a == 20) || (b == 20) || (a + b == 20))
            {

                console.writeline("true");
            }
            else
            {
                console.writeline("false");
            }
            console.readline();

            console.writeline("unesite prvi broj");
            int a = int.parse(console.readline());

            if ((a < 20) || (a > 100) || (a == 200))
            {
                console.writeline("true");
            }
            else
            {
                console.writeline("false");
            }

            for (int a = 0; a < 100; a++)
            {
                if (a % 2 != 0)
                {
                    console.writeline(a);
                }
            }
            console.readline();

            console.writeline("unesite broj");
            int a = int.parse(console.readline());
            int suma = 0;
            while (a != 0)
            {

                suma = suma + a % 10;
                a = a / 10;


            }
            console.writeline(suma);
            console.readline();

            int[] array = new int[] { 1, 3, -5, 4 };
            int[] array2 = new int[] { 1, 4, -5, -2 };

            for (int a = 0; a < array.length; a++)
            {
                console.write(array[a] * array2[a]);
                console.write("\t");
            }
            console.readline();

            console.writeline("unesite 2 broja");
            int a = int.parse(console.readline());
            int b = int.parse(console.readline());

            if ((math.abs(a - 20) > (math.abs(b - 20))))
            {
                console.write(b);
            }
            else if ((math.abs(a - 20) < (math.abs(b - 20))))
            {
                console.write(a);
            }
            else
            {
                console.write("jednako su udaljeni");
            }
            console.readline();

            console.writeline("unesite neki broj");
            int a = int.parse(console.readline());
            int[] niz1 = new int[] { 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 7, 2, 3, 5, 7 };
            int broj = 0;
            for (int b = 0; b < niz1.length; b++)
            {
                if (niz1[b] == a)
                {
                    broj++;
                }
            }
            console.writeline(broj);
            console.readline();


            console.writeline("unesite neki broj");
            int a = int.parse(console.readline());
            int[] niz1 = new int[] { 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 7, 2, 3, 5, 7 };

            if ((a == niz1[0] || a == niz1[niz1.length - 1]))
            {
                console.writeline("true");
            }
            else console.writeline("false");

            console.readline();


            int[] niz1 = new int[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int suma = 0;
            for (int b = 0; b < niz1.length; b++)

            {
                suma = suma + niz1[b];
            }
            console.writeline(suma);
            console.readline

            int[] niz1 = new int[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };


            if (niz1.length > 1)
            {
                if ((niz1[0] == niz1[niz1.length - 1]))
                {
                    console.writeline("true");
                }
                else
                {
                    console.writeline("false");
                }

            }
            else
            {
                console.writeline("length of array is 1");
            }
            console.readline();

            int[] niz1 = new int[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int[] niz2 = new int[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };

            if (((niz1[0] == niz1[niz1.length - 1])) || ((niz2[0] == niz2[niz2.length - 1])))
            {
                console.writeline("true");
            }
            else
            {
                console.writeline("false");
            }
            console.readline();

            int[] niz1 = new int[] { 1, 2, 8 };
            int[] niz2 = new int[] { niz1[1], niz1[2], niz1[0] };

            for (int a = 0; a < niz1.length; a++)
            {
                console.write(niz1[a]);
                console.write("\t");
            }
            console.readline();

            int[] niz1 = new int[] { 1, 5, 7, 8 };

            if (niz1[0] > niz1[niz1.length - 1])
            {
                console.writeline(niz1[0]);
            }

            else if (niz1[0] < niz1[niz1.length - 1])
            {
                console.writeline(niz1[niz1.length - 1]);
            }
            else
            {
                console.writeline("brojevi su  jednaki");
            }
            console.readline();

            int[] niz1 = new int[] { 1, 2, 5 };
            int[] niz2 = new int[] { 0, 3, 8 };
            int[] niz3 = new int[] { -1, 0, 2 };

            int[] niz4 = new int[] { niz1[1], niz2[1], niz3[1] };

            for (int a = 0; a < niz1.length; a++)
            {
                console.writeline(niz4[a]);
            }
            console.readline();

            int[] niz1 = new int[] { 2, 4, 7, 8, 6 };
            for (int a = 0; a < niz1.length; a++)
            {
                if (niz1[a] % 2 == 0)
                {
                    console.writeline("true");
                }



            }

            console.readline();

            console.writeline("unesite 3 slova");
            string a = console.readline();
            string b = console.readline();
            string c = console.readline();

            console.writeline(c + b + a);
            console.readline();


            console.writeline("unesite jedan broj");
            int a = int.parse(console.readline());
            console.writeline("unesite željenu širinu trokuta");
            int b = int.parse(console.readline());
            int c = b;
            for (int d = 0; d < c; d++)
            {
                for (int e = 0; e < b; e++)
                {
                    console.write(a);
                }
                console.writeline();
                b--;
            }
            console.readline();

            string username = "kenan";
            string password = "123";


            int brojac = 0;

            while (brojac < 3)
            {
                console.writeline("unesite username");
                string a = console.readline();
                console.writeline("unesite pasword");
                string b = console.readline();
                brojac++;

                if ((a == username) && (b == password))
                {
                    console.writeline("dobrodosli");
                    break;
                }
                else
                {
                    console.writeline("pogresan unos");
                }

            }
            if (brojac == 3)
            {
                console.writeline("unjeli ste 3 puta pogresno");
            }
            console.readline();

            pocetak:
            console.writeline("unesite prvi broj");
            double a = double.parse(console.readline());
            console.writeline("unesite željenu matematičku operaciju (+,-,*,/,%)");
            string operacija = console.readline();
            console.writeline("unesite drugi broj");
            double b = double.parse(console.readline());

            if (operacija == "+")
            {
                console.writeline("a+b je" + (a + b));
            }
            else if (operacija == "-")
            {
                console.writeline("a-b je" + (a - b));
            }
            else if (operacija == "*")
            {
                console.writeline("a-b je" + (a * b));
            }
            else if (operacija == "/")
            {
                console.writeline("a-b je" + (a * b));
            }
            else if (operacija == "/")
            {
                console.writeline("a-b je" + (a % b));
            }
            else
            {
                console.writeline("pogresan unos");
                goto pocetak;
            }
            console.readline();
            goto pocetak;

            console.writeline("unesite poluprečnik kruga");
            int r = int.parse(console.readline());

            console.writeline("obim kruga je " + (2 * r * 3.14));
            console.writeline("površina kruga je " + (r * r * 3.14));
            console.readline();

            for (int y = -5; y < 6; y++)
            {
                int x = y * y + 2 * y + 1;
                console.writeline(x);
            }
            console.readline();

            console.writeline("unesite prvi broj");
            double a = double.parse(console.readline());
            console.writeline("unesite drugi broj");
            double b = double.parse(console.readline());

            if ((a % 2 == 0) && (b % 2 == 0))
            {
                console.writeline("true");
            }
            else if ((a % 2 != 0) && (b % 2 != 0))
            {
                console.writeline("false");
            }
            else
            {
                console.writeline("unjeli ste jedan paran jedan neparan");
            }
            console.readline();

            string binarni;
            console.writeline("unesite neki cijeli broj");
            int a = int.parse(console.readline());
            binarni = "";
            while (a > 1)
            {
                int b = a % 2;
                binarni = convert.tostring(b) + binarni;
                a /= 2;
            }
            binarni = convert.tostring(a) + binarni;
            console.writeline("binarni: {0}", binarni);
            console.readline();

            leap year

            console.writeline("unesite godinu");
            int a = int.parse(console.readline());

            if ((a % 4 == 0) && (a % 100 != 0))
            {
                console.writeline("its a leap year");

            }
            else if ((a % 100 == 0) && (a % 400 != 0))
            {
                console.writeline("its not a leap year");
            }
            else if ((a % 100 == 0) && (a % 400 == 0))
            {
                console.writeline("its a leap year");
            }
            else
            {
                console.writeline("its not a leap year");
            }
            console.readline();

            console.writeline("unesite broj");
            int m = int.parse(console.readline());
            if (m > 0)
            {
                console.writeline("n is 1");
            }
            else if (m == 0)
            {
                console.writeline("n is 0");
            }
            else if (m < 0)
            {
                console.writeline("n is -1");
            }
            console.readline();

            vjezbanje 4

            for (int a = 1; a <= 10; a++)
            {
                console.writeline(a);
            }
            console.readline();
            int sum = 0;
            for (int a = 1; a <= 10; a++)
            {
                
                Console.WriteLine(a);
                sum = sum + a;
                

            }
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
