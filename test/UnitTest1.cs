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

        [TestMethod]
        public void InvalidInput()
        {
            Assert.IsTrue(Program.ConvertColumn(0) == "");
            Assert.IsTrue(Program.ConvertColumn(-1) == "");
        }
        [TestMethod]
        public void ValidInput()
        {
            Assert.IsTrue(Program.ConvertColumn(26) == "Z");
            Assert.IsTrue(Program.ConvertColumn(1) == "A");
            Assert.IsTrue(Program.ConvertColumn(27) == "AA");
            
        }
    }
}
