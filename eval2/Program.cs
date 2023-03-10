/*
   02. Buat program untuk menyisipkan data ke dalam kumpulan data, jika data telah
    ada, maka data tersebut tidak akan disisipkan, selainnya akan disisipkan
    ke dalam kumpulan data tersebut
*/

//  jawab 
using System;
class Eval2
{
    static int cariindeks(int[] arr, int cari){
        for(int i = 0; i < arr.Length; i++){
            if(arr[i] == cari){
                return i;
            }
        }
        return -2;
    }

    static void Main(){
        int[] arr = {12,34,23,15,34,65,89};
        int sisipkan,hasil;
        bool sip = true;

    while(sip){
        Console.Write("masukkan nilai yang ingin disisipkan : ");
        sisipkan = Convert.ToInt32(Console.ReadLine());
        hasil = cariindeks(arr,sisipkan);

        if(hasil == -2){
            Array.Resize(ref arr, arr.Length + 1);
            for (int i = 0; i < arr.Length; i++){
                arr[arr.Length - 1] = sisipkan;
            }
            Console.WriteLine("nilai {0} masuk dalam array : ",sisipkan);
            foreach(int i in arr){
                Console.Write(i + " ");
            }
            sip = false;
        }else {
            Console.WriteLine("nilai {0} sudah ada ",sisipkan);
        }
    }
 }
}


/*
*/