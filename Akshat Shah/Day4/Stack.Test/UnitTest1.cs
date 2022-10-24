namespace Stack.Test
{
    public class Tests
    {
        MyStackClass stack;

        [SetUp]
        public void Setup()
        {
            stack = new MyStackClass();
        }

        [Test]
        public void IsInitiallyEmpty()
        {
            Assert.That(stack.IsEmpty, Is.EqualTo(true));
        }

        [Test]
        public void UnderflowRaisesException()
        {
            Assert.Catch(typeof(InvalidOperationException), () => stack.Top(), "Stack is empty");
            Assert.Catch(typeof(InvalidOperationException), () => stack.Pop(), "Stack is empty");
        }

        [Test]
        public void ElementsPushedAndPoppedInCorrectOrder()
        {
            Assert.That(stack.IsEmpty, Is.EqualTo(true));
            for (int i = 0; i < 3; i++)
                stack.Push(i);
            Assert.That(stack.IsEmpty, Is.EqualTo(false));

            for (int i = 2; i >= 0; i--)
            {
                Assert.That(stack.Top(), Is.EqualTo(i));
                Assert.That(stack.Pop(), Is.EqualTo(i));
            }

            Assert.That(stack.IsEmpty, Is.EqualTo(true));
        }

    }
}