using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IntelliHome.WS.Models;
using IntelliHome.WS.Services;

namespace IntelliHome.WS.Controllers
{
    public class CapabilitiesController : ApiController
    {
      private CapabilityRepository capabilityRepository;

      public CapabilitiesController()
      {
        this.capabilityRepository = new CapabilityRepository();
      }

      [Route("Capabilities/{userId}")]
      public Capability[] Get(int userId)
      {
        if (userId == 1)
          return this.capabilityRepository.GetUser1();
        if (userId == 2)
          return this.capabilityRepository.GetUser2();
        return new Capability[]{};
      }
    }
}
