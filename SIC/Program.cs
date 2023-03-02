/*
    "Buatlah sebuah program dengan fungsi LIST dengan persayaratan sebagai berikut :
    
1. buatlah 2 buah list yang jumlah elemenya diinputkan oleh pengguna via keyboard !
2. Elemen list pertama berisi nama Planet yang ada galaksi ! contoh input (Merkurius, Venus, Bumi, Mars, Jupiter, Saturnus, Uranus, Neptunus, pluto.  
3 Elemen list kedua berisi nama jarak planet dari matahari ! contoh input (1000km, 2000km, 3000km, 4000km, 5000km, 7000km, 800km, 9000km)
4. Gabungkan isi 2 list tersebut sehingga jika program dijalankan akan menghasilkan Output
    Merkurius 1000 km, Venus 2000km, Bumi 3000km, Mars 4000km, Jupiter 5000km, Saturnus 6000km, Uranus 7000km, Neptunus 8000km, Pluto 9000km !
5. Tampilkan jumlah planet yang diinputkan oleh pengguna !
6. Tampilkan jumlah jarak planet dari matahariyang diinputkan oleh pengguna !
7. Lakukan pengecekan Planet dengan nama PLUTO apa ada dalam List !
*/
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Input jumlah elemen list dari pengguna
        Console.Write("Masukkan jumlah planet: ");
        int n = int.Parse(Console.ReadLine());

        // varibel untuk menjumlahkan total jarak 
        int temp1,temp = 0;
       

        // Buat dua buah list
        List<string> planet = new List<string>();
        List<int> distance = new List<int>();

        // Input ke list planet 
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Masukkan nama planet ke {i + 1} : ");
            planet.Add(Console.ReadLine());
        }

        // input ke list distance 
        for (int i = 0; i < n; i++){
            Console.Write("masukkan jarak planet {0} ke matahari : ", i+1 );
            temp1 = int.Parse(Console.ReadLine());
            distance.Add(temp1);
            temp += temp1;
        }

        // Gabungkan dua list menjadi satu
        List<string> combinedList = new List<string>();
        for (int i = 0; i < n; i++)
        {
            combinedList.Add(planet[i] + " " + distance[i]);
        }

        // Tampilkan hasil penggabungan
        Console.Write("Hasil penggabungan: ");
        for (int i = 0; i < n; i++){
            Console.WriteLine(combinedList[i]+ "km");
        }


       
        // Tampilkan jumlah planet dan jarak dari matahari yang diinputkan
        Console.WriteLine($"Jumlah planet: {planet.Count}");
        Console.Write("jumlah jarak total semua adalah : {0}",temp);
        Console.WriteLine("km");

        // Pengecekan apakah Pluto ada di dalam list planet
        string cari;
        Console.Write("masukkan planet yang ingin dicari dalam list : ");
        cari = Convert.ToString(Console.ReadLine());
        if(planet.Contains(cari)){
            Console.WriteLine("planet {0} ada dalam list", cari);
        }else{
            Console.WriteLine("planet {0} tidak ada dalam list ",cari);
        }

    }
}
