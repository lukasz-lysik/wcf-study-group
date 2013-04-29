using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace SelfHosting
{
  class Program
  {
    static void Main(string[] args)
    {
      var sh = new ServiceHost(typeof(HelloWorldServiceLibrary.HelloWorldService));

      try
      {
        sh.Open();
        Console.ReadLine();
        sh.Close();
      }
      catch(Exception e)
      {
        sh.Abort();
      }
    }
  }
}
