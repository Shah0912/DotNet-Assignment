
namespace TestProject
{
    public class Tests
    {
        private MyStackClass.MyStackClass stack;
        [SetUp]
        public void Setup()
        {
            stack = new MyStackClass.MyStackClass();
        }
        [Test]
        public void TestEmpty()
        {
            try
            {
                stack.Top();
            }catch(Exception e)
            {
                Assert.AreEqual("Stack is Empty",e.Message );
            }
            
            
        }


        [Test]
        public void TestPush()
        {
            stack.Push("A");
            Assert.AreEqual("A", stack.Top());
        }
        [Test]
        public void TestPop()
        {
            stack.Push("B");
            stack.Push("C");
            Assert.AreEqual("C", stack.Pop());


        }
        [Test]
        public void TestTop()
        {
            stack.Push("D");
            Assert.AreEqual("D", stack.Top());
        }
    }
}