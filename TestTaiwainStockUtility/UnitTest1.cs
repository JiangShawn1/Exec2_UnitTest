using TaiwainStockUtility;
namespace TestTaiwainStockUtility
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]

        public void IsTradingTime_���������ɶ����T�Ǧ^false()
        {
            DateTime dt = new DateTime(2022,10,22,09,0,0);
            var result = new TaiwainStockUtility.TaiwainStockUtility();

            bool final = result.IsTradingTime(dt);
            
            Assert.AreEqual(false, final);
        }
        [Test]
        public void IsTradingTime_���������ɶ����T�Ǧ^true()
        {
            DateTime dt = new DateTime(2022, 10, 27, 09, 0, 0);
            var result = new TaiwainStockUtility.TaiwainStockUtility();

            bool final = result.IsTradingTime(dt);

            Assert.AreEqual(true, final);
        }
        [Test]
        public void IsTradingTime_���������ɶ����~�Ǧ^false()
        {
            DateTime dt = new DateTime(2022, 10, 27, 08, 0, 0);
            var result = new TaiwainStockUtility.TaiwainStockUtility();

            bool final = result.IsTradingTime(dt);

            Assert.AreEqual(false, final);
        }
        [Test]
        public void IsTradingTime_���������ɶ����~�Ǧ^false()
        {
            DateTime dt = new DateTime(2022, 10, 22, 08, 0, 0);
            var result = new TaiwainStockUtility.TaiwainStockUtility();

            bool final = result.IsTradingTime(dt);

            Assert.AreEqual(false, final);
        }
    }
    
}