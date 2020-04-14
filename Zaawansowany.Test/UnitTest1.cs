using System;
using Xunit;
using unittest_plus;
namespace Zaawansowany.Test
{
    public class UnitTest1
    {
        
        [Fact]
        public void NaPotrzebyWyjatku_NonExceptionInput_Return0()
        {
            var wynik = Program.NaPotrzebyWyjatku(7);
            Assert.Equal(0, wynik);
        }
        [Fact]
        public void NaPotrzebyWyjatku_WeExpectNowException_NoReturnValue(){
            //TODO: Kamil: wyjaśnić Action()
            Assert.Throws<NotImplementedException>(()=>Program.NaPotrzebyWyjatku(3));
        }
    }
}
