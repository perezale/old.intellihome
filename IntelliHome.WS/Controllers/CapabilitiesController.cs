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
      private UserRepository userRepository;

      public CapabilitiesController()
      {
        this.userRepository = new UserRepository();
      }

    [Route("Capabilities/{userId}")]
    public Capability[] Get(int userId)
    {
      var user = this.userRepository.GetUser(userId);
      if (user != null)
      {
        return user.capabilities.ToArray();
      }
      else
      {
        return new Capability[] { };
      }
      }
    }
}
