// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main(string[] args)
    {
        //Buat variabel bernama "nama","kelas" tipe string dan "absen" dengan tipe data "int"
        string nama = "jauharil fathoni naufaldi";
        int absen = 8;
        string kelas = "xi rpl 3";
        //Untuk mengeluarkan nilai atau mencetak teks dalam C#
        Console.WriteLine("Nama:" + nama);
        Console.WriteLine("absen:" + absen);
        Console.WriteLine("kelas" + kelas);
        Console.WriteLine("bocchibocchibocchibocchibocchibocchibocchibocchibocchibocchibocchibocchibocchibocchibocchibocchi");
        //tujuan nya untuk menyimpan data alas,tinggi,luas
        int alas,tinggi, luas;
        int bagi = 2;
        //Console.ReadLine() itu fungsinya Menunggu user mengetik sesuatu dan tekan ENTER Nilai yang dibaca adalah string
        //Convert.ToInt32(...)funginya Mengubah string tadi jadi integer Misalnya user ketik 10 ➜ jadi int 10
        Console.Write("Masukkan panjang alas: ");
        alas = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukkan panjang tinggi: ");
        tinggi = Convert.ToInt32(Console.ReadLine());
        //dibawah ini fungsi nya untuk memproses data yang telah diinputkan
        luas =  alas * tinggi / bagi ;
        //dibawah ini difungsikan untuk menuliskan hasil yang telah dihitung
        Console.WriteLine("Luas segitiga = " + luas);
    }
}