using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pankkitili;

namespace Pankki2
{
    [TestClass]
    public class pankkitiliTesti
    {
        [TestMethod]
        public void Otto_OikeallaSummalla()
        {
            double alkuSaldo = 11.99;
            double ottoSumma = 4.55;
            double oletettu = 7.44;
            Pankkkitili = new Pankkkitili("pertti erämerkki", alkuSaldo);
        }
    }
}