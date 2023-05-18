namespace AssemblyLevel;

[TestClass]
public class UnitTest1
{
    [AssemblyInitialize]
    public static void AssemblyInitialize(TestContext testContext)
    {
        Console.WriteLine("Assembly Initialize");
    }

    [AssemblyCleanup]
    public static void AssemblyCleanup()
    {
        Console.WriteLine("Assembly Cleanup");
    }

    [ClassInitialize]
    public static void ClassInitialize(TestContext testContext)
    {
        Console.WriteLine("Class Initialize");
    }

    [ClassCleanup]
    public static void ClassCleanup()
    {
        Console.WriteLine("Class Cleanup");
    }

    [TestInitialize]
    public void TestInitialize()
    {
        Console.WriteLine("Test Initialize");
    }

    [TestCleanup]
    public void TestCleanup()
    {
        Console.WriteLine("Test Cleanup");
    }

    [TestMethod]
    public void TestMethod1()
    {
        Console.WriteLine("Test Method 1 ..............");
    }

    [TestMethod]
    public void TestMethod2()
    {
        Console.WriteLine("Test Method 2 ..............");
    }
}
