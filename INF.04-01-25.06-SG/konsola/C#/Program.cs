using System;

namespace LoteriaLiczbowa
{
    class Program
    {
        const int dlugoscZestawu = 6;
        const int minLiczba = 1;
        const int maxLiczba = 49;

//      **********************************************
//      nazwa funkcji:        GenerujZestawy
//      opis funkcji:         Generuje zestawy losowych liczb, gdzie pojedyńczy wiersz
//                            reprezentuje zestaw 6 losowych niepowtarzających się liczb.
//      parametry:            iloscZestawow - ilość zestawow liczb która powinna być wylosowana.
//      zwracany typ i opis:  int[,] - wylosowane zestawy liczb w postaci
//                                     tablicy dwuwymiarowej.
//      autor:                Wiktor Czernik
//      ***********************************************
        static int[,] GenerujZestawy(int iloscZestawow)
        {

            Random rnd = new Random();
            int[,] zestawy = new int[iloscZestawow, dlugoscZestawu];

            // Indeks zestawu nad którym działamy aktualnie.
            for (int indeksZestawu = 0; indeksZestawu < iloscZestawow; indeksZestawu++)
            {
                // Ile wylosowano liczb w bieżącym zestawie.
                int ileWylosowano = 0;
                while (ileWylosowano < 6)
                {
                    int wylosowana = rnd.Next(minLiczba, maxLiczba+1);
                    bool czyNowa = true;
                    
                    // Sprawdzamy czy liczba którą wylosowaliśmy
                    // znajduje się już w bieżącym zestawie przechodząć
                    // przez poprzednio wylosowane liczby.
                    for (int i = 0; i < ileWylosowano; i++)
                    {
                        if (zestawy[indeksZestawu, i] == wylosowana)
                        {
                            czyNowa = false;
                            break;
                        }
                    }

                    if (czyNowa)
                    {
                        zestawy[indeksZestawu, ileWylosowano] = wylosowana;
                        ileWylosowano++;
                    }
                }
            }

            return zestawy;
        }
        static void WyswietlZestawy(int[,] zestawy)
        {
            int[] wystapienia = new int[50];

            Console.WriteLine("Zestawy wylosowanych liczb:");
            for (int i = 0; i < zestawy.GetLength(0); i++)
            {
                Console.Write($"Losowanie {i + 1}:");
                for (int j = 0; j < dlugoscZestawu; j++)
                {
                    int liczba = zestawy[i, j];
                    Console.Write($" {liczba}");
                    wystapienia[liczba]++;
                }
                Console.WriteLine();
            }
            for (int k = 1; k <= 49; k++)
            {
                int ilosc = wystapienia[k];
                Console.WriteLine($"Wystąpienia liczby {k}: {ilosc}");
            }
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("Ile wygenerować losowań?");
            int iloscZestawow = int.Parse(Console.ReadLine());

            int[,] zestawy = GenerujZestawy(iloscZestawow);
            WyswietlZestawy(zestawy);
        }
    }
}
