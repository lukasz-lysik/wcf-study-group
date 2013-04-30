using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace CustomServiceHost
{
    public class CustomServiceHost : ServiceHost
    {
      public CustomServiceHost() : base(typeof(HelloWorldServiceLibrary.HelloWorldService))
      {
      }

      protected override void OnOpening()
      {
        base.OnOpening();

        var meta = this.Description.Behaviors.Find<ServiceMetadataBehavior>();
        if (meta != null)
        {
          meta.HttpGetEnabled = true;
        }
        else
        {
          meta = new ServiceMetadataBehavior();
          meta.HttpGetEnabled = true;
          this.Description.Behaviors.Add(meta);
        }

      }
    }
}
