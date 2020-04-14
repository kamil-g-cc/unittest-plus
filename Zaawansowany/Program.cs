using System;

namespace unittest_plus
{
    //TODO: sprawdzić Damiana link, czyli 
    /*
        https://stackoverflow.com/questions/9122708/unit-testing-private-methods-in-c-sharpClass target = new Class();
        PrivateObject obj = new PrivateObject(target);
        var retVal = obj.Invoke("PrivateMethod");
        Assert.AreEqual(expectedVal, retVal);

    */
    public class Program
    {
        /*
            throws exception when value is <> 7
        */
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
