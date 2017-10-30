using System;

namespace CSharpInheritance
{
    //This is the class we are inheriting from in the Test class(Inheritance)
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied to clipboard");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated");
        }
    }
}