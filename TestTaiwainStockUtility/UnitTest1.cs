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

        public void IsTradingTime_日期為假日時間正確傳回false()
        {
            DateTime dt = new DateTime(2022,10,22,09,0,0);
            var result = new TaiwainStockUtility.TaiwainStockUtility();

            bool final = result.IsTradingTime(dt);
            
            Assert.AreEqual(false, final);
        }
        [Test]
        public void IsTradingTime_日期為平日時間正確傳回true()
        {
            DateTime dt = new DateTime(2022, 10, 27, 09, 0, 0);
            var result = new TaiwainStockUtility.TaiwainStockUtility();

            bool final = result.IsTradingTime(dt);

            Assert.AreEqual(true, final);
        }
        [Test]
        public void IsTradingTime_日期為平日時間錯誤傳回false()
        {
            DateTime dt = new DateTime(2022, 10, 27, 08, 0, 0);
            var result = new TaiwainStockUtility.TaiwainStockUtility();

            bool final = result.IsTradingTime(dt);

            Assert.AreEqual(false, final);
        }
        [Test]
        public void IsTradingTime_日期為假日時間錯誤傳回false()
        {
            DateTime dt = new DateTime(2022, 10, 22, 08, 0, 0);
            var result = new TaiwainStockUtility.TaiwainStockUtility();

            bool final = result.IsTradingTime(dt);

            Assert.AreEqual(false, final);
        }
    }
    
}