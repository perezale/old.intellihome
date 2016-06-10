using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntelliHome.WS.Models
{
  public class User
  {
    public long UserId { get; set; }
    public List<Capability> capabilities { get; set; }

  }
}