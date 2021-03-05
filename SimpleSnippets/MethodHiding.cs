using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippets
{
    class A
    {
        public void Foo() { Console.WriteLine("A::Foo()"); }
    }

    class B : A
    {
        public new void Foo() { Console.WriteLine("B::Foo()"); }
    }

    public class Test
    {
        //static void Main(string[] args)
        //{
        //    A a;
        //    B b;

        //    a = new A();
        //    b = new B();
        //    a.Foo();  // output --> "A::Foo()"
        //    b.Foo();  // output --> "B::Foo()"

        //    a = new B();
        //    a.Foo();  // output --> "A::Foo()"            

        //}
    }

    class Parent
    {
        public virtual void Foo() { Console.WriteLine("A::Foo()"); }
    }

    class Child : Parent
    {
        public override void Foo() { Console.WriteLine("B::Foo()"); }
    }

    class Test2
    {
        //static void Main(string[] args)
        //{
        //    Parent a;
        //    Child b;

        //    a = new Parent();
        //    b = new Child();
        //    a.Foo();  // output --> "A::Foo()"
        //    b.Foo();  // output --> "B::Foo()"

        //    a = new Child();
        //    a.Foo();  // output --> "B::Foo()"
        //}
    }
}
