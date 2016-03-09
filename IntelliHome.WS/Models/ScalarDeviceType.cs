using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntelliHome.WS.Models
{
  public class ScalarDeviceType : DeviceType
  {
    public int MinValue { get; set; }
    public int MaxValue { get; set; }    
  }
}