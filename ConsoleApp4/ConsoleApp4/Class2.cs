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
            invokacior.testc = 1;
            invokacior.Caca1("a");
            Test();
            Test();
            //This is a comment in the method
        }

        private void MethodGeniarNuevo()
        {
            Class1 invokacior = new Class1();

            invokacior.Caca1();
            invokacior.Caca2();
          
            Test();
            Test();

            if (1 == 1)
            {
                if (1 != 0 && 1 == 1 || 1 == 9)
                {
                    var j = 0;
                    switch (j)
                    {
                        case 1:
                            var z = 1;
                            z++;
                            break;

                        case 2:
                            break;

                        default:
                            break;
                    }
                }
            }
            var i = 0;

            switch (i)
            {
                case 1:
                    break;

                case 2:
                    break;

                default:
                    break;
            }
        }

        private void MethodGeniarNuevo2()
        {
            Class1 invokacior = new Class1();

            invokacior.Caca1();
            invokacior.Caca2();

            Test();
            Test();

            if (1 == 1)
            { }
        }

        private void Test()
        { }
    }
}
