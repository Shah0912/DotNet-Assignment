using System;
using System.Collections.Generic;
using System.Text;
using Nunit.Framework;

namespace StackTest
{

[TestFixture]
class TestStackClass
{
MyStackClass stk = null;

[SetUp]
public void set_up()
{
stk = new MyStackClass();
}

[Test]
public void push_test()
{
object val = stk.Push(5);
Assert.AreEqual(5,val);
}

[Test]
public void pop_test()
{
stk.Push(5);
object val2 = stk.Pop();
Assert.AreEqual(5,val2);
}

[Test]

public void pop_excp_test()
{

var ex = Assert.Throws<InvalidOperationException>(()=> stk.Pop());
Assert.That(ex.Message,Is.EqualTo("Stack is Empty"));


}
}
}