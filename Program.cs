using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 1, hedef = 10, sayı = 10, sayac1 = 0, sayı1, sayı2, toplam = 0, sayı3;
            string soru, giris, giris1, giris2;




            Console.WriteLine("Hoş Geldiniz Hangi Soru İstiyorsunuz Seçeniz ^_^ ");
            Console.WriteLine("1.1'den 10'a Çift Sayıları Yazdıran While Döngüsü ile Kullanan.");
            Console.WriteLine("2.Kullanıcıdan İsim Alarak While Döngüsü ile Sonlandıran.");
            Console.WriteLine("3.Kullanıcıdan İki Sayı Alıp Çift ve Tek Sayıları Toplayan While Döngüsü ile Kullanan.");
            Console.WriteLine("4.Kullanıcı Adı ve Şifre Doğrulama İçin While Döngüsü ile Kullanan.");
            Console.Write("Sorunuz Numarası Yazınız : ");
            soru = Console.ReadLine();
            do
            {
                if (soru == "1")
                {
                    while (sayac <= hedef)
                    {
                        if (sayac % 2 == 0)
                        {
                            Console.WriteLine(sayac);
                        }
                        sayac++;
                    }

                }


                else if (soru == "2")
                {
                    while (sayac1 < sayı)
                    {
                        Console.Write("Adınız Girin :");
                        giris = Console.ReadLine();
                        sayac1++;
                        if (giris == "emcet")
                        {
                            break;
                        }
                    }

                }

                else if (soru == "3")
                {
                    Console.Write("1.Sayınız Giriniz:");
                    sayı1 = int.Parse(Console.ReadLine());

                    Console.Write("2.Sayınız Giriniz : ");
                    sayı2 = int.Parse(Console.ReadLine());

                    if (sayı1 <= sayı2)
                    {
                        while (sayı1 <= sayı2)
                        {
                            if (sayı1 % 2 == 0)
                            {
                                toplam += sayı1;
                                Console.WriteLine(sayı1);
                            }
                            sayı1++;
                        }
                    }
                    else if (sayı1 >= sayı2)
                    {
                        while (sayı1 >= sayı2)
                        {
                            if (sayı2 % 2 == 1)
                            {
                                toplam += sayı2;
                                Console.WriteLine(sayı2);
                            }
                            sayı2++;
                        }

                    }
                    Console.WriteLine("Sonucu : " + " " + toplam);

                }

                else if (soru == "4")
                {
                    Console.Write("Sayınız Giriniz Eğer Sayınız Çifit Sayısı Emcet Hesapını Geçersiniz\r\nEğer tek Sayısı Ahmet Hesapını Geçersiniz : ");
                    sayı3 = int.Parse(Console.ReadLine());

                    if (sayı3 % 2 == 0)
                    {
                        Console.WriteLine("Emcet Hesapını Geçetiniz :) ");
                        while (true)
                        {
                            Console.WriteLine("Hesapınız Adınız Giriniz : ");
                            giris1 = Console.ReadLine();
                            if (giris1 == "Emcet Hazani")
                            {
                                Console.WriteLine("Doğru Adınız Giridiniz. ");
                                break;

                            }
                            else if (giris1 != "Emcet Hazani")
                            {
                                Console.WriteLine("Yenliş Adınız Giridiniz.");
                                continue;
                            }
                        }
                        while (true)
                        {
                            Console.WriteLine("Hesapınız Şifreniz Giriniz : ");
                            giris2 = Console.ReadLine();
                            if (giris2 == "emcetfox1997")
                            {

                                break;
                            }
                            else if (giris1 != "emcetfox1997")
                            {
                                Console.WriteLine("Yenliş Şifreniz Giridiniz.");
                            }
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ahmet Hesapını Geçetiniz :) ");
                        while (true)
                        {
                            Console.WriteLine("Hesapınız Adınız Giriniz : ");
                            giris1 = Console.ReadLine();
                            if (giris1 == "Ahmet Hazani")
                            {
                                Console.WriteLine("Doğru Adınız Giridiniz. ");
                                break;
                            }
                            else if (giris1 != "Ahmet Hazani")
                            {
                                Console.WriteLine("Yenliş Adınız Giridiniz.");
                                continue;
                            }
                        }
                        while (true)
                        {
                            Console.WriteLine("Hesapınız Şifreniz Giriniz : ");
                            giris2 = Console.ReadLine();
                            if (giris2 == "ahmet1997")
                            {
                                Console.WriteLine("Doğru Giriş Yaptınız. ");
                                break;
                            }
                            else if (giris1 != "ahmet1997")
                            {
                                Console.WriteLine("Yenliş Şifreniz Giridiniz.");
                            }
                            continue;
                        }
                    }
                }
                Console.WriteLine("Eğer Program Kapatmak istyorsunuz (0) Yazın :");    
            } while (soru == "0");
            

            Console.ReadKey();
        }

    }
}








