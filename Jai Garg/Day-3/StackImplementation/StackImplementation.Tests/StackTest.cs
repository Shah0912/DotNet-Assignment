using System;
using NUnit.Framework;

namespace StackImplementation.Tests
{
    public class StackTest
    {

        [Test]
        public void PushTest()
        {
            var st = new MyStackClass();
            object expected = 10;
            object actual = st.Push(expected);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PopTest()
        {
            var st = new MyStackClass();
            object expected = 10;
            _ = st.Push(expected);
            object actual = st.Pop();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TopTest()
        {
            var st = new MyStackClass();
            Assert.Throws<InvalidOperationException>(() => st.Top());
            object expected = 10;
            _ = st.Push(expected);
            object actual = st.Top();
            Assert.AreEqual(expected, actual);
        }
    }
}
