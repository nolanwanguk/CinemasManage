namespace CinemasManage
{
    public class Tests
    {
        private Solver Solver;
        [SetUp]
        public void Setup()
        {
            Solver = new Solver();
        }

        [Test]
        public void Test1()
        {
            Assert.That(Solver.Reserve(3), Is.EqualTo(new List<string> { "A1", "A2", "A3"}));
            Assert.That(Solver.Reserve(3), Is.EqualTo(new List<string> { "A4", "A5", "B1" }));
            Assert.That(Solver.Reserve(3), Is.EqualTo(new List<string> { "B2", "B3", "B4" }));
            Assert.That(Solver.Reserve(3), Is.EqualTo(new List<string> { "B5", "C1", "C2" }));
            Assert.That(Solver.Reserve(2), Is.EqualTo(new List<string> { "C3", "C4" }));
            Assert.That(Solver.Reserve(2), Is.EqualTo(new List<string> { "C5" }));
        }
        
    }
}