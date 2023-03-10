/*
    02.Buatlah program pencarian bagi dua berdasarkan langkah langkah yang
    telah dijelaskan diatas
*/

using System;

class Prak2 {
    static int pbagidua(int[] arr, int kiri, int kanan, int cari) {
        if (kanan >= kiri) {
            int tengah = kiri + (kanan - kiri) / 2;

            if (arr[tengah] == cari){
                return tengah;
            }

            if (arr[tengah] > cari){
                return pbagidua(arr, kiri, tengah - 1, cari);
            }
            else{
                return pbagidua(arr, tengah + 1, kanan, cari);
            }
        }

        return -1;
    }

    static void Main() {
        int[] arr = {5,7,10,13,14,17};
        int batasan = arr.Length;
        int cari = 13;
    
        int hasil = pbagidua(arr, 0, batasan - 1, cari);

        if (hasil == -1)
            Console.WriteLine("nilai yang dicari tidak ada dalam array");
        else
            Console.WriteLine("nilai yang dicari ada dalam array di indeks {0}",hasil);
    }
}

/*
 Fungsi di atas merupakan implementasi algoritma binary search (pencarian biner) untuk mencari suatu elemen dalam array yang sudah terurut. Algoritma ini bekerja dengan cara membagi array menjadi dua bagian, kemudian memeriksa apakah nilai yang dicari berada di bagian kiri atau bagian kanan dari titik pembagian tersebut.

Fungsi pbagidua memiliki empat parameter, yaitu:

arr : Array yang akan dicari
kiri : Indeks pertama dari bagian array yang akan dicari
kanan : Indeks terakhir dari bagian array yang akan dicari
cari : Nilai yang dicari dalam array
Fungsi pbagidua mengembalikan nilai indeks elemen yang ditemukan dalam array jika ditemukan, dan -1 jika nilai yang dicari tidak ditemukan dalam array.

Berikut adalah langkah-langkah algoritma binary search yang dilakukan dalam fungsi pbagidua:

Cek apakah kanan >= kiri. Jika tidak, kembalikan nilai -1 karena elemen yang dicari tidak ditemukan dalam array.
Hitung tengah sebagai (kiri + kanan) / 2
Jika arr[tengah] sama dengan cari, maka elemen ditemukan dan kembalikan nilai tengah.
Jika arr[tengah] lebih besar dari cari, maka cari di bagian kiri dari tengah dengan melakukan pemanggilan rekursif ke pbagidua dengan parameter kiri, tengah-1, dan cari.
Jika arr[tengah] lebih kecil dari cari, maka cari di bagian kanan dari tengah dengan melakukan pemanggilan rekursif ke pbagidua dengan parameter tengah+1, kanan, dan cari.
Jika elemen tidak ditemukan dalam array, kembalikan nilai -1.
*/
