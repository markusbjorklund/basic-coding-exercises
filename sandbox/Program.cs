using System;
using System.Collections.Generic;

namespace sandbox
{
  class Program
  {
    static void Main(string[] args)
    {
      // testarea

      Person matti = new Person("Matti");
      Person juhana = new Person("Juhana");

      matti.height = 1.1;
      matti.weight = 86;

      juhana.height = 175;
      juhana.weight = 64;

      Console.WriteLine(matti.name + " ---- " + matti.height + " ------ " + juhana.weight + " -----" + ", body mass index is ");

      Console.WriteLine(matti.name + ", body mass index is " + matti.BodyMassIndex());
      Console.WriteLine(juhana.name + ", body mass index is " + juhana.BodyMassIndex());

    }
    // testarea
  }
}