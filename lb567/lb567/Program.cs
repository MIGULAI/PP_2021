using System;

namespace lb567
{
    class Program
    {
        static void Main(string[] args)
        {
            Interpol interpol = new Interpol();

            Criminal firstCriminal = new Criminal(new Person("Yaric","Pupkin",DateTime.Now.ToString(),"188"), new Context(new ConcreteStateA()));
            firstCriminal.SetStatus(Wanted.Red);
            interpol.AddItem(firstCriminal);
            foreach(Criminal element in interpol)
            {
                Console.WriteLine(element.GetCriminalInfo());
            }
        }
    }
}
