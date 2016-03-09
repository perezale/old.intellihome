using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace IntelliHome.WS.Models
{
  [KnownType(typeof(ScalarDeviceType))]
  public class Capability
  {
    public long DeviceId { get; set; }
    public string Description { get; set; }
    public DeviceType Type { get; set; }
  }
}