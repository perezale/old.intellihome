using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntelliHome.WS.Models
{
  public class DeviceValue
  {
    public long DeviceId { get; set; }
    public object Value { get; set; }

  }
}