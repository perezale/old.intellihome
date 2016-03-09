using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IntelliHome.WS.Models;

namespace IntelliHome.WS.Services
{
  public class CapabilityRepository
  {
    public Capability[] GetAll()
    {
      return new Capability[]{
          new Capability()
          {
             DeviceId = 1,
             Description = "Living roof fan",
             Type = new DeviceType()
             {
               ValueType = "boolean"
             }
          },
          new Capability()
          {
             DeviceId = 2,
             Description = "Kitchen TV",
             Type = new DeviceType()
             {
               ValueType = "boolean"
             }
          },
          new Capability()
          {
             DeviceId = 3,
             Description = "Thermostat",
             Type = new ScalarDeviceType()
             {
               ValueType = "integer",
               MinValue = 0,
               MaxValue = 40
             }
          }
        };
    }
  }
}