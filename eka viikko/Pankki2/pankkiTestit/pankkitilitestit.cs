using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pankki2;

namespace pankkiTestit
{
    [TestClass]
    public class pankkitilitestit
    {
        [TestMethod]
        public void Otto_OikeallaSummalla()
        {
            double alkuSaldo = 11.99;
            double ottoSumma = 4.55;
            double oletettu = 7.44;
            Pankkitili tili = new Pankkitili("pertti erämerkki", alkuSaldo);

            //toiminto
            tili.Otto(ottoSumma);

            //olettettu lopputulos
            double todellinen = tili.Saldo;

            Assert.AreEqual(oletettu, todellinen, 0.001, "Tililtä otto ei onnistunut");

            

        }
    }
}
