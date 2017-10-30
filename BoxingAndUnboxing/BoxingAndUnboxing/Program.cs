using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //there is no type saftey using ArrayList
            var list = new ArrayList();
            list.Add(1); //boxing is happening here because 1 is a value type
            list.Add("David"); //boxing will not happen here because string is a reference type
            list.Add(DateTime.Today); //boxing is happening here because DateTime is a struct which is a value type

            //Unboxing
            var number = (int) list[1];

            //There is type saftey here because list can only be integers
            var anotherList = new List<int>();
            anotherList.Add(1);

            //There is type saftey here because list can only be strings
            var names = new List<string>();
            names.Add("Poop");

        }
    }
}
