using System;
namespace SimpleDiDemo
{
    public class ClassB : IInterfaceB
    {
        private IInterfaceA _classA;

        public ClassB (IInterfaceA classA)
        {
            _classA = classA;
        }

        public void DoB()
        {
            _classA.DoA();
            Console.WriteLine("Do B");
        }

        
    }
}

