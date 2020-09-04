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
            Assert.IsTrue(Program.ConvertColumn(1) == "A");
            Assert.IsTrue(Program.ConvertColumn(2) == "B");
            Assert.IsTrue(Program.ConvertColumn(3) == "C");
            Assert.IsTrue(Program.ConvertColumn(4) == "D");
            Assert.IsTrue(Program.ConvertColumn(5) == "E");
            Assert.IsTrue(Program.ConvertColumn(26) == "Z");
            Assert.IsTrue(Program.ConvertColumn(27) == "AA");
            Assert.IsTrue(Program.ConvertColumn(28) == "AB");
            Assert.IsTrue(Program.ConvertColumn(29) == "AC");
            Assert.IsTrue(Program.ConvertColumn(52) == "AZ");
            Assert.IsTrue(Program.ConvertColumn(53) == "BA");
            Assert.IsTrue(Program.ConvertColumn(676) == "AAA");
        }
    }
}
