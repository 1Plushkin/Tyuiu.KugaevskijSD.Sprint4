using Tyuiu.KugaevskijSD.Sprint4.Task7.V8.Lib;
namespace Tyuiu.KugaevskijSD.Sprint4.Task7.V8.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();
        int rows = 3;
        int columns = 4;
        int[,] mtrx = new int[rows, columns];
        string str = "264795863157";
        int res = ds.Calculate(rows, columns, str);
    }
}