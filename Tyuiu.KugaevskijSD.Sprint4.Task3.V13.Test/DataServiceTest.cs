using Tyuiu.KugaevskijSD.Sprint4.Task3.V13.Lib;
namespace Tyuiu.KugaevskijSD.Sprint4.Task3.V13.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void Calculate_Test()
    {
        int[,] matrix = {
            {4, 7, 4, 2, 1},
            {6, 7, 3, 6, 5},
            {6, 5, 3, 3, 5},
            {4, 4, 6, 4, 7},
            {2, 1, 2, 3, 4}
        };
        DataService dataService = new DataService();
        int expectedSum = 18;

        int actualSum = dataService.Calculate(matrix);

        Assert.AreEqual(expectedSum, actualSum);
    }
}