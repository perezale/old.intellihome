using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IntelliHome.WS.Models;

namespace IntelliHome.WS.Services
{
  public class CapabilityRepository
  {

    private Capability[] capabilities = return new Capability[]{
          new Capability()
          {
             DeviceId = 0,
             Description = "Description",
             Type = new DeviceType()
             {
               ValueType = "switch"
             },
             Value = 0
          },
          new Capability()
          {
             DeviceId = 1,
             Description = "Description",
             Type = new DeviceType()
             {
               ValueType = "switch"
             },
             Value = 1
          },
          new Capability()
          {
             DeviceId = 2,
             Description = "Description",
             Type = new ScalarDeviceType()
             {
               ValueType = "medicion",
               Unit= "°"
             },
             Value = 25
          },
          new Capability()
          {
             DeviceId = 4,
             Description = "Description",
             Type = new DeviceType()
             {
               ValueType = "switch"
             },
             Value = 0
          },
          new Capability()
          {
             DeviceId = 5,
             Description = "Description",
             Type = new DeviceType()
             {
               ValueType = "switch"
             },
             Value = 1
          },
          new Capability()
          {
             DeviceId = 6,
             Description = "Description",
             Type = new DeviceType()
             {
               ValueType = "switch"
             },
             Value = 0
          },
          new Capability()
          {
             DeviceId = 7,
             Description = "Description",
             Type = new DeviceType()
             {
               ValueType = "switch"
             },
             Value = 0
          },
          new Capability()
          {
             DeviceId = 8,
             Description = "Description",
             Type = new DeviceType()
             {
               ValueType = "switch"
             },
             Value = 0
          },
          new Capability()
          {
             DeviceId = 9,
             Description = "Description",
             Type = new ScalarDeviceType()
             {
               ValueType = "medicion",
               Unit= "mm"
             },
             Value = 45
          },
          new Capability()
          {
             DeviceId = 10,
             Description = "Description",
             Type = new DeviceType()
             {
               ValueType = "switch"
             },
             Value = 0
          },
          new Capability()
          {
             DeviceId = 11,
             Description = "Description",
             Type = new DeviceType()
             {
               ValueType = "switch"
             },
             Value = 0
          },
          new Capability()
          {
             DeviceId = 12,
             Description = "Description",
             Type = new DeviceType()
             {
               ValueType = "switch"
             },
             Value = 0
          },
          new Capability()
          {
             DeviceId = 13,
             Description = "Description",
             Type = new DeviceType()
             {
               ValueType = "switch"
             },
             Value = 0
          },
          new Capability()
          {
             DeviceId = 14,
             Description = "Description",
             Type = new DeviceType()
             {
               ValueType = "switch"
             },
             Value = 0
          },
          new Capability()
          {
             DeviceId = 15,
             Description = "Description",
             Type = new DeviceType()
             {
               ValueType = "switch"
             },
             Value = 0
          },
          new Capability()
          {
             DeviceId = 16,
             Description = "Description",
             Type = new DeviceType()
             {
               ValueType = "switch"
             },
             Value = 0
          },
          new Capability()
          {
             DeviceId = 17,
             Description = "Description",
             Type = new DeviceType()
             {
               ValueType = "switch"
             },
             Value = 1
          },
          new Capability()
          {
             DeviceId = 18,
             Description = "Description",
             Type = new DeviceType()
             {
               ValueType = "switch"
             },
             Value = 0
          },
          new Capability()
          {
             DeviceId = 19,
             Description = "Description",
             Type = new DeviceType()
             {
               ValueType = "switch"
             },
             Value = 0
          },
          new Capability()
          {
             DeviceId = 20,
             Description = "Description",
             Type = new DeviceType()
             {
               ValueType = "switch"
             },
             Value = 0
          },
          new Capability()
          {
             DeviceId = 21,
             Description = "Description",
             Type = new DeviceType()
             {
               ValueType = "switch"
             },
             Value = 1
          },
          new Capability()
          {
             DeviceId = 22,
             Description = "Description",
             Type = new DeviceType()
             {
               ValueType = "switch"
             },
             Value = 0
          }
          new Capability()
          {
             DeviceId = 23,
             Description = "Description",
             Type = new ScalarDeviceType()
             {
               ValueType = "medicion",               
               Unit = "kg"
             },
             Value = 0.5
          },
          new Capability()
          {
             DeviceId = 24,
             Description = "Description",
             Type = new ScalarDeviceType()
             {
               ValueType = "medicion",               
               Unit = "hPa"
             },
             Value = 1040
          },
          new Capability()
          {
             DeviceId = 25,
             Description = "Description",
             Type = new ScalarDeviceType()
             {
               ValueType = "medicion",               
               Unit = "watts"
             },
             Value = 1700
          },
        };

    public Capability[] GetUser1()
    {
        
    }
    public Capability[] GetUser2()
    {
      return new Capability[]{
      };
    }
  }
}