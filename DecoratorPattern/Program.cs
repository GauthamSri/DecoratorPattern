using System;


namespace DecoratorPattern
{
  class decoratorpattern
  {
    interface Icomponent
    {
      string operation();
    }
    class component:Icomponent
    {
      public string operation()
      {
        return "I m learning Design patterns";
      }
    }

    class decorator1 : Icomponent
    {
      Icomponent component;
      public decorator1(Icomponent c)
      {
        component = c;
      }
      public string operation()
      {
        string s = component.operation();
        s += "using O'Riley Book";
        return s;
      }

    }

    class decorator2 : Icomponent
    {
      Icomponent component;
      public string addedText = "in c#";

       public decorator2(Icomponent c)
      {
        component = c;
      }
      public string operation()
      {
        string s = component.operation();
        s += "for the first time";
        return s;
      }
      public string addedBehaviour()
      {
        return "this is a practice app";
      }
    }

    static void Main(string[] args)
    {
      Icomponent c = new component();
      Console.WriteLine(c.operation());
      decorator1 d = new decorator1(c);
      Console.WriteLine(d.operation());
      Console.WriteLine(new decorator2(d).operation());
      Console.Read();

    }
  }
}
