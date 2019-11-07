using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALBER
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("\n\nVajuta ülesande number: \n");
                Console.WriteLine("1 - Korrutustabel (15 x 15)\n");
                Console.WriteLine("2 - Ülesanne 2\n");
                Console.WriteLine("3 - Ülesanne 3\n");
                Console.WriteLine("4 - Ülesanne 4 Kodutöö 7.1\n");
                Console.WriteLine("5 - Ülesanne 5 Kodutöö 7.2\n");
                Console.WriteLine("6 - Lauses Sõnade lugeja ja järjestaja\n");
                Console.WriteLine("7 - BIN TO DEC 7\n");
                Console.WriteLine("8 - HEX TO DEC 8\n");
                Console.WriteLine("9 - DEC TO OCT 9\n");
                Console.WriteLine("a - HEX TO DEC a\n");
                char c = Console.ReadKey().KeyChar;
                if (c == '1') YL01();
                else if (c == '2') YL02();
                else if (c == '3') YL03();
                else if (c == '4') YL04();
                else if (c == '5') YL05();
                else if (c == '6') YL06();
                else if (c == '7') YL07();
                else if (c == '8') YL08();
                else if (c == '9') YL09();
                else if (c == 'a') YL10();
                else break;
            }
            while (true);
            Console.WriteLine("");
        }
        static void YL01()        // x on rea number (rn) ja y on veeru number (vn)
        {           
            int[,] tab = new int[18, 16];

            int xarv = tab.GetLength(0); //saab rea ehk x suuruse
            int yarv = tab.GetLength(1); // saab veeru ehk y suuruse

            Console.Write("\nMassiivi {0}x{1} väljatrükk\n", xarv - 1, yarv - 1);

            for (int y = 1; y < yarv; y++)
            {
                for (int x = 1; x < xarv; x++)
                {
                    tab[x, y] = x * y;
                    Console.Write("{0,4}", tab[x, y]);
                }
                Console.WriteLine("");
            }

            // natuke teistsugune
            //for (int y = 1; y <= 15; y++)
            //{
            //    for (int x = 1; x <= 15; x++)
            //    {
            //        if (y == 0)
            //        {
            //        }
            //        else
            //        {
            //            Console.Write("{0}\t", y * x); // \t tekitab vahed
            //        }               
            //    }
        }

        static void YL02()
        {
            Console.WriteLine(" \nÜlesanne 2\n");
            // peab olema 10 x 10 massiiv
            // tehtud olema juhuslikest arvudest vahemikus[10 - 99]
            // diagonaalid peavad olema 0
            // pean lõpuks leidma selle asukoha
         
            Random rnd = new Random();
            int[,] tab = new int[10, 10]; // peavad olema ühesugused, et töötaks

            int xarv = tab.GetLength(0); //saab rea ehk x suuruse
            int yarv = tab.GetLength(1); // saab veeru ehk y suuruse
            Console.Write("\nMassiivi {0}x{1} väljatrükk\n", xarv, yarv);
  
            for (int y = 0; y < yarv; y++)
            {
                for (int x = 0; x < xarv; x++)
                {
                    tab[x, y] = rnd.Next(10, 100);
                }
            }
            for (int y = 0; y < yarv; y++)
            {
                tab[y, y] = 0;
                tab[y, (xarv - 1) - y] = 0;
            }

            int max = tab[0, 0];
            
            for (int y = 0; y < yarv; y++)
            {
                for (int x = 0; x < xarv; x++)
                {
                    if (tab[x, y] > max) max = tab[x, y];
                    
                }
            }

            for (int y = 0; y < yarv; y++)
            {
                for (int x = 0; x < xarv; x++)
                {                   
                    Console.Write("{0,4}", tab[x, y]);
                }
                Console.WriteLine("");
                for (int x = 0; x < xarv; x++)
                {
                    if (tab[x, y] == max)
                    {
                        Console.Write("  --");
                        
                    }                                      
                    else Console.Write("    ");
                }                
                Console.WriteLine("");           
            }
            Console.WriteLine("Maximaalne arv on " + max);
        }

        static void YL03()
        {
            Console.WriteLine(" \nÜlesanne 3\n");
            // 2D massiiv 15X20 arvud vahemikus 10 - 50 tehtud
            //ja formeerida uus matrix massiiv, mis on tagurpidi(iga rida)
            // on vaja iga rida vastupidises, et tagumised arvud oleks nüüd ees 

            Random rnd = new Random();
            int[,] tab = new int[15, 20];

            int xarv = tab.GetLength(0); //saab rea ehk x suuruse
            int yarv = tab.GetLength(1); // saab veeru ehk y suuruse

            for (int y = 0; y < yarv; y++)
            {
                for (int x = 0; x < xarv; x++)
                {
                    tab[x, y] = rnd.Next(10, 51);
                }
            }
            
            Console.WriteLine("Originaal");
            for (int y = 0; y < yarv; y++)
            {
                for (int x = 0; x < xarv; x++)
                {
                    Console.Write("{0,4}", tab[x, y]);
                }
                Console.WriteLine("");
            }
            MatrixPrint(tab);
        }

        static void MatrixPrint(int[,] arr) // Ül. 3
        {
            int xarv = arr.GetLength(0);
            int yarv = arr.GetLength(1);
            
            Console.Write("\nMatrix {0}x{1} väljatrükk\n", xarv, yarv);
            for (int y = 0; y < yarv; y++)
            {
                for (int x = xarv - 1; x >= 0; x--)
                {
                    Console.Write("{0,4}", arr[x, y]);
                }
                Console.WriteLine("");
            }
        }
        
        static void YL04() // 7.1
        {
            int n, nRuut, summa;
            summa = 0;
            Console.WriteLine(" Sisesta arv ja vajuta enter klahvi");            
            n = Convert.ToInt32(Console.ReadLine());
            
            for (int k = 1; k <= n; k++)
            {
                nRuut = k * k;
                summa = summa + nRuut;
            }
            Console.WriteLine("S on " + summa + " ühikut");           
        }

        static void YL05() // 7.2
        {
            int n;
            Console.WriteLine(" Sisesta arv ja vajuta enter klahvi");
            n = Convert.ToInt32(Console.ReadLine());
            for (int y = 1; y <= n; y++)
            {
                for (int x = 1; x <= n; x++)
                {                   
                    if(x<=y-1)
                    {
                        Console.Write("{0,4}",0);
                    }
                    else
                    Console.Write("{0,4}", y);
                }
                Console.WriteLine("");
            }
        }
        static void YL06()
        {

            // Kõigepealt peab tulema input     
            // loeb kokku tühikud stringis
            // teen loopi üle stringi ja võrdlen iga sümbolit tühikuga
            // kui on tühik lisan loendurisse 1

            // Saab valida, kas kirjutatakse ise lause või kasutatakse näidis lauset
            string tekst;
            // test
            tekst ="    Jänes jooksis    üle pika    musta tee  koos kartuliga    ";
            string t = " " + tekst + " ";
            // /test
            int lugeja = 0;

            Console.WriteLine(" Sisesta suvaline märk ja vajuta enter klahvi");
            tekst = Convert.ToString(Console.ReadLine());
            //string t = " " + tekst + " "; // kasutaja saab ise selle abil lauseid teha


            for (int i = 1; i < t.Length; i++) 
            {
                if (t[i - 1] == ' ' && t[i] != ' ') lugeja++;
            }
            Console.WriteLine(t);
            Console.WriteLine("Sõnu on {0}", lugeja); //Lugeja vaatab mitu sõna on
            
            // Paneb kõik sõnad uuele reale
            string[] sonad = new string[lugeja];
            int n = 0;
            int k = 0;

            do
            {
                
                while (t[k] == ' ' && k < t.Length - 1) k++;
                if (t[k] == ' ') break;
                sonad[n] = "";
                while (t[k] != ' ')
                {
                    sonad[n] += t[k];
                    k++;
                }
                Console.WriteLine(sonad[n]);
                n++;
            } while (true);

            //Järjestab sõnad pikemast lühemani
            bool tunnus;           
            do
            {
                tunnus = false;
                for (int i1 = 0; i1 < lugeja - 1; i1++)
                {
                    int i2 = i1 + 1;
                    
                    if (sonad[i1].Length < sonad[i2].Length)
                    {
                        string temp = sonad[i1];
                        sonad[i1] = sonad[i2];
                        sonad[i2] = temp;
                        tunnus = true;
                    }                    
                }                
            }
            while (tunnus == true);
            Console.WriteLine("Järjestab sõnad pikkuse järjekorras:");
            for (int i = 0; i < lugeja; i++)
            {               
                Console.Write(" " + sonad[i]);
            }           
        }
        static void YL07() // BIN TO DEC
        {
            // Arvu sisestus
            string sisend;
            bool oigearv;

            Console.WriteLine(" Sisesta arv kahendsüsteemis (0) ja (1)");
            sisend = Console.ReadLine();
            int k = sisend.Length;
            // Võtab vastu õiged arvud
            do
            {
                oigearv = true;
                for (int i = 0; i < sisend.Length - 1 && oigearv; i++)
                {
                    if (sisend[i] != '0' && sisend[i] != '1')
                    {
                        oigearv = true;
                        Console.WriteLine("Ainult 0 ja 1 on kahendsüsteemis lubatud");
                        break;                        
                    }
                }
                
            } while (oigearv == false);
            
            int dec = 0;
            int kaal = 1;
            Console.WriteLine("Sa sisestasid arvu {0}", sisend);
            // Teisendab arvu valemi abil ja prindib välja
            for (int i = k-1; i >= 0; i--)
            {
                byte n = Convert.ToByte(sisend[i].ToString());
                dec += n * kaal;
                kaal *= 2;              
            }
            
            Console.WriteLine("Kümnendarv on {0}", dec);
            // Teine variant arvutamiseks
            Console.WriteLine("\nTeine variant arvutamiseks: ");
            dec = 0;
            for (int i= 0; i < k; i++)
            {
                byte n = Convert.ToByte(sisend[i].ToString());
                dec = dec * 2 + n;             
            }
            Console.WriteLine("Kümnendarv on {0}", dec);
        }
        static void YL08() // HEX TO DEC
        {
            Console.WriteLine("HEX TO DEC");
            //1. Võtab vastu õiged arvud tehtud
            //2. Teisendab tähed numbriteks
            //3. Arvutab välja
            string sisend;
            bool oigearv;
            // Arvu sisestamine
            Console.WriteLine(" Sisesta arv HEX süsteemis ");
            sisend = Console.ReadLine();
            int k = sisend.Length;
            int[] arv = new int[sisend.Length];
            int summa = 0;
            int power = sisend.Length - 1;
            int y = 0;
            // Võtab vastu õiged arvud // Ei võta praegu

            //if (sisend[i] != '0' && sisend[i] != '1' && sisend[i] != '2' && sisend[i] != '3' && sisend[i] != '4' && sisend[i] != '5' && sisend[i] != '6' && sisend[i] != '7'
            //    && sisend[i] != '8' && sisend[i] != '9' && sisend[i] != 'A' && sisend[i] != 'B' && sisend[i] != 'C' && sisend[i] != 'D' && sisend[i] != 'E' && sisend[i] != 'F'
            //    && sisend[i] != 'a' && sisend[i] != 'b' && sisend[i] != 'c' && sisend[i] != 'd' && sisend[i] != 'e' && sisend[i] != 'f')
            do
            {
                oigearv = true;
                for (int i = 0; i < sisend.Length - 1 && oigearv; i++)
                {
                    char t = sisend[i];
                    if (t != '0' && t != '9')
                    {
                        y = t - '0';
                    }
                    else if (t != 'A' && t != 'F')
                    {
                        y = t - 'A' + 10;
                    }
                    else if (t != 'a' && t != 'f')
                    {
                        y = t - 'a' + 10;
                    }
                    else
                    {
                        oigearv = true;
                        Console.WriteLine("Ainult 0;1;2;3;4;5;6;7;8;9;A;B;C;D;E;F;a;b;c;d;e;f; on HEX süsteemis lubatud lubatud");
                        return;
                    }                 
                }
            } while (oigearv == false);
            // Täht arvuks
            int n = 0;
            for (int i = 0; i < k; i++)
            {
                char c = sisend[i];
                if (c >= '0' && c <= '9')
                {
                    n = c - '0';
                }
                else if (c >= 'A' && c<= 'F')
                {
                    n = c - 'A' + 10;
                }
                else if (c >= 'a' && c <= 'f')
                {
                    n = c - 'a' + 10;
                }
                // vastus
                summa = summa * 16 + n;
            }
            Console.WriteLine("Sa sisestasid arvu {0}", sisend);
            Console.WriteLine("HEX arv DEC süsteemis on {0}", summa);
        }
        static void YL09()
        {
            Console.WriteLine("DEC TO OCT");
            // Arvu sisestamine
            Console.WriteLine(" Sisesta arv DEC süsteemis ");
            int dec = Convert.ToInt32(Console.ReadLine());           
            Console.WriteLine("Sa sisestasid arvu {0}", dec);
            // Teisendab arvu valemi abil ja prindib välja
            string oct = "";
            do
            {
                string c = (dec % 8).ToString();
                oct = c + oct;
                dec /= 8;
            } while (dec > 0);
            Console.WriteLine("OCT on {0}", oct);
        }
        static void YL10()
        {
            Console.WriteLine(" DEC TO HEX");
            Console.WriteLine(" Sisesta arv DEC süsteemis ");
            int dec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sa sisestasid arvu {0}", dec);
            string hex = "";
            char c;
            // Arvutab välja
                do
                {
                    int i = dec % 16;
                    if (i < 10)
                    {
                        c = (char)('0' + i);
                    }
                    else
                    c = (char)('A' + i - 10);
                hex = c + hex;
                dec /= 16;
            } while (dec > 0);          
            Console.WriteLine("DEC arv HEX süsteemis on {0}", hex);
        }
    }           
}
