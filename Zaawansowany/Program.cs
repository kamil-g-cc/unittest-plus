using System;

namespace unittest_plus
{
    class Program
    {
        static public int NaPotrzebyWyjatku(int a){
            if(a==7) {
                Console.WriteLine("jesteś szczęściarzem, bo nie zobaczysz wyjątku :)");
                return 0;
            }
            throw new NotImplementedException("jeszcze nie zaimplementowałem");
        }
        
        static void Main(string[] args)
        {
            try{
                NaPotrzebyWyjatku(3);
            } catch (Exception e){
                Console.WriteLine("nie masz szczęścia, bo "+e.Message);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
