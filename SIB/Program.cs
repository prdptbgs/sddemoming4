/*
    buatlah sebuah program dengan fungsi list dengan persyaratan sebagai berikut :

    1.buatlah list yang jumlah elemennya diinnputkan oleh pengguna via keyboard 
    2.elemen list tersebut berisi nama planet yang ada di galaksi 
    3.urutkan list tersebut berdasar sesuai dengan urutan dari A - Z
    4.tampilkan jumlah planet yang diinputkan oleh pengguna 
    5.lakuakn pengecekan planet dengan anam pluto apa ada dalam list
*/


using System;
using System.Collections.Generic;
class program1
{
    static void Main()
    {
        int n;
        string masuklist;
        List<string> planet = new List<string>();

        Console.Write("masukkan jumlah planet : ");
        n = int.Parse(Console.ReadLine());
        for ( int i = 0; i < n; i++){
            Console.Write("masukkan planet ke {0} : ", i+1);
            masuklist = Convert.ToString(Console.ReadLine());
            planet.Add(masuklist);
        }

        planet.Sort();

        Console.WriteLine("planet dalam list : ");
        foreach(string i in planet){
            Console.WriteLine(i);
        }

        Console.WriteLine("jumlah planet input pengguna adalah : {0}",planet.Count());

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