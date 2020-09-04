using Microsoft.VisualStudio.TestTools.UnitTesting;
using spreadsheet_column_name;

namespace test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Init()
        {
            Assert.IsTrue(Program.ConvertColumn(1) == "A");
        }
    }
}
