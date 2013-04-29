using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.ServiceModel;

namespace SelfHostingWindowsService
{
  public partial class WindowsServiceHost : ServiceBase
  {
    ServiceHost sh = new ServiceHost(typeof(HelloWorldServiceLibrary.HelloWorldService));

    public WindowsServiceHost()
    {
      InitializeComponent();
    }

    protected override void OnStart(string[] args)
    {
      sh.Open();
    }

    protected override void OnStop()
    {
      sh.Close();
    }
  }
}
