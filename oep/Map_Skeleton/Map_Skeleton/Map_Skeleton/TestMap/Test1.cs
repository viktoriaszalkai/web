using Map_Skeleton;
namespace TestMap
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        //unit tesztek
        // solution jobbklikk, add, new project, MSTest Test Projekt,
        // Test project, jobb klikk, add project refernce pipaljad be az alap projektet 
        public void TestSetEmpty()
        {


            Map_Skeleton.Map map = new();

            Assert.AreEqual(map.ToString(), "[]");

            map.Insert(new Map_Skeleton.Element(1, "barack"));
            Assert.AreEqual(map.ToString(), "[(1:barack)]");

            map.SetEmpty();
            Assert.AreEqual(map.ToString(), "[]");


        }

        [TestMethod]
        public void TestCount()
        {
            Map_Skeleton.Map map = new();

            Assert.AreEqual(map.Count(), 0);
            map.Insert(new Map_Skeleton.Element(1, "barack"));
            map.Insert(new Map_Skeleton.Element(2, "alma"));
            map.Insert(new Map_Skeleton.Element(3, "korte"));
            map.Insert(new Map_Skeleton.Element(0, "banan"));

            Assert.AreEqual(map.Count(), 4);
            map.SetEmpty();
            Assert.AreEqual(map.Count(), 0);


        }
    }
}
