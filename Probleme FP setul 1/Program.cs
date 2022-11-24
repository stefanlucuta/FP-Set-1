using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Probleme_FP_Setul1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Alege o problema : ");
            Console.WriteLine("1.  Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax + b = 0, unde a si b sunt date de intrare.");
            Console.WriteLine("2.  Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax ^ 2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile.");
            Console.WriteLine("3.  Determinati daca n se divide cu k, unde n si k sunt date de intrare. ");
            Console.WriteLine("4.  Detreminati daca un an y este an bisect.");
            Console.WriteLine("5.  Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. ");
            Console.WriteLine("6.  Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. ");
            Console.WriteLine("7.  (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor.");
            Console.WriteLine("8.  (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.  ");
            Console.WriteLine("9.  Afisati toti divizorii numarului n. ");
            Console.WriteLine("10. Test de primalitate: determinati daca un numar n este prim.");
            Console.WriteLine("11. Afisati in ordine inversa cifrele unui numar n. ");
            Console.WriteLine("12. Determinati cate numere intregi divizibile cu n se afla in intervalul [a, b].");
            Console.WriteLine("13. Determinati cati ani bisecti sunt intre anii y1 si y2");
            Console.WriteLine("14. Determinati daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. ");
            Console.WriteLine("15. Se dau 3 numere. Sa se afiseze in ordine crescatoare. ");
            Console.WriteLine("16. Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)");
            Console.WriteLine("17.  Determinati cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. ");
            Console.WriteLine("18. Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2. ");
            Console.WriteLine("19. Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. ");
            Console.WriteLine("20. Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3).");
            Console.WriteLine("21. Ghiciti un numar intre 1 si 1024 prin intrebari de forma 'numarul este mai mare sau egal decat x ? '. ");
            Console.Write("\r\nAlege o problema : ");

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        float a, b;
                        Console.WriteLine("a = ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("b = ");
                        b = Convert.ToInt32(Console.ReadLine());
                        float value = (-b) / a;
                        Console.WriteLine(value);
                        return false;
                    }
                case "2":
                    {
                        Console.WriteLine("Dati a ,b si c :");
                        double a = double.Parse(Console.ReadLine());
                        double b = double.Parse(Console.ReadLine());
                        double c = double.Parse(Console.ReadLine());
                        double delta = b * b - 4 * a * c;
                        if (delta > 0)
                        {
                            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                            Console.WriteLine("x poate lua valorile x1 si x2");

                        }
                        else
                            if (delta == 0)
                        {
                            double x3 = -b / (2 * a);
                            Console.WriteLine("x are valoarea x3 ");
                        }
                        else
                        {
                            Console.WriteLine("Ecuatia nu are solutii in R");
                        }
                        return false;
                    }
                case "3":
                    {
                        int n, k;
                        n = Convert.ToInt32(Console.ReadLine());
                        k = Convert.ToInt32(Console.ReadLine());
                        if (n % k == 0)
                            Console.WriteLine("N se divide cu k");
                        else
                            Console.WriteLine("N nu se divide cu k");
                        Console.WriteLine();
                        return false;
                    }
                case "4":
                    {
                        Console.WriteLine("Alegeti un an :");
                        int y = int.Parse(Console.ReadLine());
                        if (y % 4 == 0)
                        {
                            if (y % 100 == 0 && y % 400 == 0)
                                Console.WriteLine(y + " este an bisect");
                            else if (y % 100 == 0)
                                Console.WriteLine(y + " nu este an bisect");
                            else Console.WriteLine(y + " este an bisect");
                        }
                        else
                            Console.WriteLine(y + " nu este an bisect");
                        return false;
                    }
                case "5":
                    {
                        int n, k;
                        Console.WriteLine("Alegeti n: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Alegeti k: ");
                        k = Convert.ToInt32(Console.ReadLine());
                        while (k != 1)
                        {
                            n /= 10;
                            k--;
                        }
                        Console.WriteLine(n % 10);
                        return false;
                    }
                case "6":
                    {
                        int a, b, c;
                        Console.WriteLine("Alegeti valorile laturilor: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        c = Convert.ToInt32(Console.ReadLine());
                        if (a > 0 && b > 0 && c > 0)
                        {
                            if (a + b > c || a + c > b || b + c > a)
                                Console.WriteLine("Valorile date pot fi laturi a unui triunghi");
                        }
                        else
                            Console.WriteLine("Valorile date nu pot fi laturi a unui triunghi");
                        
                            return false;
                    }
                case "7":
                    {
                        Console.WriteLine("Dati doua variabile a si b :");
                        int a = int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        int aux = a;
                        a = b;
                        b = aux;
                        Console.WriteLine($" {a}, {b}");
                        return false;
                    }
                case "8":
                    {
                        int a, b;
                        Console.WriteLine("Introduceti a:");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduceti b:");
                        b = Convert.ToInt32(Console.ReadLine());
                        a = a + b;
                        b = a - b;
                        a = a - b;
                        Console.WriteLine(a + " " + b);
                        Console.ReadKey();
                        return false;
                    }
                case "9":
                    {
                        float n;
                        Console.WriteLine("n: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 2; i <= n; i++)
                            if (n % i == 0)
                                Console.WriteLine(i);
                        Console.ReadKey();
                        return false;
                    }
                case "10":
                    {
                        int n, aux = 0;
                        Console.WriteLine("n: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 2; i < n; i++)
                            if (n % i == 0)
                                aux = 1;
                        if (aux == 0)
                        {

                            Console.WriteLine("Numarul este prim");
                        }
                        else
                            Console.WriteLine("Numarul nu este prim");
                        Console.ReadKey();
                        return false;
                    }
                case "11":
                    {
                        Console.Write("n= ");
                        int n, aux = 0;
                        n = Convert.ToInt32(Console.ReadLine());
                        while (n != 0)
                        {
                            aux = aux * 10 + n % 10;
                            n /= 10;
                        }
                        Console.WriteLine(aux);
                        Console.ReadKey();
                        return false;
                    }
                case "12":
                    {
                        Console.WriteLine("Dati limitele intervalului : ");
                        int a, b, n, aux = 0;
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Dati n: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        for (int i = a; i <= b; i++)
                        {
                            if (i % n == 0)
                                aux++;
                        }
                        Console.WriteLine(aux);
                        Console.ReadKey();
                        return false;
                    }
                case "13":
                    {
                        Console.WriteLine("Dati anii intervalului : ");
                        int y1 = int.Parse(Console.ReadLine());
                        int y2 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (y1 > y2)
                        {
                            y1 = y1 - y2;
                            y2 = y1 + y2;
                            y1 = y2 - y1;
                        }
                        int i = y1;
                        while (i <= y2)
                        {
                            if (i % 4 == 0)
                            {
                                if (i % 100 == 0 && i % 400 == 0)
                                    Console.WriteLine(i);
                                else if (i % 100 == 0)
                                    Console.Write("");
                                else Console.WriteLine(i);
                            }
                            i++;
                        }
                        return false;
                    }
                case "14":
                    {
                        int n, aux = 0, aux1;
                        Console.WriteLine("n: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        aux1 = n;
                        while (aux1 != 0)
                        {
                            aux = aux * 10 + aux1 % 10;
                            aux1 /= 10;
                        }
                        if (aux == n)
                            Console.WriteLine("Numarul este palindrom");
                        else
                            Console.WriteLine("Numarul nu este palindrom");
                        Console.ReadKey();
                        return false;
                    }
                case "15":
                    {
                        int a, b, c, aux = 0;
                        Console.WriteLine("a: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("b: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("c: ");
                        c = Convert.ToInt32(Console.ReadLine());
                        if (a > b)
                        {
                            aux = b;
                            b = a;
                            a = aux;
                        }
                        if (a > c)
                        {
                            aux = c;
                            c = a;
                            a = aux;
                        }
                        if (b > c)
                        {
                            aux = c;
                            c = b;
                            b = aux;
                        }
                        Console.WriteLine(a + " " + b + " " + c);
                        Console.ReadKey();
                        return false;
                    }
                case "16":
                    {
                        int a, b, c, d, e, aux = 0;
                        Console.WriteLine("a: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("b: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("c: ");
                        c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("d: ");
                        d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("e: ");
                        e = Convert.ToInt32(Console.ReadLine());
                        if (a > b)
                        {
                            aux = a;
                            a = b;
                            b = aux;

                        }
                        if (a > c)
                        {
                            aux = a;
                            a = c;
                            c = aux;

                        }
                        if (a > d)
                        {
                            aux = a;
                            a = d;
                            d = aux;

                        }
                        if (a > e)
                        {
                            aux = a;
                            a = e;
                            e = aux;

                        }
                        if (b > c)
                        {
                            aux = b;
                            b = c;
                            c = aux;

                        }
                        if (b > d)
                        {
                            aux = b;
                            b = d;
                            d = aux;

                        }
                        if (b > e)
                        {
                            aux = b;
                            b = e;
                            e = aux;

                        }
                        if (c > d)
                        {
                            aux = c;
                            c = d;
                            d = aux;

                        }
                        if (c > e)
                        {
                            aux = c;
                            c = e;
                            e = aux;

                        }
                        if (d > e)
                        {
                            aux = d;
                            d = e;
                            e = aux;

                        }
                        Console.WriteLine(a + " " + b + " " + c + " " + d + " " + e);
                        Console.ReadKey();

                        return false;
                    }
                case "17":
                    {
                        Console.WriteLine("Dati 2 numere : ");
                        int a, b, r, p;
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        while (a != b)
                        {
                            if (a > b)
                                a -= b;
                            else
                                b -= a;
                        }
                        Console.WriteLine(a);
                        r = a % b;
                        p = a * b;
                        while (r != 0)
                        {
                            a = b;
                            b = r;
                            r = a % b;
                        }
                        r = p / b;
                        Console.WriteLine(r);
                        Console.ReadKey();
                        return false;

                    }
                case "18":
                    {
                        Console.Write("Dati n = ");
                        int n = int.Parse(Console.ReadLine());
                        int d = 2;
                        int p;
                        while (n > 1)
                        {

                            p = 0;
                            while (n % d == 0)
                            {
                                ++p;
                                n /= d;
                            }
                            if (p != 0)
                                Console.Write(d + "^" + p + " x ");
                            ++d;
                            if (n > 1 && d * d > n)
                            {
                                d = n;
                            }
                        }
                        return false;

                    }
                case "19":
                    {
                        Console.WriteLine("Dati un numar :");
                        int n = int.Parse(Console.ReadLine());
                        int a;
                        int b;
                        int cn = n;
                        a = n % 10;
                        while (n != 0)
                        {
                            if (n % 10 != a)
                            {
                                b = n % 10;
                                break;
                            }
                            n /= 10;
                        }                        
                        bool ok = true;
                        while(n!=0)
                        {
                            if ( n % 10 != b || n % 10 != a )
                                ok = false;
                            n /= 10;
                        }
                        if (ok)
                            Console.WriteLine($"Numarul {cn} este scris doar cu doua cifre");
                        else
                            Console.WriteLine($"Numarul {cn} nu este scris doar cu doua cifre");
                        
                        return false;
                    }
                case "20":
                    {
                        Console.Write("Cititi numaratorul : ");
                        int m = int.Parse(Console.ReadLine());
                        Console.Write("Cititi numitorul : ");
                        int n = int.Parse(Console.ReadLine());
                        Console.Write($"{m / n},");
                        int parteFract = m % n;
                        int cifra, rest;
                        List<int> resturi = new List<int>();
                        List<int> cifre = new List<int>();
                        resturi.Add(parteFract);
                        bool periodic = false;
                        do
                        {
                            cifra = parteFract * 10 / n;
                            cifre.Add(cifra);
                            rest = parteFract * 10 % n;
                            if (!resturi.Contains(rest))
                            {
                                resturi.Add(rest);
                            }
                            else
                            {
                                periodic = true;
                                break;
                            }
                            parteFract = rest;
                        } while (rest != 0);

                        if (!periodic)
                        {
                            foreach (int item in cifre)
                            {
                                Console.Write(item);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < resturi.Count; i++)
                            {
                                if (resturi[i] == rest)
                                {
                                    Console.Write("(");
                                }
                                Console.Write(cifre[i]);
                            }
                            Console.WriteLine(")");
                        }

                        return false;
                    }
                case "21":
                    {
                        Random rnd = new Random();
                        int a = rnd.Next(1, 1025);
                        int x = -1;
                        while (x != a)
                        {
                            Console.WriteLine("Citeste un numar x :");
                            x = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Numarul este mai mare sau egal cu {x} ? ");
                            if (x == a)
                            {
                                Console.WriteLine($"Numarul este {x} ");
                                break;
                            }
                            else
                                if (x < a)
                            {
                                Console.WriteLine("Da");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("Nu");
                                Console.WriteLine();
                            }
                        }
                        return false;
                    }
                default:
                    {
                        Console.WriteLine("Nu ati ales nicio problema din cele enumerate mai sus ");
                        return false;
                    }
            }

        }

    }
}