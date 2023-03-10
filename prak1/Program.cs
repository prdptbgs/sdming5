/*
    01.Buatlah program pencarian beruntun berdasarkan langkah langkah yang
    telah djelaskan diatas.
*/
using System;
class Prak1
{
    static int pencarianberuntun(int[] arr, int a)
    {
        int n = arr.Length;//untuk batasan perulangan 
        for (int i = 0; i < n; i++)
        {
            if (arr[i] == a)
            {
                return i;// jika nilai yang dicari ada dalam array 
            }
        }
        return -1;// mendakan jika nilai yang dicari tidak ada dalam array 
        
    }

    static void Main()
    {
        int[] data = {20,15,22,14,12,10,24,19,18,16};
        int cari = 0;// nilai di inisialisasi agar tidak mendapat nilai random 

        Console.Write("masukkan nilai yang ingin dicari : ");
        cari = Convert.ToInt32(Console.ReadLine());

        int hasil = pencarianberuntun(data, cari);// memmanggil fungsi yang sudah dibuat diatas 
        if (hasil == -1)
        {
            Console.WriteLine("elemen yang dicari tidak ada");
        }
        else
        {
            Console.WriteLine("elemen yang ada dicari ada di indeks nomor {0} ",hasil );
        }
    }
}