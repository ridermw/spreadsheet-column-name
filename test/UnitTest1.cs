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
            Assert.IsTrue(Program.ConvertColumn(0) == "A");
        }

        [TestMethod]
        public void InvalidInput()
        {            
            Assert.IsTrue(Program.ConvertColumn(-1) == "");
        }
        [TestMethod]
        public void ValidInputMultipuleDigits()
        {            
            Assert.IsTrue(Program.ConvertColumn(26) == "AA");
            Assert.IsTrue(Program.ConvertColumn(28) == "AC");
            Assert.IsTrue(Program.ConvertColumn(29) == "AD");
            Assert.IsTrue(Program.ConvertColumn(51) == "AZ");
            Assert.IsTrue(Program.ConvertColumn(52) == "BA");
            Assert.IsTrue(Program.ConvertColumn(53) == "BB");
            Assert.IsTrue(Program.ConvertColumn(54) == "BC");
            Assert.IsTrue(Program.ConvertColumn(675) == "YZ");
            Assert.IsTrue(Program.ConvertColumn(676) == "ZA");
            Assert.IsTrue(Program.ConvertColumn(677) == "ZB");
            Assert.IsTrue(Program.ConvertColumn(700) == "ZY");
            Assert.IsTrue(Program.ConvertColumn(701) == "ZZ");
            Assert.IsTrue(Program.ConvertColumn(702) == "AAA");
        }
        
        [TestMethod]
        public void ValidInputSingleDigits()
        {
            Assert.IsTrue(Program.ConvertColumn(0) == "A");
            Assert.IsTrue(Program.ConvertColumn(1) == "B");
            Assert.IsTrue(Program.ConvertColumn(2) == "C");
            Assert.IsTrue(Program.ConvertColumn(3) == "D");
            Assert.IsTrue(Program.ConvertColumn(4) == "E");
            Assert.IsTrue(Program.ConvertColumn(5) == "F");
            Assert.IsTrue(Program.ConvertColumn(25) == "Z");
            Assert.IsTrue(Program.ConvertColumn(51) == "AZ");
            
        }
    }
}
