using System.Diagnostics;
//using TestsPractice;
namespace TestProject;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void BiggerTest()
    {
        //arrange
        int a = 10;
        int b = 1;
        bool expected = true;

        //action
        bool result = Bigger(a, b);

        //assert
        Assert.AreEqual(expected, result);
    }
}