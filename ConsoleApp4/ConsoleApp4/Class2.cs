using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Class2
    {
        //This is a comment in the class
        private void MethodGeniar()
        {
            Class1 invokacior = new Class1();

            invokacior.Caca1();
            invokacior.Caca2();
            
            //This is a comment in the method
        }

        private void ThisIsANewMethod()
        { 
            //And This is a Test
        }

        private void MethodGeniarNuevo2()
        {
            Class1 invokacior = new Class1();

            invokacior.Caca1();
            invokacior.Caca1("test");

            Test();
            Test();

            if (1 == 1)
            { }
        }

        private void Test()
        { }
    }
}
