using Tyuiu.KugaevskijSD.Sprint4.Task6.V9.Lib;
namespace Tyuiu.KugaevskijSD.Sprint4.Task6.V9.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();
        string[] mas = { "Красный", "Оранжевый", "Желтый", "Зеленый", "Синий", "Индиго", "Фиолетовый" };
        int wait = 3;
        int res = ds.Calculate(mas);
        Assert.AreEqual(wait, res);
    }
}