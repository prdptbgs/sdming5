/*
01.Buat program untuk menghapus atau mengubah sebuah data di dalam sekumpulan
nilai, langkah pertama yang harus ditempuh adalah mencari data tersebut, lalu
menghapus atau mengubahnya dengan menggunakan metode pencarian beruntun
*/

// jawab 

using System;
class Eval1
{
    // Fungsi untuk mencari indeks data dalam sebuah array
    static int cariindeks(int[] arr, int nilai)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == nilai)
            {
                return i;
            }
        }
        return -2;
    }

    static void Main()
    {
        int[] arr = {12,34,23,45,37,87,54};
        int cari,hasil;

        Console.Write("masukkan nilai yang ingin dihapus : ");
        cari = Convert.ToInt32(Console.ReadLine());
        hasil = cariindeks(arr,cari);

     // PROGRAM UNTUK MENGHAPUS NILAI DALAM ARRAY 
        if( hasil != -2){
            for(int i = hasil; i < arr.Length; i++){
                arr[hasil] = arr[hasil+1];
                Array.Resize(ref arr, arr.Length - 1);
            }
            Console.WriteLine("element {0} dalam array telah dihapus ", cari);
            foreach(int i in arr){
                Console.Write(i +" ");
            }
            Console.WriteLine(" ");
        }else {
            Console.WriteLine("nilai yang dicari tidak ada dalam array");
        }

        
        Console.Write("masukkan nilai yang ingin di ubah : ");
        cari = Convert.ToInt32(Console.ReadLine());
        
        int ubah;
        hasil = cariindeks(arr,cari);

        // PROGRAM UNTUK MENGUBAH NILAI DALAM ARRAY 
        if (hasil != -2){
            Console.Write("masukkan nilai perubahan : ");
            ubah = Convert.ToInt32(Console.ReadLine());
            arr[hasil] = ubah;

            Console.WriteLine("nilai {0} dalam array diganti menjadi {1}", cari,ubah);
                foreach(int n in arr){
                    Console.Write(n + " ");
                }
        }else {
            Console.WriteLine("nilai yang dicari tidak ada ");
        }


    }
}

/* pada static int cari indeks dibuat fungsi cariindeks untuk mencari nilai dalam array dengan masukan arr dan nilai 
 yang dicari,lalu pada static void main dibuat array dengan nama arr, int cari untuk masukan 
 dari user nilai apa yang ingin dicari,lalu int hasil untuk menimpan nilai kembalian dari fungsi cariindeks,jika hasil 
 punya nilai selain -2,maka if akan berjalan dan menghapus nilai yang diinginkan dalam array,jika tidak maka akan
 menampilkan "nilai yang dicari tidak ada dalam array, lalu untuk program mengubah user akan diminta memasukkan nilai 
 yang ingin diubah,lalu jika nilai ada dalam array maka program akan meminta user untuk input nilai perubahan,jika sudah 
 program akan mengubah nilai dalam array,jika nilai yang ingin diubah tidak ada dalam array maka akan ditampilkan "nilai
 yang dicari tidak ada"
 */

