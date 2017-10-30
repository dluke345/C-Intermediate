using System;

namespace CSharpInheritance
{
    //This is the class we are using in the Installer and DbMigrator classes(Composition relationships)
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}