namespace StackLibrary.Tests
{
    public class StackClassTest
    {
        [Test]
        public void PushTest()
        {
            var st = new StackClass();
            st.Push("A");
            Assert.That(st.Top(), Is.EqualTo("A"));
        }

        [Test]
        public void PopTest()
        {
            var st = new StackClass();
            st.Push("B");
            st.Push("C");
            Assert.That(st.Pop(), Is.EqualTo("C"));
        }

        [Test]
        public void TopTest()
        {
            var st = new StackClass();
            Assert.Throws<InvalidOperationException>(() => st.Top());
            st.Push("D");
            Assert.That(st.Top(), Is.EqualTo("D"));
        }
    }
}