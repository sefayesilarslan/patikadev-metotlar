namespace metotlariki
{
    
    class Program
    {
        public static void Main(string[] args){
            //out parametreler

            string sayi="999";
            

            bool sonuc=int.TryParse(sayi,out int outsayi);//sayıyı çevirip çeviremediğine baktık
        
            if(sonuc){

                Console.WriteLine("Başarili");
                Console.WriteLine(outsayi);
            }
            else{
                Console.WriteLine("Başarisiz!!");
            }

            Metotlar instance=new Metotlar();
            instance.Topla(5,8,out int toplamsonucu);
            Console.WriteLine(toplamsonucu);


            //Metot Overloading (Metot aşırı yükleme)

        int deger=1922;
        string deger2="SEFA";
        instance.ekranaYaz(deger);
        instance.ekranaYaz(deger2);
        instance.ekranaYaz("Sefa"," Yeşilarslan");

        // METOT İMZASI
        // Metot adı + parametre sayisi+ parametre

        }
    }

    class Metotlar{

       public void Topla(int a, int b, out int toplam){
            
            toplam=a+b;
       } 

       public void ekranaYaz(string veri){
        Console.WriteLine(veri);
       }
        public void ekranaYaz(int veri){
        Console.WriteLine(veri);
       }

        public void ekranaYaz(string veri,  string veri2){
        Console.WriteLine(veri+veri2);
       }
    }
}
