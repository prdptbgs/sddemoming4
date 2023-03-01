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
