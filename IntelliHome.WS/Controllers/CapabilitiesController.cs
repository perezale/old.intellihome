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

      public Capability[] Get()
      {
        return this.capabilityRepository.GetAll();
      }
    }
}
