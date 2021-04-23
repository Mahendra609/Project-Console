using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace APK_TOKO
{
    class Coding
    {
        public OleDbConnection kenek;
        public DataSet tabel;
        public OleDbDataAdapter ndas;
        public string sQL;

        public void sambung()
        {
            string konek = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NOTA TOKO.accdb";
            kenek = new OleDbConnection(konek);
        }

        public void bukatabel(string sQL1)
        {
            tabel = new DataSet();
            ndas = new OleDbDataAdapter(sQL1,kenek);
            ndas.Fill(tabel, sQL1);
        }

        public void menuq(int x, int y, string mn1, string mn2, string mn3, string mn4, string mn5, ConsoleColor warna)
        {
            string[] mn = { mn1, mn2, mn3, mn4, mn5 };
            for (int i = 0; i < mn.Length; i++)
            {
                Console.SetCursorPosition(x + (i * y), y);
                Console.Write(mn[i]);
            }
            Console.CursorVisible = false;
            Console.ForegroundColor = warna;
            Console.SetCursorPosition(x, y);
            Console.Write(mn[0]);

            ConsoleKeyInfo tombol;
            int brs = 0;
            do
            {
                tombol = Console.ReadKey();
                switch (tombol.Key)
                {
                    case ConsoleKey.RightArrow:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.SetCursorPosition(x + (brs * y), y);
                        Console.Write(mn[brs]);
                        if (brs == 4)
                        {
                            brs = 0;
                        }
                        else
                        {
                            brs++;
                        }

                        Console.ForegroundColor = warna;
                        Console.SetCursorPosition(x + (brs * y), y);
                        Console.Write(mn[brs]);
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.SetCursorPosition(x + (brs * y), y);
                        Console.Write(mn[brs]);
                        if (brs == 0)
                        {
                            brs = 4;
                        }
                        else
                        {
                            brs--;
                        }

                        Console.ForegroundColor = warna;
                        Console.SetCursorPosition(x + (brs * y), y);
                        Console.Write(mn[brs]);
                        break;
                    case ConsoleKey.Enter:
                        //if (brs == 4)
                        //{
                        //    brs = 5;
                        //    Environment.Exit(0);
                        //    //Console.Clear();
                        //}
                        if (brs == 0)
                        {
                            back(1, 8, Console.WindowWidth - 2, 11, ConsoleColor.Black);
                            kotak(35 + 55, 8, 44 + 55, 10, ConsoleColor.White);
                            kotak(35 + 46, 8, 44 + 45, 10, ConsoleColor.White);
                            kotak(35 + 37, 8, 44 + 36, 10, ConsoleColor.Red);
                            kotak(35 + 27, 8, 44 + 27, 10, ConsoleColor.White);
                            kotak(35 + 18, 8, 44 + 17, 10, ConsoleColor.Red);
                            kotak(35 + 10, 8, 44 + 8, 10, ConsoleColor.White);
                            kotak(35, 8, 44, 10, ConsoleColor.Red);
                            pilihantambah(37, 9, "BELI", "BERAS" , "SABUN" , "BARANG" , "KASIR" , "NOTA" , "KELUAR" , ConsoleColor.Green);
                            back(1, 8, Console.WindowWidth - 2, 11, ConsoleColor.Black);
                        }
                        else if (brs == 1)
                        {
                            //Console.SetCursorPosition(11, 17 + brs);
                            //Console.Write("MENU RUBAH");
                           // rubahpembeli(5, 15);
                            back(1, 8, Console.WindowWidth - 2, 11, ConsoleColor.Black);
                            //kotak(35 + 55, 8, 44 + 55, 10, ConsoleColor.Red);
                            kotak(35 + 46, 8, 44 + 45, 10, ConsoleColor.White);
                            kotak(35 + 37, 8, 44 + 36, 10, ConsoleColor.Red);
                            kotak(35 + 27, 8, 44 + 27, 10, ConsoleColor.White);
                            kotak(35 + 18, 8, 44 + 17, 10, ConsoleColor.Red);
                            kotak(35 + 10, 8, 44 + 8, 10, ConsoleColor.White);
                            kotak(35, 8, 44, 10, ConsoleColor.Red);
                            pilihanrubah(37, 9, "BELI", "BERAS", "SABUN", "BARANG", "KASIR",  "KELUAR", ConsoleColor.Green);
                            back(1, 8, Console.WindowWidth - 2, 11, ConsoleColor.Black);
                        }
                        else if (brs == 2)
                        {
                            //Console.SetCursorPosition(11, 17 + brs);
                            //Console.Write("MENU HAPUS");
                            back(1, 8, Console.WindowWidth - 2, 11, ConsoleColor.Black);
                            //kotak(35 + 55, 8, 44 + 55, 10, ConsoleColor.White);
                            kotak(35 + 46, 8, 44 + 45, 10, ConsoleColor.White);
                            kotak(35 + 37, 8, 44 + 36, 10, ConsoleColor.Red);
                            kotak(35 + 27, 8, 44 + 27, 10, ConsoleColor.White);
                            kotak(35 + 18, 8, 44 + 17, 10, ConsoleColor.Red);
                            kotak(35 + 10, 8, 44 + 8, 10, ConsoleColor.White);
                            kotak(35, 8, 44, 10, ConsoleColor.Red);
                            pilihanhapus(37, 9, "BELI", "BERAS", "SABUN", "BARANG", "KASIR", "KELUAR", ConsoleColor.Green);
                            back(1, 8, Console.WindowWidth - 2, 11, ConsoleColor.Black);
                        }
                        else if (brs == 3)
                        {
                            //Console.SetCursorPosition(11, 17 + brs);
                            //Console.Write("MENU TAMPIL");
                            //tampildata(53, 11 + brs);
                            //tampilpembeli(5, 15 + brs);
                            back(1, 8, Console.WindowWidth - 2, 11, ConsoleColor.Black);
                            kotak(35 + 55, 8, 44 + 55, 10, ConsoleColor.White);
                            kotak(35 + 46, 8, 44 + 45, 10, ConsoleColor.White);
                            kotak(35 + 37, 8, 44 + 36, 10, ConsoleColor.Red);
                            kotak(35 + 27, 8, 44 + 27, 10, ConsoleColor.White);
                            kotak(35 + 18, 8, 44 + 17, 10, ConsoleColor.Red);
                            kotak(35 + 10, 8, 44 + 8, 10, ConsoleColor.White);
                            kotak(35, 8, 44, 10, ConsoleColor.Red);
                            pilihantampil(37, 9, "BELI", "BERAS", "SABUN", "BARANG", "KASIR", "NOTA", "KELUAR", ConsoleColor.Green);
                            back(1, 8, Console.WindowWidth - 2, 11, ConsoleColor.Black);
                        }
                        else if (brs == 4)
                        {
                            Console.SetCursorPosition(11, 17 + brs);
                            Console.Write(" KELUAR");
                            Environment.Exit(0);
                        }
                        break;
                }
            } while (brs != 5);
        }

        public void pilihantambah(int x, int y, string mn1, string mn2, string mn3, string mn4,string mn5,string mn6,string mn7, ConsoleColor warna)
        {

            string[] mn = { mn1, mn2, mn3, mn4, mn5, mn6, mn7 };
            for (int i = 0; i < mn.Length; i++)
            {
                Console.SetCursorPosition((i * y+1)+x,  y);
                Console.Write(mn[i]);
            }
            Console.CursorVisible = false;
            Console.ForegroundColor = warna;
            Console.SetCursorPosition(x, y);
            Console.Write(mn[0]);
           
            ConsoleKeyInfo tombol;
            int brs = 0;
            do
            {
                tombol = Console.ReadKey();
                switch (tombol.Key)
                {
                    case ConsoleKey.RightArrow:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.SetCursorPosition(x + (brs * y), y);
                        Console.Write(mn[brs]);
                        if (brs == 6)
                        {
                            brs = 0;
                        }
                        else
                        {
                            brs++;
                        }

                        Console.ForegroundColor = warna;
                        Console.SetCursorPosition(x + (brs * y), y);
                        Console.Write(mn[brs]);
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.SetCursorPosition(x + (brs * y), y);
                        Console.Write(mn[brs]);
                        if (brs == 0)
                        {
                            brs = 6;
                        }
                        else
                        {
                            brs--;
                        }

                        Console.ForegroundColor = warna;
                        Console.SetCursorPosition(x + (brs * y), y);
                        Console.Write(mn[brs]);
                        break;
                    case ConsoleKey.Enter:
                        //if (brs == 5)
                        //{
                        //    brs = 6;
                        //   //kotak(35 + 46, 8, 44 + 45, 10, ConsoleColor.White);
                            
                        //}
                         if (brs == 0)
                        {
                            tambahpembeli(Console.WindowWidth / 2, 15);
                            back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                        }
                        else if (brs == 1)
                        {
                            //Console.SetCursorPosition(11, 17 + brs);
                            //Console.Write("tambah beras");
                            tambahberas(Console.WindowWidth / 2, 15);
                            back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                        }
                        else if (brs == 2)
                        {
                            //Console.SetCursorPosition(11, 17 + brs);
                            //Console.Write("tambah sabun");
                            tambahsabun(Console.WindowWidth / 2, 15);
                            back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                        }
                        else if (brs == 3)
                        {
                            //Console.SetCursorPosition(11, 17 + brs);
                            //Console.Write("MENU TAMPIL");
                            //tampildata(53, 11 + brs);
                            //tampilpembeli(5, 15 + brs);
                            tambahbarang(Console.WindowWidth / 2, 15);
                            back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                        }
                        else if (brs == 4)
                        {
                            //Console.SetCursorPosition(11, 17 + brs);
                            //Console.Write(" KASIR ");
                            tambahkasir(Console.WindowWidth / 2, 15);
                            back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                        }
                        else if (brs == 5)
                        {
                            //Console.SetCursorPosition(Console.WindowWidth / 2, 15);
                            //Console.Write(" TRANSAKSI ");
                            back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                            tambahnota(4, 15);
                            back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                        }
                        else if (brs == 6)
                        {
                            //Console.SetCursorPosition(11, 17 + brs);
                            //Console.Write(" KELUAR ");
                            //back(35 + 46, 8, 44 + 45, 10, ConsoleColor.Black);
                            back(35 + 46, 8, 44 + 56, 11, ConsoleColor.Black);
                            menuq(37, 9, "TAMBAH", "RUBAH", "HAPUS", "TAMPIL", "KELUAR", ConsoleColor.Green);
                        }
                        break;
                }
            } while (brs != 7);
        }

        public void pilihantampil(int x, int y, string mn1, string mn2, string mn3, string mn4, string mn5, string mn6, string mn7, ConsoleColor warna)
        {
            string[] mn = { mn1, mn2, mn3, mn4, mn5, mn6, mn7 };
            for (int i = 0; i < mn.Length; i++)
            {
                Console.SetCursorPosition(x + (i * y), y);
                Console.Write(mn[i]);
            }
            Console.CursorVisible = false;
            Console.ForegroundColor = warna;
            Console.SetCursorPosition(x, y);
            Console.Write(mn[0]);

            ConsoleKeyInfo tombol;
            int brs = 0;
            do
            {
                tombol = Console.ReadKey();
                switch (tombol.Key)
                {
                    case ConsoleKey.RightArrow:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.SetCursorPosition(x + (brs * y), y);
                        Console.Write(mn[brs]);
                        if (brs == 6)
                        {
                            brs = 0;
                        }
                        else
                        {
                            brs++;
                        }

                        Console.ForegroundColor = warna;
                        Console.SetCursorPosition(x + (brs * y), y);
                        Console.Write(mn[brs]);
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.SetCursorPosition(x + (brs * y), y);
                        Console.Write(mn[brs]);
                        if (brs == 0)
                        {
                            brs = 6;
                        }
                        else
                        {
                            brs--;
                        }

                        Console.ForegroundColor = warna;
                        Console.SetCursorPosition(x + (brs * y), y);
                        Console.Write(mn[brs]);
                        break;
                    case ConsoleKey.Enter:
                        //if (brs == 4)
                        //{
                        //    brs = 5;
                        //    menuq(37, 9, "TAMBAH", "RUBAH", "HAPUS", "TAMPIL", "KELUAR", ConsoleColor.Green);
                        //}
                        if (brs == 0)
                        {
                            tampilpembeli( 5, 15);
                            back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                        }
                        else if (brs == 1)
                        {
                            //Console.SetCursorPosition(11, 17 + brs);
                            //Console.Write("MENU RUBAH");
                            tampilberas( 5, 15);
                            back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                        }
                        else if (brs == 2)
                        {
                            //Console.SetCursorPosition(11, 17 + brs);
                            //Console.Write("MENU HAPUS");
                            tampilsabun(5, 15);
                            back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                        }
                        else if (brs == 3)
                        {
                            //Console.SetCursorPosition(11, 17 + brs);
                            //Console.Write("MENU TAMPIL");
                            //tampildata(53, 11 + brs);
                            //tampilpembeli(5, 15 + brs);
                            tampilbarang(5, 15);
                            back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                        }
                        else if (brs == 4)
                        {
                            //Console.SetCursorPosition(11, 17 + brs);
                            //Console.Write(" KASIR ");
                            tampilkasir(5, 15);
                            back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                        }
                        else if (brs == 5)
                        {
                            //Console.SetCursorPosition(5, 15);
                            //Console.Write(" TRANSAKSI ");
                            tampilnota(5, 15);
                            back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                        }
                        else if (brs == 6)
                        {
                            //Console.SetCursorPosition(11, 17 + brs);
                            //Console.Write(" KELUAR ");
                            //back(35 + 46, 8, 44 + 45, 10, ConsoleColor.Black);
                            back(35 + 46, 8, 44 + 56, 11, ConsoleColor.Black);
                            menuq(37, 9, "TAMBAH", "RUBAH", "HAPUS", "TAMPIL", "KELUAR", ConsoleColor.Green);
                        }
                        break;
                }
            } while (brs != 7);
        }

        public void pilihanrubah(int x, int y, string mn1, string mn2, string mn3, string mn4, string mn5, string mn6, ConsoleColor warna)
        {
            string[] mn = { mn1, mn2, mn3, mn4, mn5, mn6 };
            for (int i = 0; i < mn.Length; i++)
            {
                Console.SetCursorPosition(x + (i * y), y);
                Console.Write(mn[i]);
            }
            Console.CursorVisible = false;
            Console.ForegroundColor = warna;
            Console.SetCursorPosition(x, y);
            Console.Write(mn[0]);

            ConsoleKeyInfo tombol;
            int brs = 0;
            do
            {
                tombol = Console.ReadKey();
                switch (tombol.Key)
                {
                    case ConsoleKey.RightArrow:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.SetCursorPosition(x + (brs * y), y);
                        Console.Write(mn[brs]);
                        if (brs == 5)
                        {
                            brs = 0;
                        }
                        else
                        {
                            brs++;
                        }

                        Console.ForegroundColor = warna;
                        Console.SetCursorPosition(x + (brs * y), y);
                        Console.Write(mn[brs]);
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.SetCursorPosition(x + (brs * y), y);
                        Console.Write(mn[brs]);
                        if (brs == 0)
                        {
                            brs = 5;
                        }
                        else
                        {
                            brs--;
                        }

                        Console.ForegroundColor = warna;
                        Console.SetCursorPosition(x + (brs * y), y);
                        Console.Write(mn[brs]);
                        break;
                    case ConsoleKey.Enter:
                        //if (brs == 4)
                        //{
                        //    brs = 5;
                        //    menuq(37, 9, "TAMBAH", "RUBAH", "HAPUS", "TAMPIL", "KELUAR", ConsoleColor.Green);
                        //}
                        if (brs == 0)
                        {
                            //tampilpembeli(5, 15);
                            rubahpembeli(5, 15);
                            back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                        }
                        else if (brs == 1)
                        {
                            //Console.SetCursorPosition(11, 17 + brs);
                            //Console.Write("MENU RUBAH");
                            //tampilberas(5, 15);
                            rubahberas(5, 15);
                            back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                        }
                        else if (brs == 2)
                        {
                            //Console.SetCursorPosition(11, 17 + brs);
                            //Console.Write("MENU HAPUS");
                            //tampilsabun(5, 15);
                            rubahsabun(5, 15);
                            back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                        }
                        else if (brs == 3)
                        {
                            //Console.SetCursorPosition(11, 17 + brs);
                            //Console.Write("MENU TAMPIL");
                            //tampildata(53, 11 + brs);
                            //tampilpembeli(5, 15 + brs);
                            //tampilbarang(5, 15);
                            rubahbarang(5, 15);
                            back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                        }
                        else if (brs == 4)
                        {
                            //Console.SetCursorPosition(11, 17 + brs);
                            //Console.Write(" KASIR ");
                            //tampilkasir(5, 15);
                            rubahkasir(5, 15);
                            back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                        }
                        //else if (brs == 5)
                        //{
                        //    Console.SetCursorPosition(5, 15);
                        //    Console.Write(" TRANSAKSI ");
                        //    Console.ReadLine();
                        
                        else if (brs == 5)
                        {
                            //Console.SetCursorPosition(11, 17 + brs);
                            //Console.Write(" KELUAR ");
                            //back(35 + 46, 8, 44 + 45, 10, ConsoleColor.Black);
                            back(35 + 46, 8, 44 + 56, 11, ConsoleColor.Black);
                            menuq(37, 9, "TAMBAH", "RUBAH", "HAPUS", "TAMPIL", "KELUAR", ConsoleColor.Green);
                        }
                        break;
                }
            } while (brs != 6);
        }

        public void pilihanhapus(int x, int y, string mn1, string mn2, string mn3, string mn4, string mn5, string mn6, ConsoleColor warna)
        {
            string[] mn = { mn1, mn2, mn3, mn4, mn5, mn6};
            for (int i = 0; i < mn.Length; i++)
            {
                Console.SetCursorPosition(x + (i * y), y);
                Console.Write(mn[i]);
            }
            Console.CursorVisible = false;
            Console.ForegroundColor = warna;
            Console.SetCursorPosition(x, y);
            Console.Write(mn[0]);

            ConsoleKeyInfo tombol;
            int brs = 0;
            do
            {
                tombol = Console.ReadKey();
                switch (tombol.Key)
                {
                    case ConsoleKey.RightArrow:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.SetCursorPosition(x + (brs * y), y);
                        Console.Write(mn[brs]);
                        if (brs == 5)
                        {
                            brs = 0;
                        }
                        else
                        {
                            brs++;
                        }

                        Console.ForegroundColor = warna;
                        Console.SetCursorPosition(x + (brs * y), y);
                        Console.Write(mn[brs]);
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.SetCursorPosition(x + (brs * y), y);
                        Console.Write(mn[brs]);
                        if (brs == 0)
                        {
                            brs = 5;
                        }
                        else
                        {
                            brs--;
                        }

                        Console.ForegroundColor = warna;
                        Console.SetCursorPosition(x + (brs * y), y);
                        Console.Write(mn[brs]);
                        break;
                    case ConsoleKey.Enter:
                        //if (brs == 4)
                        //{
                        //    brs = 5;
                        //    menuq(37, 9, "TAMBAH", "RUBAH", "HAPUS", "TAMPIL", "KELUAR", ConsoleColor.Green);
                        //}
                        if (brs == 0)
                        {
                            //tampilpembeli(5, 15);
                            //rubahpembeli(5, 15);
                            hapuspembeli(5, 15);
                            back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                        }
                        else if (brs == 1)
                        {
                            //Console.SetCursorPosition(11, 17 + brs);
                            //Console.Write("MENU RUBAH");
                            //tampilberas(5, 15);
                            //rubahberas(5, 15);
                            hapusberas(5, 15);
                            back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                        }
                        else if (brs == 2)
                        {
                            //Console.SetCursorPosition(11, 17 + brs);
                            //Console.Write("MENU HAPUS");
                            //tampilsabun(5, 15);
                            //rubahsabun(5, 15);
                            hapussabun(5, 15);
                            back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                        }
                        else if (brs == 3)
                        {
                            //Console.SetCursorPosition(11, 17 + brs);
                            //Console.Write("MENU TAMPIL");
                            //tampildata(53, 11 + brs);
                            //tampilpembeli(5, 15 + brs);
                            //tampilbarang(5, 15);
                            //rubahbarang(5, 15);
                            hapusbarang(5, 15);
                            back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                        }
                        else if (brs == 4)
                        {
                            //Console.SetCursorPosition(11, 17 + brs);
                            //Console.Write(" KASIR ");
                            //tampilkasir(5, 15);
                            //rubahkasir(5, 15);
                            hapuskasir(5, 15);
                            back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                        }
                        //else if (brs == 5)
                        //{
                        //    Console.SetCursorPosition(5, 15);
                        //    Console.Write(" TRANSAKSI ");
                        //    Console.ReadLine();
                        //}
                        else if (brs == 5)
                        {
                            //Console.SetCursorPosition(11, 17 + brs);
                            //Console.Write(" KELUAR ");
                            //back(35 + 46, 8, 44 + 45, 10, ConsoleColor.Black);
                            back(35 + 46, 8, 44 + 56, 11, ConsoleColor.Black);
                            menuq(37, 9, "TAMBAH", "RUBAH", "HAPUS", "TAMPIL", "KELUAR", ConsoleColor.Green);
                        }
                        break;
                }
            } while (brs != 6);
        }

        //public void pilihnota(int x, int y, string mn1, string mn2, string mn3, string mn4)
        //{
        //    string[] mn = { mn1, mn2, mn3, mn4 };
        //    for (int i = 0; i < mn.Length; i++)
        //    {
        //        Console.SetCursorPosition(x + (i * y), y);
        //        Console.Write(mn[i]);
        //    }
        //    Console.CursorVisible = false;
        //    //Console.ForegroundColor = warna;
        //    Console.SetCursorPosition(x, y);
        //    Console.Write(mn[0]);

        //    ConsoleKeyInfo tombol;
        //    int brs1 = 0;
        //    do
        //    {
        //        tombol = Console.ReadKey();
        //        switch (tombol.Key)
        //        {
        //            case ConsoleKey.RightArrow:
        //                Console.BackgroundColor = ConsoleColor.Black;
        //                Console.ForegroundColor = ConsoleColor.Gray;
        //                Console.SetCursorPosition(x + (brs1 * y), y);
        //                Console.Write(mn[brs1]);
        //                if (brs1 == 3)
        //                {
        //                    brs1 = 0;
        //                }
        //                else
        //                {
        //                    brs1++;
        //                }

        //                //Console.ForegroundColor = warna;
        //                Console.SetCursorPosition(x + (brs1 * y), y);
        //                Console.Write(mn[brs1]);
        //                break;
        //            case ConsoleKey.LeftArrow:
        //                Console.BackgroundColor = ConsoleColor.Black;
        //                Console.ForegroundColor = ConsoleColor.Gray;
        //                Console.SetCursorPosition(x + (brs1 * y), y);
        //                Console.Write(mn[brs1]);
        //                if (brs1 == 0)
        //                {
        //                    brs1 = 3;
        //                }
        //                else
        //                {
        //                    brs1--;
        //                }

        //                //Console.ForegroundColor = warna;
        //                Console.SetCursorPosition(x + (brs1 * y), y);
        //                Console.Write(mn[brs1]);
        //                break;
        //            case ConsoleKey.Enter:
        //                if (brs1 == 0)
        //                {
                            //tampilsabun(70, 14);
                            //Console.CursorVisible = true;
                            //Console.SetCursorPosition(x + 2, y+6);
                            //Console.Write("ID SABUN :");
                            //string idsabun = Console.ReadLine();

                            //Console.SetCursorPosition(x + 2, y + 7);
                            //Console.Write("JUMLAH   :");
                            //int jumlah = int.Parse(Console.ReadLine());

                            //Console.SetCursorPosition(x + 2, y + 8);
                            //Console.Write("LANJUT PEMBELIAN...???[Y/N]:");
                            //string jwbnt = Console.ReadLine();

        //                } break;
        //        }
        //    } while (brs1 != 4);
        //}

        public void tambahnota(int x, int y)
        {
	        tampilnasir(70,14);
	        tampilnali(94,14);
	        kenek.Open();
	        Console.CursorVisible = true;
            bukatabel("Select * from TRANSAKSI Order By NOTA DESC");
	        string nomor =tabel.Tables[0].Rows[0][0].ToString();
	        string nt =Microsoft.VisualBasic.Strings.Right(nomor,4);
	        int nota = int.Parse(nt)+1;
	        string NOTA ="N"+ Microsoft.VisualBasic.Strings.Right("0000"+nota,4);
	
	        Console.SetCursorPosition(x,y);
	        Console.Write("NOTA TRANSAKSI : {0}",NOTA);

	        Console.SetCursorPosition(x,y+1);
	        Console.Write("JAM            : {0}",DateTime.Now.ToShortTimeString());

	        Console.SetCursorPosition(x,y+2);
	        Console.Write("TANGGAL        : {0}",DateTime.Now.ToShortDateString());

	        Console.SetCursorPosition(x,y+3);
	        Console.Write("ID KASIR       : ");
	        string idkasir= Console.ReadLine();

	        Console.SetCursorPosition(x,y+4);
	        Console.Write("ID PEMBELI     :");
            string idpembeli = Console.ReadLine();

            back(70, 14, Console.WindowWidth - 3, Console.WindowHeight - 4, ConsoleColor.Black);

            //back(72, 8, Console.WindowWidth - 3, Console.WindowHeight - 4, ConsoleColor.Black);
            //kotak(35 + 27, 8, 44 + 27, 10, ConsoleColor.White);
            //kotak(35 + 18, 8, 44 + 17, 10, ConsoleColor.Red);
            //kotak(35 + 10, 8, 44 + 8, 10, ConsoleColor.White);
            //kotak(35, 8, 44, 10, ConsoleColor.Red);
            //pilihnota(37, 9, "SABUN", "BERAS", "BARANG", "KEMBALI");

            Console.SetCursorPosition(x + 30, y + 1);
            Console.WriteLine("S=(SABUN) B=(BERAS) L=(LAIN-LAIN)");
            Console.ReadLine();

            Console.SetCursorPosition(x + 30, y);
            Console.Write("MAU BELI :");
            string pili = Console.ReadLine();

            if (pili.ToUpper()=="S")
            {
                tampilsabun(70, 14);
                Console.CursorVisible = true;
                Console.SetCursorPosition(x + 30, y + 3);
                Console.Write("ID SABUN :");
                string idsabun = Console.ReadLine();

                Console.SetCursorPosition(x + 30, y + 4);
                Console.Write("JUMLAH   :");
                int qty = int.Parse(Console.ReadLine());

                Console.SetCursorPosition(x + 30, y + 5);
                Console.Write("LANJUT PEMBELIAN...???[Y/N]:");
                string jwbnt = Console.ReadLine();
                if (jwbnt.ToUpper() == "Y") 
                {
                    sQL = "Insert into TRANSAKSI values('" + NOTA + "','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "','" + idkasir + "','" + idpembeli + "')";
                    OleDbCommand edc = new OleDbCommand();
                    edc.Connection = kenek;
                    edc.CommandText = sQL;
                    edc.ExecuteNonQuery();

                    sQL = "Insert into DETAIL_SABUN values('" + NOTA + "','" + idsabun + "','" + qty + "')";
                    edc.CommandText = sQL;
                    edc.ExecuteNonQuery();

                    tampilsabun(70, 14);
                    Console.CursorVisible = true;
                    Console.SetCursorPosition(x + 30, y + 3);
                    Console.Write("ID SABUN :");
                    string idsabun1 = Console.ReadLine();

                    Console.SetCursorPosition(x + 30, y + 4);
                    Console.Write("JUMLAH   :");
                    int qty1 = int.Parse(Console.ReadLine());

                    sQL = "Insert into DETAIL_SABUN values('" + NOTA + "','" + idsabun1 + "','" + qty1 + "')";
                    OleDbCommand edc1 = new OleDbCommand();
                    edc1.Connection = kenek;
                    edc1.CommandText = sQL;
                    edc1.ExecuteNonQuery();
                }else 
                {
                    sQL = "Insert into DETAIL_SABUN values('" + NOTA + "','" + idsabun + "','" + qty + "')";
                    OleDbCommand edc = new OleDbCommand();
                    edc.Connection = kenek;
                    edc.CommandText = sQL;
                    edc.ExecuteNonQuery();

                    kenek.Close();
                    MessageBox.Show("BERHASIL", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                    back(1, 8, Console.WindowWidth - 2, 11, ConsoleColor.Black);
                    kotak(35 + 55, 8, 44 + 55, 10, ConsoleColor.White);
                    kotak(35 + 46, 8, 44 + 45, 10, ConsoleColor.White);
                    kotak(35 + 37, 8, 44 + 36, 10, ConsoleColor.Red);
                    kotak(35 + 27, 8, 44 + 27, 10, ConsoleColor.White);
                    kotak(35 + 18, 8, 44 + 17, 10, ConsoleColor.Red);
                    kotak(35 + 10, 8, 44 + 8, 10, ConsoleColor.White);
                    kotak(35, 8, 44, 10, ConsoleColor.Red);
                    pilihantambah(37, 9, "BELI", "BERAS", "SABUN", "BARANG", "KASIR", "NOTA", "KELUAR", ConsoleColor.Green);
                    back(1, 8, Console.WindowWidth - 2, 11, ConsoleColor.Black);
                }
                kenek.Close();
                MessageBox.Show("BERHASIL", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                back(1, 8, Console.WindowWidth - 2, 11, ConsoleColor.Black);
                kotak(35 + 55, 8, 44 + 55, 10, ConsoleColor.White);
                kotak(35 + 46, 8, 44 + 45, 10, ConsoleColor.White);
                kotak(35 + 37, 8, 44 + 36, 10, ConsoleColor.Red);
                kotak(35 + 27, 8, 44 + 27, 10, ConsoleColor.White);
                kotak(35 + 18, 8, 44 + 17, 10, ConsoleColor.Red);
                kotak(35 + 10, 8, 44 + 8, 10, ConsoleColor.White);
                kotak(35, 8, 44, 10, ConsoleColor.Red);
                pilihantambah(37, 9, "BELI", "BERAS", "SABUN", "BARANG", "KASIR", "NOTA", "KELUAR", ConsoleColor.Green);
                back(1, 8, Console.WindowWidth - 2, 11, ConsoleColor.Black);
            }
            else if (pili.ToUpper() == "B") 
            {
                tampilberas(70, 14);
                Console.CursorVisible = true;
                Console.SetCursorPosition(x + 30, y + 3);
                Console.Write("ID BERAS :");
                string idberas = Console.ReadLine();

                Console.SetCursorPosition(x + 30, y + 4);
                Console.Write("JUMLAH   :");
                int qty = int.Parse(Console.ReadLine());

                Console.SetCursorPosition(x + 30, y + 5);
                Console.Write("LANJUT PEMBELIAN...???[Y/N]:");
                string jwbnt = Console.ReadLine();
                if (jwbnt.ToUpper() == "Y")
                {
                    sQL = "Insert into TRANSAKSI values('" + NOTA + "','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "','" + idkasir + "','" + idpembeli + "')";
                    OleDbCommand edc = new OleDbCommand();
                    edc.Connection = kenek;
                    edc.CommandText = sQL;
                    edc.ExecuteNonQuery();

                    sQL = "Insert into DETAIL_BERAS values('" + NOTA + "','" + idberas + "','" + qty + "')";
                    edc.CommandText = sQL;
                    edc.ExecuteNonQuery();

                    tampilberas(70, 14);
                    Console.CursorVisible = true;
                    Console.SetCursorPosition(x + 30, y + 3);
                    Console.Write("ID BERAS :");
                    string idberas1 = Console.ReadLine();

                    Console.SetCursorPosition(x + 30, y + 4);
                    Console.Write("JUMLAH   :");
                    int qty1 = int.Parse(Console.ReadLine());

                    sQL = "Insert into DETAIL_BERAS values('" + NOTA + "','" + idberas1 + "','" + qty1 + "')";
                    OleDbCommand edc1 = new OleDbCommand();
                    edc1.Connection = kenek;
                    edc1.CommandText = sQL;
                    edc1.ExecuteNonQuery();
                }
            //kenek.Close();
            //MessageBox.Show("BERHASIL", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    sQL = "Insert into DETAIL_BERAS values('" + NOTA + "','" + idberas + "','" + qty + "')";
                    OleDbCommand edc = new OleDbCommand();
                    edc.Connection = kenek;
                    edc.CommandText = sQL;
                    edc.ExecuteNonQuery();

                    kenek.Close();
                    MessageBox.Show("BERHASIL", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                    back(1, 8, Console.WindowWidth - 2, 11, ConsoleColor.Black);
                    kotak(35 + 55, 8, 44 + 55, 10, ConsoleColor.White);
                    kotak(35 + 46, 8, 44 + 45, 10, ConsoleColor.White);
                    kotak(35 + 37, 8, 44 + 36, 10, ConsoleColor.Red);
                    kotak(35 + 27, 8, 44 + 27, 10, ConsoleColor.White);
                    kotak(35 + 18, 8, 44 + 17, 10, ConsoleColor.Red);
                    kotak(35 + 10, 8, 44 + 8, 10, ConsoleColor.White);
                    kotak(35, 8, 44, 10, ConsoleColor.Red);
                    pilihantambah(37, 9, "BELI", "BERAS", "SABUN", "BARANG", "KASIR", "NOTA", "KELUAR", ConsoleColor.Green);
                    back(1, 8, Console.WindowWidth - 2, 11, ConsoleColor.Black);

                }
                kenek.Close();
                MessageBox.Show("BERHASIL", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                back(1, 8, Console.WindowWidth - 2, 11, ConsoleColor.Black);
                kotak(35 + 55, 8, 44 + 55, 10, ConsoleColor.White);
                kotak(35 + 46, 8, 44 + 45, 10, ConsoleColor.White);
                kotak(35 + 37, 8, 44 + 36, 10, ConsoleColor.Red);
                kotak(35 + 27, 8, 44 + 27, 10, ConsoleColor.White);
                kotak(35 + 18, 8, 44 + 17, 10, ConsoleColor.Red);
                kotak(35 + 10, 8, 44 + 8, 10, ConsoleColor.White);
                kotak(35, 8, 44, 10, ConsoleColor.Red);
                pilihantambah(37, 9, "BELI", "BERAS", "SABUN", "BARANG", "KASIR", "NOTA", "KELUAR", ConsoleColor.Green);
                back(1, 8, Console.WindowWidth - 2, 11, ConsoleColor.Black);
            } 
            //    kenek.Close();
            //MessageBox.Show("BERHASIL", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if(pili.ToUpper() == "L")
            {
                tampilbarang(70, 14);
                Console.CursorVisible = true;
                Console.SetCursorPosition(x + 30, y + 3);
                Console.Write("ID BARANG :");
                string idbarang = Console.ReadLine();

                Console.SetCursorPosition(x + 30, y + 4);
                Console.Write("JUMLAH   :");
                int qty = int.Parse(Console.ReadLine());

                Console.SetCursorPosition(x + 30, y + 5);
                Console.Write("LANJUT PEMBELIAN...???[Y/N]:");
                string jwbnt = Console.ReadLine();
                if (jwbnt.ToUpper() == "Y")
                {
                    sQL = "Insert into TRANSAKSI values('" + NOTA + "','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.ToShortDateString() + "','" + idkasir + "','" + idpembeli + "')";
                    OleDbCommand edc = new OleDbCommand();
                    edc.Connection = kenek;
                    edc.CommandText = sQL;
                    edc.ExecuteNonQuery();

                    sQL = "Insert into DETAIL_BARANG values('" + NOTA + "','" + idbarang + "','" + qty + "')";
                    edc.CommandText = sQL;
                    edc.ExecuteNonQuery();

                    tampilbarang(70, 14);
                    Console.CursorVisible = true;
                    Console.SetCursorPosition(x + 30, y + 3);
                    Console.Write("ID BARANG :");
                    string idbarang1 = Console.ReadLine();

                    Console.SetCursorPosition(x + 30, y + 4);
                    Console.Write("JUMLAH   :");
                    int qty1 = int.Parse(Console.ReadLine());

                    sQL = "Insert into DETAIL_BARANG values('" + NOTA + "','" + idbarang1 + "','" + qty1 + "')";
                    OleDbCommand edc1 = new OleDbCommand();
                    edc1.Connection = kenek;
                    edc1.CommandText = sQL;
                    edc1.ExecuteNonQuery();
                }
                else
                {
                    sQL = "Insert into DETAIL_BARANG values('" + NOTA + "','" + idbarang + "','" + qty + "')";
                    OleDbCommand edc = new OleDbCommand();
                    edc.Connection = kenek;
                    edc.CommandText = sQL;
                    edc.ExecuteNonQuery();

                    kenek.Close();
                    MessageBox.Show("BERHASIL", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                    back(1, 8, Console.WindowWidth - 2, 11, ConsoleColor.Black);
                    kotak(35 + 55, 8, 44 + 55, 10, ConsoleColor.White);
                    kotak(35 + 46, 8, 44 + 45, 10, ConsoleColor.White);
                    kotak(35 + 37, 8, 44 + 36, 10, ConsoleColor.Red);
                    kotak(35 + 27, 8, 44 + 27, 10, ConsoleColor.White);
                    kotak(35 + 18, 8, 44 + 17, 10, ConsoleColor.Red);
                    kotak(35 + 10, 8, 44 + 8, 10, ConsoleColor.White);
                    kotak(35, 8, 44, 10, ConsoleColor.Red);
                    pilihantambah(37, 9, "BELI", "BERAS", "SABUN", "BARANG", "KASIR", "NOTA", "KELUAR", ConsoleColor.Green);
                    back(1, 8, Console.WindowWidth - 2, 11, ConsoleColor.Black);
                }
            }
            kenek.Close();
            MessageBox.Show("BERHASIL", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
            back(1, 8, Console.WindowWidth - 2, 11, ConsoleColor.Black);
            kotak(35 + 55, 8, 44 + 55, 10, ConsoleColor.White);
            kotak(35 + 46, 8, 44 + 45, 10, ConsoleColor.White);
            kotak(35 + 37, 8, 44 + 36, 10, ConsoleColor.Red);
            kotak(35 + 27, 8, 44 + 27, 10, ConsoleColor.White);
            kotak(35 + 18, 8, 44 + 17, 10, ConsoleColor.Red);
            kotak(35 + 10, 8, 44 + 8, 10, ConsoleColor.White);
            kotak(35, 8, 44, 10, ConsoleColor.Red);
            pilihantambah(37, 9, "BELI", "BERAS", "SABUN", "BARANG", "KASIR", "NOTA", "KELUAR", ConsoleColor.Green);
            back(1, 8, Console.WindowWidth - 2, 11, ConsoleColor.Black);
        }

        public void tampilnota(int x, int y)
        {
            bukatabel("select * from TRANSAKSI");
            int jml = tabel.Tables[0].Rows.Count;

            Console.SetCursorPosition(x, y);
            Console.WriteLine("┌───────────┬─────────┬─────────────┬─────────────┬──────────────┬──────────┐");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("│   NOTA    │  JAM    │    TGL      │  ID KASIR   │  ID PEMBELI  │   TOTAL  │");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("├───────────┼─────────┼─────────────┼─────────────┼──────────────┼──────────┤");
            for (int i = 0; i < jml; i++)
            {
                string nota = tabel.Tables[0].Rows[i][0].ToString();
                DateTime jam = DateTime.Parse(tabel.Tables[0].Rows[i][1].ToString());
                DateTime tgl = DateTime.Parse(tabel.Tables[0].Rows[i][2].ToString());
                string idksr = tabel.Tables[0].Rows[i][3].ToString();
                string idpbl = tabel.Tables[0].Rows[i][4].ToString();
                string total = tabel.Tables[0].Rows[i][5].ToString();

                string nt = string.Format("{0,-11}", nota);
                string jm = string.Format("{0,-8}", jam.ToShortTimeString());
                string tl = string.Format("{0,-9}", tgl.ToShortDateString());
                string idkr = string.Format("{0,-12}", idksr);
                string idpl = string.Format("{0,-14}", idpbl);
                string tot =string.Format("{0,-10}", total);
            
                Console.SetCursorPosition(x, y + 3 + i);
                Console.WriteLine("│" + nt + "│" + jm+ " │ " + tl + "  │" + idkr + " │" + idpl + "│" + tot + "│");
            }

            Console.SetCursorPosition(x, y + jml + 3);
            Console.WriteLine("└───────────┴─────────┴─────────────┴─────────────┴──────────────┴──────────┘");
            Console.SetCursorPosition(x, y + jml + 4);
            Console.ReadLine();
        }

        public void tampilpembeli(int x,int y) 
        {
            bukatabel("select * from PEMBELI");
            int jml = tabel.Tables[0].Rows.Count;

            Console.SetCursorPosition(x, y);
            Console.WriteLine("┌───────────────┬────────────────┬────────────────┬────────────────┐");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("│      ID       │      NAMA      │      AGAMA     │  JENIS KELAMIN │");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("├───────────────┼────────────────┼────────────────┼────────────────┤");
            for (int i = 0; i < jml; i++)
            {
                string idpembeli = tabel.Tables[0].Rows[i][0].ToString();
                string nmpembeli = tabel.Tables[0].Rows[i][1].ToString();
                string agmpembeli = tabel.Tables[0].Rows[i][5].ToString();
                string jkpembeli = tabel.Tables[0].Rows[i][6].ToString();

                string id = string.Format("{0,-15}", idpembeli);
                string nm = string.Format("{0,-15}", nmpembeli);
                string agm = string.Format("{0,-13}", agmpembeli);
                string jk = string.Format("{0,-15}", jkpembeli);

                Console.SetCursorPosition(x, y + 3 + i);
                Console.WriteLine("│" + id + "│" + nm + " │ " + agm + "  │" + jk  +" │");
            }

            Console.SetCursorPosition(x, y + jml + 3);
            Console.WriteLine("└───────────────┴────────────────┴────────────────┴────────────────┘");
            Console.SetCursorPosition(x, y + jml + 4);
            Console.ReadLine();
        }

        public void tambahpembeli(int x, int y)
        {
            kenek.Open();
            bukatabel("select * from PEMBELI Order By ID_PEMBELI DESC");
            string nomor = tabel.Tables[0].Rows[0][0].ToString();
            //MessageBox.Show(nomor);
            string kode = Microsoft.VisualBasic.Strings.Right(nomor, 4);
            int kd = int.Parse(kode) + 1;
            string ID_PEMBELI = "P" + Microsoft.VisualBasic.Strings.Right("0000" + kd.ToString(), 4);
            //MessageBox.Show(kddriver);
            Console.CursorVisible = true;

            Console.SetCursorPosition(x, y);
            Console.Write("ID            :{0}", ID_PEMBELI);

            Console.SetCursorPosition(x, y + 1);
            Console.Write("NAMA          :");
            string NAMA = Console.ReadLine();

            Console.SetCursorPosition(x, y + 2);
            Console.Write("NOMOR HP      :");
            string NOMER_HP = Console.ReadLine();

            Console.SetCursorPosition(x, y + 3);
            Console.Write("TANGGAL       :");
            DateTime TTL = DateTime.Parse(Console.ReadLine());
            //Console.Write(TTL.ToShortDateString());

            Console.SetCursorPosition(x, y + 4);
            Console.Write("ALAMAT        :");
            string ALAMAT = Console.ReadLine();

            Console.SetCursorPosition(x, y + 5);
            Console.Write("AGAMA         :");
            string AGAMA = Console.ReadLine();

            Console.SetCursorPosition(x, y + 6);
            Console.Write("JENIS KELAMIN :");
            string JK = Console.ReadLine();

            Console.SetCursorPosition(x, y + 8);
            Console.Write("APAKAH DATA DISIMPAN   ???[Y/N]:");
            string jwb = Console.ReadLine();

            if (jwb.ToUpper() == "Y")
            {
                sQL = "Insert into PEMBELI values('" + ID_PEMBELI + "','" + NAMA + "','" + NOMER_HP + "',"+ TTL.ToShortDateString() +",'" + ALAMAT + "','" + AGAMA + "','" + JK + "')";
                OleDbCommand edc = new OleDbCommand();
                edc.Connection = kenek;
                edc.CommandText = sQL;
                edc.ExecuteNonQuery();
                kenek.Close();
                MessageBox.Show("berhasil", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.CursorVisible = false;
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
            }else if(jwb.ToUpper()=="N")
            {
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                kenek.Close();
                Console.CursorVisible = false;
                MessageBox.Show("Data tidak disimpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);  
            }
        }

        public void rubahpembeli(int x, int y)
        {
            tampilpembeli(45, 14);
            Console.SetCursorPosition(x, y);
            Console.Write("Masukkan Kode Pembeli:");
            Console.CursorVisible = true;
            string kd1 = Console.ReadLine();

            bukatabel("select * from PEMBELI where ID_PEMBELI='" + kd1 + "'");
            back(45, 14, Console.WindowWidth - 4, 20, ConsoleColor.Black);
            int jumrec = tabel.Tables[0].Rows.Count;

            Console.SetCursorPosition(x+43, y);
            Console.WriteLine("┌───────────────┬────────────────┬────────────────┬────────────────┐");
            Console.SetCursorPosition(x+43, y + 1);
            Console.WriteLine("│      ID       │      NAMA      │      AGAMA     │  JENIS KELAMIN │");
            Console.SetCursorPosition(x+43, y + 2);
            Console.WriteLine("├───────────────┼────────────────┼────────────────┼────────────────┤");
            for (int i = 0; i < jumrec; i++)
            {
                string idpembeli = tabel.Tables[0].Rows[i][0].ToString();
                string nmpembeli = tabel.Tables[0].Rows[i][1].ToString();
                string agmpembeli = tabel.Tables[0].Rows[i][5].ToString();
                string jkpembeli = tabel.Tables[0].Rows[i][6].ToString();

                string id1 = string.Format("{0,-15}", idpembeli);
                string nm1 = string.Format("{0,-15}", nmpembeli);
                string agm1 = string.Format("{0,-13}", agmpembeli);
                string jk1 = string.Format("{0,-15}", jkpembeli);

                Console.SetCursorPosition(x+43, y + 3 + i);
                Console.WriteLine("│" + id1 + "│" + nm1 + " │ " + agm1 + "  │" + jk1 + " │");
            }
            Console.SetCursorPosition(x+43, y + jumrec + 3);
            Console.WriteLine("└───────────────┴────────────────┴────────────────┴────────────────┘");

            Console.CursorVisible = true;

            Console.SetCursorPosition(x, y + 1);
            Console.Write("NAMA          :");
            string NAMA1 = Console.ReadLine();

            Console.SetCursorPosition(x, y + 2);
            Console.Write("NOMOR HP      :");
            string NOMER_HP1 = Console.ReadLine();

            Console.SetCursorPosition(x, y + 3);
            Console.Write("TANGGAL        :");
            DateTime TTL1 = DateTime.Parse(Console.ReadLine());

            Console.SetCursorPosition(x, y + 4);
            Console.Write("ALAMAT        :");
            string ALAMAT1 = Console.ReadLine();

            Console.SetCursorPosition(x, y + 5);
            Console.Write("AGAMA         :");
            string AGAMA1 = Console.ReadLine();

            Console.SetCursorPosition(x, y + 6);
            Console.Write("JENIS KELAMIN :");
            string JK1 = Console.ReadLine();

            Console.SetCursorPosition(x, y + 8);
            Console.Write("APAKAH DATA DIRUBAH   ???[Y/N]:");
            string jwb = Console.ReadLine();

            if (jwb.ToUpper() == "Y")
            {
                kenek.Open();
                sQL = "Update PEMBELI set NAMA='" + NAMA1 + "',NOMER_HP='" + NOMER_HP1 + "',TTL=" + TTL1.ToShortDateString() + ",ALAMAT='" + ALAMAT1 + "',AGAMA='" + AGAMA1 + "',JK='" + JK1 + "' Where ID_PEMBELI='" + kd1 + "'";
                OleDbCommand edc = new OleDbCommand();
                edc.Connection = kenek;
                edc.CommandText = sQL;
                edc.ExecuteNonQuery();
                kenek.Close();
                MessageBox.Show("berhasil", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.CursorVisible = false;
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
            }
            else if (jwb.ToUpper() == "N")
            {
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                kenek.Close();
                Console.CursorVisible = false;
                MessageBox.Show("Data tidak disimpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void hapuspembeli(int x, int y)
        {
            tampilpembeli(45, 14);
            Console.SetCursorPosition(x, y);
            Console.Write("Masukkan Kode Pembeli:");
            Console.CursorVisible = true;
            string kd1 = Console.ReadLine();

            bukatabel("select * from PEMBELI where ID_PEMBELI='" + kd1 + "'");
            back(45, 14, Console.WindowWidth - 4, 20, ConsoleColor.Black);
            int jumrec = tabel.Tables[0].Rows.Count;

            Console.SetCursorPosition(x + 43, y);
            Console.WriteLine("┌───────────────┬────────────────┬────────────────┬────────────────┐");
            Console.SetCursorPosition(x + 43, y + 1);
            Console.WriteLine("│      ID       │      NAMA      │      AGAMA     │  JENIS KELAMIN │");
            Console.SetCursorPosition(x + 43, y + 2);
            Console.WriteLine("├───────────────┼────────────────┼────────────────┼────────────────┤");
            for (int i = 0; i < jumrec; i++)
            {
                string idpembeli = tabel.Tables[0].Rows[i][0].ToString();
                string nmpembeli = tabel.Tables[0].Rows[i][1].ToString();
                string agmpembeli = tabel.Tables[0].Rows[i][5].ToString();
                string jkpembeli = tabel.Tables[0].Rows[i][6].ToString();

                string id1 = string.Format("{0,-15}", idpembeli);
                string nm1 = string.Format("{0,-15}", nmpembeli);
                string agm1 = string.Format("{0,-13}", agmpembeli);
                string jk1 = string.Format("{0,-15}", jkpembeli);

                Console.SetCursorPosition(x + 43, y + 3 + i);
                Console.WriteLine("│" + id1 + "│" + nm1 + " │ " + agm1 + "  │" + jk1 + " │");
            }
            Console.SetCursorPosition(x + 43, y + jumrec + 3);
            Console.WriteLine("└───────────────┴────────────────┴────────────────┴────────────────┘");

            Console.SetCursorPosition(x, y + 2);
            Console.Write("APAKAH DATA DIHAPUS   ???[Y/N]:");
            string jwb = Console.ReadLine();

            if (jwb.ToUpper() == "Y")
            {
                kenek.Open();
                sQL = "Delete From PEMBELI  Where ID_PEMBELI='" + kd1 + "'";
                OleDbCommand edc = new OleDbCommand();
                edc.Connection = kenek;
                edc.CommandText = sQL;
                edc.ExecuteNonQuery();
                kenek.Close();
                MessageBox.Show("berhasil", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.CursorVisible = false;
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
            }
            else if (jwb.ToUpper() == "N")
            {
                kenek.Close();
                Console.CursorVisible = false;
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
                MessageBox.Show("Data tidak disimpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void tambahbarang(int x, int y)
        {
            kenek.Open();
            bukatabel("select * from BARANG Order By ID_BARANG DESC");
            string nomor = tabel.Tables[0].Rows[0][0].ToString();
            //MessageBox.Show(nomor);
            string kode = Microsoft.VisualBasic.Strings.Right(nomor, 2);
            int kd = int.Parse(kode) + 1;
            string ID_BARANG = "BRG" + Microsoft.VisualBasic.Strings.Right("00" + kd.ToString(), 2);
            //MessageBox.Show(kddriver);
            Console.CursorVisible = true;

            Console.SetCursorPosition(x, y);
            Console.Write("ID            :{0}", ID_BARANG);

            Console.SetCursorPosition(x, y + 1);
            Console.Write("NAMA BRG      :");
            string NAMA_BARANG = Console.ReadLine();

            Console.SetCursorPosition(x, y + 2);
            Console.Write("HARGA         :");
            double HARGA = double.Parse(Console.ReadLine());

            Console.SetCursorPosition(x, y + 7);
            Console.Write("APAKAH DATA DISIMPAN   ???[Y/N]");
            string jwb = Console.ReadLine();

            if (jwb.ToUpper() == "Y")
            {
                sQL = "Insert into BARANG values('" + ID_BARANG + "','" + NAMA_BARANG + "','" + HARGA + "')";
                OleDbCommand edc = new OleDbCommand();
                edc.Connection = kenek;
                edc.CommandText = sQL;
                edc.ExecuteNonQuery();
                kenek.Close();
                MessageBox.Show("berhasil", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.CursorVisible = false;
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
            }
            else if (jwb.ToUpper() == "N")
            {
                 kenek.Close();
                MessageBox.Show("Data tidak disimpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.CursorVisible = false;
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
            }
        }

        public void tampilbarang(int x, int y)
        {
            bukatabel("select * from BARANG");
            int jml = tabel.Tables[0].Rows.Count;

            Console.SetCursorPosition(x, y);
            Console.WriteLine("┌───────────────┬────────────────┬────────────────┐");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("│      ID       │      NAMA      │      HARGA     │");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("├───────────────┼────────────────┼────────────────┤");
            for (int i = 0; i < jml; i++)
            {
                string idbarang = tabel.Tables[0].Rows[i][0].ToString();
                string nmbarang = tabel.Tables[0].Rows[i][1].ToString();
                string hrgbarang = tabel.Tables[0].Rows[i][2].ToString();

                string id = string.Format("{0,-15}", idbarang);
                string nm = string.Format("{0,-15}", nmbarang);
                string hrg = string.Format("{0,-15}", hrgbarang);

                Console.SetCursorPosition(x, y + 3 + i);
                Console.WriteLine("│" + id + "│" + nm + " │" + hrg + " │");
            }

            Console.SetCursorPosition(x, y + jml + 3);
            Console.WriteLine("└───────────────┴────────────────┴────────────────┘");
            Console.SetCursorPosition(x, y + jml + 4);
            Console.ReadLine();
        }

        public void rubahbarang(int x, int y)
        {
            tampilbarang(45, 14);
            Console.SetCursorPosition(x, y);
            Console.Write("Masukkan Kode Barang:");
            Console.CursorVisible = true;
            string kd2 = Console.ReadLine();

            bukatabel("select * from BARANG where ID_BARANG='" + kd2 + "'");
            back(45, 14, Console.WindowWidth - 4, 26, ConsoleColor.Black);
            int jumrec1 = tabel.Tables[0].Rows.Count;

            Console.SetCursorPosition(x+43, y);
            Console.WriteLine("┌───────────────┬────────────────┬────────────────┐");
            Console.SetCursorPosition(x+43, y + 1);
            Console.WriteLine("│      ID       │      NAMA      │      HARGA     │");
            Console.SetCursorPosition(x+43, y + 2);
            Console.WriteLine("├───────────────┼────────────────┼────────────────┤");
            for (int i = 0; i < jumrec1; i++)
            {
                string idbarang = tabel.Tables[0].Rows[i][0].ToString();
                string nmbarang = tabel.Tables[0].Rows[i][1].ToString();
                string hrgbarang = tabel.Tables[0].Rows[i][2].ToString();

                string id2 = string.Format("{0,-15}", idbarang);
                string nm2 = string.Format("{0,-15}", nmbarang);
                string hrg2 = string.Format("{0,-15}", hrgbarang);

                Console.SetCursorPosition(x+43, y + 3 + i);
                Console.WriteLine("│" + id2 + "│" + nm2 + " │" + hrg2 + " │");
            }

            Console.SetCursorPosition(x+43, y + jumrec1 + 3);
            Console.WriteLine("└───────────────┴────────────────┴────────────────┘");

            Console.CursorVisible = true;

            Console.SetCursorPosition(x, y + 1);
            Console.Write("NAMA BRG      :");
            string NAMA_BARANG2 = Console.ReadLine();

            Console.SetCursorPosition(x, y + 2);
            Console.Write("HARGA         :");
            double HARGA2 = double.Parse(Console.ReadLine());

            Console.SetCursorPosition(x, y + 7);
            Console.Write("APAKAH DATA DIRUBAH   ???[Y/N]");
            string jwb = Console.ReadLine();

            if (jwb.ToUpper() == "Y")
            {
                kenek.Open();
                sQL = "Update BARANG set NAMA_BARANG='"+ NAMA_BARANG2 +"',HARGA="+ HARGA2 +" where ID_BARANG='"+ kd2 +"'";
                OleDbCommand edc = new OleDbCommand();
                edc.Connection = kenek;
                edc.CommandText = sQL;
                edc.ExecuteNonQuery();
                kenek.Close();
                MessageBox.Show("berhasil", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.CursorVisible = false;
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
            }
            else if (jwb.ToUpper() == "N")
            {
                kenek.Close();
                MessageBox.Show("Data tidak disimpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.CursorVisible = false;
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
            }
        }

        public void hapusbarang(int x, int y)
        {
            tampilbarang(45, 14);
            Console.SetCursorPosition(x, y);
            Console.Write("Masukkan Kode Barang:");
            Console.CursorVisible = true;
            string kd2 = Console.ReadLine();

            bukatabel("select * from BARANG where ID_BARANG='" + kd2 + "'");
            back(45, 14, Console.WindowWidth - 4, 26, ConsoleColor.Black);
            int jumrec1 = tabel.Tables[0].Rows.Count;

            Console.SetCursorPosition(x + 43, y);
            Console.WriteLine("┌───────────────┬────────────────┬────────────────┐");
            Console.SetCursorPosition(x + 43, y + 1);
            Console.WriteLine("│      ID       │      NAMA      │      HARGA     │");
            Console.SetCursorPosition(x + 43, y + 2);
            Console.WriteLine("├───────────────┼────────────────┼────────────────┤");
            for (int i = 0; i < jumrec1; i++)
            {
                string idbarang = tabel.Tables[0].Rows[i][0].ToString();
                string nmbarang = tabel.Tables[0].Rows[i][1].ToString();
                string hrgbarang = tabel.Tables[0].Rows[i][2].ToString();

                string id2 = string.Format("{0,-15}", idbarang);
                string nm2 = string.Format("{0,-15}", nmbarang);
                string hrg2 = string.Format("{0,-15}", hrgbarang);

                Console.SetCursorPosition(x + 43, y + 3 + i);
                Console.WriteLine("│" + id2 + "│" + nm2 + " │" + hrg2 + " │");
            }

            Console.SetCursorPosition(x + 43, y + jumrec1 + 3);
            Console.WriteLine("└───────────────┴────────────────┴────────────────┘");

            Console.SetCursorPosition(x, y + 2);
            Console.Write("APAKAH DATA DIHAPUS   ???[Y/N]");
            string jwb = Console.ReadLine();

            if (jwb.ToUpper() == "Y")
            {
                kenek.Open();
                sQL = "Delete From BARANG where ID_BARANG='" + kd2 + "'";
                OleDbCommand edc = new OleDbCommand();
                edc.Connection = kenek;
                edc.CommandText = sQL;
                edc.ExecuteNonQuery();
                kenek.Close();
                MessageBox.Show("berhasil", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.CursorVisible = false;
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
            }
            else if (jwb.ToUpper() == "N")
            {
                kenek.Close();
                Console.CursorVisible = false;
                MessageBox.Show("Data tidak disimpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
            }
        }

        public void tambahsabun(int x, int y)
        {
            kenek.Open();
            bukatabel("select * from SABUN Order By ID_SABUN DESC");
            string nomor = tabel.Tables[0].Rows[0][0].ToString();
            //MessageBox.Show(nomor);
            string kode = Microsoft.VisualBasic.Strings.Right(nomor, 3);
            int kd = int.Parse(kode) + 1;
            string ID_SABUN = "S" + Microsoft.VisualBasic.Strings.Right("000" + kd.ToString(), 3);
            //MessageBox.Show(kddriver);
            Console.CursorVisible = true;

            Console.SetCursorPosition(x, y);
            Console.Write("ID            :{0}", ID_SABUN);

            Console.SetCursorPosition(x, y + 1);
            Console.Write("NAMA SABUN    :");
            string NAMA_SABUN = Console.ReadLine();

            Console.SetCursorPosition(x, y + 2);
            Console.Write("HARGA         :");
            double HARGA = double.Parse(Console.ReadLine());

            Console.SetCursorPosition(x, y + 7);
            Console.Write("APAKAH DATA DISIMPAN   ???[Y/N]");
            string jwb = Console.ReadLine();

            if (jwb.ToUpper() == "Y")
            {
                sQL = "Insert into SABUN values('" + ID_SABUN + "','" + NAMA_SABUN + "','" + HARGA + "')";
                OleDbCommand edc = new OleDbCommand();
                edc.Connection = kenek;
                edc.CommandText = sQL;
                edc.ExecuteNonQuery();
                kenek.Close();
                MessageBox.Show("berhasil", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.CursorVisible = false;
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
            }
            else if (jwb.ToUpper() == "N")
            {
                kenek.Close();
                MessageBox.Show("Data tidak disimpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.CursorVisible = false;
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
            }
        }

        public void tampilsabun(int x, int y)
        {
            bukatabel("select * from SABUN");
            int jml = tabel.Tables[0].Rows.Count;

            Console.SetCursorPosition(x, y);
            Console.WriteLine("┌──────┬─────────────────────┬───────┐");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("│  ID  │      NAMA           │ HARGA │");
            Console.SetCursorPosition(x, y + 2); 
            Console.WriteLine("├──────┼─────────────────────┼───────┤");
            for (int i = 0; i < jml; i++)
            {
                string idsabun = tabel.Tables[0].Rows[i][0].ToString();
                string nmsabun = tabel.Tables[0].Rows[i][1].ToString();
                string hrgsabun = tabel.Tables[0].Rows[i][2].ToString();

                string id = string.Format("{0,-6}", idsabun);
                string nm = string.Format("{0,-20}", nmsabun);
                string hrg = string.Format("{0,-6}", hrgsabun);

                Console.SetCursorPosition(x, y + 3 + i);
                Console.WriteLine("│" + id + "│" + nm + " │" + hrg + " │");
            }

            Console.SetCursorPosition(x, y + jml + 3);
            Console.WriteLine("└──────┴─────────────────────┴───────┘");
            //Console.SetCursorPosition(x, y + jml + 4);
            Console.ReadLine();
        }

        public void rubahsabun(int x, int y)
        {
            tampilsabun(45, 14);
            Console.SetCursorPosition(x, y);
            Console.Write("Masukkan Kode Sabun:");
            Console.CursorVisible = true;
            string kd3 = Console.ReadLine();

            bukatabel("select * from SABUN where ID_SABUN='" + kd3 + "'");
            back(45, 14, Console.WindowWidth - 4, 25, ConsoleColor.Black);
            int jumrec2 = tabel.Tables[0].Rows.Count;

             Console.SetCursorPosition(x+43, y);
            Console.WriteLine("┌───────────────┬─────────────────────┬────────────────┐");
            Console.SetCursorPosition(x+43, y + 1);
            Console.WriteLine("│      ID       │      NAMA           │      HARGA     │");
            Console.SetCursorPosition(x+43, y + 2);
            Console.WriteLine("├───────────────┼─────────────────────┼────────────────┤");
            for (int i = 0; i < jumrec2; i++)
            {
                string idsabun = tabel.Tables[0].Rows[i][0].ToString();
                string nmsabun = tabel.Tables[0].Rows[i][1].ToString();
                string hrgsabun = tabel.Tables[0].Rows[i][2].ToString();

                string id3 = string.Format("{0,-15}", idsabun);
                string nm3 = string.Format("{0,-20}", nmsabun);
                string hrg3 = string.Format("{0,-15}", hrgsabun);

                Console.SetCursorPosition(x+43, y + 3 + i);
                Console.WriteLine("│" + id3 + "│" + nm3 + " │" + hrg3 + " │");
            }

            Console.SetCursorPosition(x + 43, y + jumrec2 + 3);
            Console.WriteLine("└───────────────┴─────────────────────┴────────────────┘");

            Console.CursorVisible = true;

            Console.SetCursorPosition(x, y + 1);
            Console.Write("NAMA SABUN    :");
            string NAMA_SABUN3 = Console.ReadLine();

            Console.SetCursorPosition(x, y + 2);
            Console.Write("HARGA         :");
            double HARGA3 = double.Parse(Console.ReadLine());

            Console.SetCursorPosition(x, y + 2);
            Console.Write("APAKAH DATA DIRUBAH   ???[Y/N]");
            string jwb = Console.ReadLine();

            if (jwb.ToUpper() == "Y")
            {
                kenek.Open();
                sQL = "Update SABUN set NAMA_SABUN='"+ NAMA_SABUN3 +"',HARGA="+ HARGA3 +" where ID_SABUN='"+ kd3 +"'";
                OleDbCommand edc = new OleDbCommand();
                edc.Connection = kenek;
                edc.CommandText = sQL;
                edc.ExecuteNonQuery();
                kenek.Close();
                MessageBox.Show("berhasil", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.CursorVisible = false;
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
            }
            else if (jwb.ToUpper() == "N")
            {
                kenek.Close();
                MessageBox.Show("Data tidak disimpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.CursorVisible = false;
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
            }
        }

        public void hapussabun(int x, int y)
        {
            tampilsabun(45, 14);
            Console.SetCursorPosition(x, y);
            Console.Write("Masukkan Kode Sabun:");
            Console.CursorVisible = true;
            string kd3 = Console.ReadLine();

            bukatabel("select * from SABUN where ID_SABUN='" + kd3 + "'");
            back(45, 14, Console.WindowWidth - 4, 25, ConsoleColor.Black);
            int jumrec2 = tabel.Tables[0].Rows.Count;

            Console.SetCursorPosition(x + 43, y);
            Console.WriteLine("┌───────────────┬─────────────────────┬────────────────┐");
            Console.SetCursorPosition(x + 43, y + 1);
            Console.WriteLine("│      ID       │      NAMA           │      HARGA     │");
            Console.SetCursorPosition(x + 43, y + 2);
            Console.WriteLine("├───────────────┼─────────────────────┼────────────────┤");
            for (int i = 0; i < jumrec2; i++)
            {
                string idsabun = tabel.Tables[0].Rows[i][0].ToString();
                string nmsabun = tabel.Tables[0].Rows[i][1].ToString();
                string hrgsabun = tabel.Tables[0].Rows[i][2].ToString();

                string id3 = string.Format("{0,-15}", idsabun);
                string nm3 = string.Format("{0,-20}", nmsabun);
                string hrg3 = string.Format("{0,-15}", hrgsabun);

                Console.SetCursorPosition(x + 43, y + 3 + i);
                Console.WriteLine("│" + id3 + "│" + nm3 + " │" + hrg3 + " │");
            }

            Console.SetCursorPosition(x + 43, y + jumrec2 + 3);
            Console.WriteLine("└───────────────┴─────────────────────┴────────────────┘");

            Console.SetCursorPosition(x, y + 2);
            Console.Write("APAKAH DATA DIHAPUS   ???[Y/N]");
            string jwb = Console.ReadLine();

            if (jwb.ToUpper() == "Y")
            {
                kenek.Open();
                sQL = "Delete From SABUN where ID_SABUN='" + kd3 + "'";
                OleDbCommand edc = new OleDbCommand();
                edc.Connection = kenek;
                edc.CommandText = sQL;
                edc.ExecuteNonQuery();
                kenek.Close();
                MessageBox.Show("berhasil", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.CursorVisible = false;
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
            }
            else if (jwb.ToUpper() == "N")
            {
                kenek.Close();
                Console.CursorVisible = false;
                MessageBox.Show("Data tidak disimpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
            }
        }

        public void tambahberas(int x, int y)
        {
            kenek.Open();
            bukatabel("select * from BERAS Order By ID_BERAS DESC");
            string nomor = tabel.Tables[0].Rows[0][0].ToString();
            //MessageBox.Show(nomor);
            string kode = Microsoft.VisualBasic.Strings.Right(nomor, 3);
            int kd = int.Parse(kode) + 1;
            string ID_BERAS = "B" + Microsoft.VisualBasic.Strings.Right("000" + kd.ToString(), 3);
            //MessageBox.Show(kddriver);
            Console.CursorVisible = true;

            Console.SetCursorPosition(x, y);
            Console.Write("ID            :{0}", ID_BERAS);

            Console.SetCursorPosition(x, y + 1);
            Console.Write("NAMA BERAS    :");
            string NAMA_BERAS = Console.ReadLine();

            Console.SetCursorPosition(x, y + 2);
            Console.Write("HARGA         :");
            double HARGA = double.Parse(Console.ReadLine());

            Console.SetCursorPosition(x, y + 7);
            Console.Write("APAKAH DATA DISIMPAN   ???[Y/N]");
            string jwb = Console.ReadLine();

            if (jwb.ToUpper() == "Y")
            {
                sQL = "Insert into BERAS values('" + ID_BERAS + "','" + NAMA_BERAS + "','" + HARGA + "')";
                OleDbCommand edc = new OleDbCommand();
                edc.Connection = kenek;
                edc.CommandText = sQL;
                edc.ExecuteNonQuery();
                kenek.Close();
                MessageBox.Show("berhasil", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.CursorVisible = false;
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
            }
            else if (jwb.ToUpper() == "N")
            {
                kenek.Close();
                MessageBox.Show("Data tidak disimpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.CursorVisible = false;
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
            }
        }

        public void tampilberas(int x, int y)
        {
            bukatabel("select * from BERAS");
            int jml = tabel.Tables[0].Rows.Count;

            Console.SetCursorPosition(x, y);
            Console.WriteLine("┌───────┬─────────────────────┬─────────┐");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("│  ID   │      NAMA           │  HARGA  │");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("├───────┼─────────────────────┼─────────┤");
           
            for (int i = 0; i < jml; i++)
            {
                string idberas = tabel.Tables[0].Rows[i][0].ToString();
                string nmberas = tabel.Tables[0].Rows[i][1].ToString();
                string hrgberas = tabel.Tables[0].Rows[i][2].ToString();

                string id = string.Format("{0,-7}", idberas);
                string nm = string.Format("{0,-20}", nmberas);
                string hrg = string.Format("{0,-8}", hrgberas);

                Console.SetCursorPosition(x, y + 3 + i);
                Console.WriteLine("│" + id + "│" + nm + " │" + hrg + " │");
            }

            Console.SetCursorPosition(x, y + jml + 3);
            Console.WriteLine("└───────┴─────────────────────┴─────────┘");
            //Console.SetCursorPosition(x, y + jml + 4);
            Console.ReadLine();
        }

        public void rubahberas(int x, int y)
        {
            tampilberas(45, 14);
            Console.SetCursorPosition(x, y);
            Console.Write("Masukkan Kode Beras:");
            Console.CursorVisible = true;
            string kd4 = Console.ReadLine();

            bukatabel("select * from BERAS where ID_BERAS='" + kd4 + "'");
            back(45, 14, Console.WindowWidth - 4, 25, ConsoleColor.Black);
            int jumrec3 = tabel.Tables[0].Rows.Count;

            Console.SetCursorPosition(x+43, y);
            Console.WriteLine("┌───────────────┬─────────────────────┬────────────────┐");
            Console.SetCursorPosition(x+43, y + 1);
            Console.WriteLine("│      ID       │      NAMA           │      HARGA     │");
            Console.SetCursorPosition(x+43, y + 2);
            Console.WriteLine("├───────────────┼─────────────────────┼────────────────┤");
            for (int i = 0; i < jumrec3; i++)
            {
                string idberas = tabel.Tables[0].Rows[i][0].ToString();
                string nmberas = tabel.Tables[0].Rows[i][1].ToString();
                string hrgberas = tabel.Tables[0].Rows[i][2].ToString();

                string id4 = string.Format("{0,-15}", idberas);
                string nm4 = string.Format("{0,-20}", nmberas);
                string hrg4 = string.Format("{0,-15}", hrgberas);

                Console.SetCursorPosition(x+43, y + 3 + i);
                Console.WriteLine("│" + id4 + "│" + nm4 + " │" + hrg4 + " │");
            }

            Console.SetCursorPosition(x+43, y + jumrec3 + 3);
            Console.WriteLine("└───────────────┴─────────────────────┴────────────────┘");

            Console.CursorVisible = true;

            Console.SetCursorPosition(x, y + 1);
            Console.Write("NAMA BERAS    :");
            string NAMA_BERAS4 = Console.ReadLine();

            Console.SetCursorPosition(x, y + 2);
            Console.Write("HARGA         :");
            double HARGA4 = double.Parse(Console.ReadLine());

            Console.SetCursorPosition(x, y + 7);
            Console.Write("APAKAH DATA DIRUBAH   ???[Y/N]");
            string jwb = Console.ReadLine();

            if (jwb.ToUpper() == "Y")
            {
                kenek.Open();
                sQL = "Update BERAS set NAMA_BERAS='"+ NAMA_BERAS4 +"',HARGA="+ HARGA4 +" where ID_BERAS='"+ kd4 +"'";
                OleDbCommand edc = new OleDbCommand();
                edc.Connection = kenek;
                edc.CommandText = sQL;
                edc.ExecuteNonQuery();
                kenek.Close();
                MessageBox.Show("berhasil", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.CursorVisible = false;
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
            }
            else if (jwb.ToUpper() == "N")
            {
                kenek.Close();
                Console.CursorVisible = false;
                MessageBox.Show("Data tidak disimpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
            }
        }

        public void hapusberas(int x, int y)
        {
            tampilberas(45, 14);
            Console.SetCursorPosition(x, y);
            Console.Write("Masukkan Kode Beras:");
            Console.CursorVisible = true;
            string kd4 = Console.ReadLine();

            bukatabel("select * from BERAS where ID_BERAS='" + kd4 + "'");
            back(45, 14, Console.WindowWidth - 4, 25, ConsoleColor.Black);
            int jumrec3 = tabel.Tables[0].Rows.Count;

            Console.SetCursorPosition(x + 43, y);
            Console.WriteLine("┌───────────────┬─────────────────────┬────────────────┐");
            Console.SetCursorPosition(x + 43, y + 1);
            Console.WriteLine("│      ID       │      NAMA           │      HARGA     │");
            Console.SetCursorPosition(x + 43, y + 2);
            Console.WriteLine("├───────────────┼─────────────────────┼────────────────┤");
            for (int i = 0; i < jumrec3; i++)
            {
                string idberas = tabel.Tables[0].Rows[i][0].ToString();
                string nmberas = tabel.Tables[0].Rows[i][1].ToString();
                string hrgberas = tabel.Tables[0].Rows[i][2].ToString();

                string id4 = string.Format("{0,-15}", idberas);
                string nm4 = string.Format("{0,-20}", nmberas);
                string hrg4 = string.Format("{0,-15}", hrgberas);

                Console.SetCursorPosition(x + 43, y + 3 + i);
                Console.WriteLine("│" + id4 + "│" + nm4 + " │" + hrg4 + " │");
            }

            Console.SetCursorPosition(x + 43, y + jumrec3 + 3);
            Console.WriteLine("└───────────────┴─────────────────────┴────────────────┘");

            Console.SetCursorPosition(x, y + 2);
            Console.Write("APAKAH DATA DIHAPUS   ???[Y/N]");
            string jwb = Console.ReadLine();

            if (jwb.ToUpper() == "Y")
            {
                kenek.Open();
                sQL = "Delete From BERAS where ID_BERAS='" + kd4 + "'";
                OleDbCommand edc = new OleDbCommand();
                edc.Connection = kenek;
                edc.CommandText = sQL;
                edc.ExecuteNonQuery();
                kenek.Close();
                MessageBox.Show("berhasil", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.CursorVisible = false;
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
            }
            else if (jwb.ToUpper() == "N")
            {
                kenek.Close();
                Console.CursorVisible = false;
                MessageBox.Show("Data tidak disimpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
            }
        }

        public void tambahkasir(int x, int y)
        {
            kenek.Open();
            bukatabel("select * from KASIR Order By ID_KASIR DESC");
            string nomor = tabel.Tables[0].Rows[0][0].ToString();
            //MessageBox.Show(nomor);
            string kode = Microsoft.VisualBasic.Strings.Right(nomor, 3);
            int kd = int.Parse(kode) + 1;
            string ID_KASIR = "KS" + Microsoft.VisualBasic.Strings.Right("000" + kd.ToString(), 3);
            //MessageBox.Show(kddriver);
            Console.CursorVisible = true;

            Console.SetCursorPosition(x, y);
            Console.Write("ID            :{0}", ID_KASIR);

            Console.SetCursorPosition(x, y + 1);
            Console.Write("NAMA KASIR    :");
            string NAMA_KASIR = Console.ReadLine();

            Console.SetCursorPosition(x, y + 2);
            Console.Write("JENIS KELAMIN :");
            string JK = Console.ReadLine();

            Console.SetCursorPosition(x, y + 3);
            Console.Write("ALAMAT        :");
            string ALAMAT = Console.ReadLine();

            Console.SetCursorPosition(x, y + 7);
            Console.Write("APAKAH DATA DISIMPAN   ???[Y/N]");
            string jwb = Console.ReadLine();

            if (jwb.ToUpper() == "Y")
            {
                sQL = "Insert into KASIR values('" + ID_KASIR + "','" + NAMA_KASIR + "','" + JK + "','" + ALAMAT + "')";
                OleDbCommand edc = new OleDbCommand();
                edc.Connection = kenek;
                edc.CommandText = sQL;
                edc.ExecuteNonQuery();
                kenek.Close();
                MessageBox.Show("berhasil", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.CursorVisible = false;
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
            }
            else if (jwb.ToUpper() == "N")
            {
                kenek.Close();
                MessageBox.Show("Data tidak disimpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.CursorVisible = false;
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
            }
        }

        public void tampilkasir(int x, int y)
        {
            bukatabel("select * from KASIR");
            int jml = tabel.Tables[0].Rows.Count;

            Console.SetCursorPosition(x, y);
            Console.WriteLine("┌───────────────┬────────────────┬────────────────┬────────────────┐");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("│      ID       │      NAMA      │ JENIS KELAMIN  │      ALAMAT    │");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("├───────────────┼────────────────┼────────────────┼────────────────┤");
            for (int i = 0; i < jml; i++)
            {
                string idkasir = tabel.Tables[0].Rows[i][0].ToString();
                string nmkasir = tabel.Tables[0].Rows[i][1].ToString();
                string jeka = tabel.Tables[0].Rows[i][2].ToString();
                string alamat = tabel.Tables[0].Rows[i][3].ToString();

                string id = string.Format("{0,-15}", idkasir);
                string nm = string.Format("{0,-15}", nmkasir);
                string jk = string.Format("{0,-15}", jeka);
                string almt = string.Format("{0,-15}", alamat);

                Console.SetCursorPosition(x, y + 3 + i);
                Console.WriteLine("│" + id + "│" + nm + " │" + jk + " │" + almt + " │");
            }

            Console.SetCursorPosition(x, y + jml + 3);
            Console.WriteLine("└───────────────┴────────────────┴────────────────┴────────────────┘");
            Console.SetCursorPosition(x, y + jml + 4);
            Console.ReadLine();
        }

        public void tampilnali(int x, int y)
        {
            bukatabel("select * from PEMBELI");
            int jml = tabel.Tables[0].Rows.Count;

            Console.SetCursorPosition(x, y);
            Console.WriteLine("┌────────┬────────────┐");
        
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("│   ID   │     NAMA   │");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("├────────┼────────────┤"); 
            for (int i = 0; i < jml; i++)
            {
                string idpembeli = tabel.Tables[0].Rows[i][0].ToString();
                string nmpembeli = tabel.Tables[0].Rows[i][1].ToString();

                string id = string.Format("{0,-8}", idpembeli);
                string nm = string.Format("{0,-11}", nmpembeli);

                Console.SetCursorPosition(x, y + 3 + i);
                Console.WriteLine("│" + id + "│" + nm + " │");
            }

            Console.SetCursorPosition(x, y + jml + 3);
            Console.WriteLine("└────────┴────────────┘");
            Console.ReadLine();
        }
        
        public void tampilnasir(int x, int y)
        {
            bukatabel("select * from KASIR");
            int jml = tabel.Tables[0].Rows.Count;

            Console.SetCursorPosition(x, y);
            Console.WriteLine("┌─────────┬────────────┐");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("│   ID    │    NAMA    │");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("├─────────┼────────────┤");  
            for (int i = 0; i < jml; i++)
            {
                string idkasir = tabel.Tables[0].Rows[i][0].ToString();
                string nmkasir = tabel.Tables[0].Rows[i][1].ToString();

                string id = string.Format("{0,-9}", idkasir);
                string nm = string.Format("{0,-11}", nmkasir);

                Console.SetCursorPosition(x, y + 3 + i);
                Console.WriteLine("│" + id + "│" + nm + " │");
            } 
            Console.SetCursorPosition(x, y + jml + 3);
            Console.WriteLine("└─────────┴────────────┘");
            Console.ReadLine();
        }

        public void rubahkasir(int x, int y)
        {
            tampilkasir(45, 14);
            Console.SetCursorPosition(x, y);
            Console.Write("Masukkan Kode Kasir:");
            Console.CursorVisible = true;
            string kd5 = Console.ReadLine();

            bukatabel("select * from KASIR where ID_KASIR='" + kd5 + "'");
            back(45, 14, Console.WindowWidth - 4, 20, ConsoleColor.Black);
            int jumrec4 = tabel.Tables[0].Rows.Count;

            Console.SetCursorPosition(x+43, y);
            Console.WriteLine("┌───────────────┬────────────────┬────────────────┬────────────────┐");
            Console.SetCursorPosition(x+43, y + 1);
            Console.WriteLine("│      ID       │      NAMA      │ JENIS KELAMIN  │      ALAMAT    │");
            Console.SetCursorPosition(x+43, y + 2);
            Console.WriteLine("├───────────────┼────────────────┼────────────────┼────────────────┤");
            for (int i = 0; i < jumrec4; i++)
            {
                string idkasir = tabel.Tables[0].Rows[i][0].ToString();
                string nmkasir = tabel.Tables[0].Rows[i][1].ToString();
                string jeka = tabel.Tables[0].Rows[i][2].ToString();
                string alamat = tabel.Tables[0].Rows[i][3].ToString();

                string id5 = string.Format("{0,-15}", idkasir);
                string nm5 = string.Format("{0,-15}", nmkasir);
                string jk5 = string.Format("{0,-15}", jeka);
                string almt5 = string.Format("{0,-15}", alamat);

                Console.SetCursorPosition(x+43, y + 3 + i);
                Console.WriteLine("│" + id5 + "│" + nm5 + " │" + jk5 + " │" + almt5 + " │");
            }

            Console.SetCursorPosition(x+43, y + jumrec4 + 3);
            Console.WriteLine("└───────────────┴────────────────┴────────────────┴────────────────┘");

            Console.CursorVisible = true;

            Console.SetCursorPosition(x, y + 1);
            Console.Write("NAMA KASIR    :");
            string NAMA_KASIR5 = Console.ReadLine();

            Console.SetCursorPosition(x, y + 2);
            Console.Write("JENIS KELAMIN :");
            string JK5 = Console.ReadLine();

            Console.SetCursorPosition(x, y + 3);
            Console.Write("ALAMAT        :");
            string ALAMAT5 = Console.ReadLine();

            Console.SetCursorPosition(x, y + 7);
            Console.Write("APAKAH DATA DIRUBAH   ???[Y/N]");
            string jwb = Console.ReadLine();

            if (jwb.ToUpper() == "Y")
            {
                kenek.Open();
                sQL = "Update KASIR set NAMA_KASIR='"+ NAMA_KASIR5 +"',JK='"+ JK5 +"',ALAMAT='"+ ALAMAT5 +"' where ID_KASIR='"+ kd5 +"'";
                OleDbCommand edc = new OleDbCommand();
                edc.Connection = kenek;
                edc.CommandText = sQL;
                edc.ExecuteNonQuery();
                kenek.Close();
                MessageBox.Show("berhasil", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.CursorVisible = false;
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
            }
            else if (jwb.ToUpper() == "N")
            {
                kenek.Close();
                MessageBox.Show("Data tidak disimpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.CursorVisible = false;
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
            }
        }

        public void hapuskasir(int x, int y)
        {
            tampilkasir(45, 14);
            Console.SetCursorPosition(x, y);
            Console.Write("Masukkan Kode Kasir:");
            Console.CursorVisible = true;
            string kd5 = Console.ReadLine();

            bukatabel("select * from KASIR where ID_KASIR='" + kd5 + "'");
            back(45, 14, Console.WindowWidth - 4, 20, ConsoleColor.Black);
            int jumrec4 = tabel.Tables[0].Rows.Count;

            Console.SetCursorPosition(x + 43, y);
            Console.WriteLine("┌───────────────┬────────────────┬────────────────┬────────────────┐");
            Console.SetCursorPosition(x + 43, y + 1);
            Console.WriteLine("│      ID       │      NAMA      │ JENIS KELAMIN  │      ALAMAT    │");
            Console.SetCursorPosition(x + 43, y + 2);
            Console.WriteLine("├───────────────┼────────────────┼────────────────┼────────────────┤");
            for (int i = 0; i < jumrec4; i++)
            {
                string idkasir = tabel.Tables[0].Rows[i][0].ToString();
                string nmkasir = tabel.Tables[0].Rows[i][1].ToString();
                string jeka = tabel.Tables[0].Rows[i][2].ToString();
                string alamat = tabel.Tables[0].Rows[i][3].ToString();

                string id5 = string.Format("{0,-15}", idkasir);
                string nm5 = string.Format("{0,-15}", nmkasir);
                string jk5 = string.Format("{0,-15}", jeka);
                string almt5 = string.Format("{0,-15}", alamat);

                Console.SetCursorPosition(x + 43, y + 3 + i);
                Console.WriteLine("│" + id5 + "│" + nm5 + " │" + jk5 + " │" + almt5 + " │");
            }

            Console.SetCursorPosition(x + 43, y + jumrec4 + 3);
            Console.WriteLine("└───────────────┴────────────────┴────────────────┴────────────────┘");

            Console.SetCursorPosition(x, y + 2);
            Console.Write("APAKAH DATA DIHAPUS   ???[Y/N]");
            string jwb = Console.ReadLine();

            if (jwb.ToUpper() == "Y")
            {
                kenek.Open();
                sQL = "Delete From KASIR where ID_KASIR='" + kd5 + "'";
                OleDbCommand edc = new OleDbCommand();
                edc.Connection = kenek;
                edc.CommandText = sQL;
                edc.ExecuteNonQuery();
                kenek.Close();
                MessageBox.Show("berhasil", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.CursorVisible = false;
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
            }
            else if (jwb.ToUpper() == "N")
            {
                kenek.Close();
                MessageBox.Show("Data tidak disimpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.CursorVisible = false;
                back(3, 14, Console.WindowWidth - 4, Console.WindowHeight - 4, ConsoleColor.Black);
            }
        }


        public void kotak(int x, int y, int x1, int y1, ConsoleColor wirni)
        {
            Console.ForegroundColor = wirni;
            Console.SetCursorPosition(x, y);
            Console.Write("┌");
            Console.SetCursorPosition(x1, y);
            Console.Write("┐");
            Console.SetCursorPosition(x, y1);
            Console.Write("└");
            Console.SetCursorPosition(x1, y1);
            Console.Write("┘");

            for (int klm = x + 1; klm < x1; klm++)
            {
                Console.SetCursorPosition(klm, y);
                Console.Write("─");
                Console.SetCursorPosition(klm, y1);
                Console.Write("─");
            }

            for (int brs = y + 1; brs < y1; brs++)
            {
                Console.SetCursorPosition(x, brs);
                Console.Write("│");
                Console.SetCursorPosition(x1, brs);
                Console.Write("│");
            }
        }

        public void rata_tengah(string kata, int baris, ConsoleColor tulisan)
        {
            Console.ForegroundColor = tulisan;
            Console.SetCursorPosition((Console.WindowWidth - kata.Length) / 2, baris);
            Console.Write(kata);
        }

        public void tengah(string kata1, int kolom1, int baris1, ConsoleColor bawah)
        {
            Console.ForegroundColor = bawah;
            Console.SetCursorPosition(kolom1, baris1);
            Console.Write(kata1);
        }

        public void kiri(string kata2, int kolom2, int baris2, ConsoleColor kiri)
        {
            Console.ForegroundColor = kiri;
            Console.SetCursorPosition(kolom2, baris2);
            Console.Write(kata2);
        }

        public void kanan(string kata3, int kolom3, int baris3, ConsoleColor kanan)
        {
            Console.ForegroundColor = kanan;
            Console.SetCursorPosition(kolom3, baris3);
            Console.Write(kata3);
        }

        public void kitik(int x, int y, int x1, int y1, ConsoleColor warna)
        {
            Console.ForegroundColor = warna;

            Console.SetCursorPosition(x, y);
            Console.Write("┌");

            Console.SetCursorPosition(x1, y);
            Console.Write("┐");

            Console.SetCursorPosition(x, y1);
            Console.Write("└");

            Console.SetCursorPosition(x1, y1);
            Console.Write("┘");

            for (int klm = x + 1; klm <= x1 - 1; klm++)
            {
                Console.SetCursorPosition(klm, y);
                Console.Write("~");

                Console.SetCursorPosition(klm, y);
                Console.Write("~");

                Console.SetCursorPosition(klm, y1);
                Console.Write("~");
            }
            for (int brs = y + 1; brs <= y1 - 1; brs++)
            {
                Console.SetCursorPosition(x, brs);
                Console.Write("{ ");

                Console.SetCursorPosition(x1, brs);
                Console.Write("}");
            }
        }

        public void back(int x, int y, int x1, int y1, ConsoleColor wrn)
        {
            for (int i = x; i < x1; i++)
            {
                for (int j = y; j < y1; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.BackgroundColor = wrn;
                    Console.Write(" ");
                }
            }
        }

        public void loading(int x, int y)
        {
            for (int a = 0; a <= 65; a++)
            {
                Console.SetCursorPosition(x + a, y);
                Console.Write("▓...");
                Console.SetCursorPosition(Console.WindowWidth / 2 + 4, y - 1);
                Console.Write((a + 35) + "%");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, y - 1);
                Console.Write("Loading..");
                for (int t = 1; t < 50000000; t++) { }
            }
        }

    }
}
