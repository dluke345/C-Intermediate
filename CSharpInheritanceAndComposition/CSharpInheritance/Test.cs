using System;

namespace CSharpInheritance
{
    //Test is inheriting from the PresentationObject Class(Inheritance)
    public class Test : PresentationObject
    {

        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("We added a link to " + url);
        }

    }
}