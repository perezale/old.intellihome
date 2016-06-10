using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IntelliHome.WS.Models;

namespace IntelliHome.WS.Services
{
  public class UserRepository
  {
    private List<User> users;

    private CapabilityRepository capabilityRepository = new CapabilityRepository();

    public UserRepository()
    {
      users = new List<User>()
      {
      new User() { UserId = 1},
      new User() { UserId = 2}
      };
      users.ElementAt(0).capabilities = capabilityRepository.findById(
        new List<long> { 0,1,2,4,5,6,9,10,11,12,13,14,15,16,17,18,19,20,21,22}).ToList();

      users.ElementAt(1).capabilities = capabilityRepository.findById(
        new List<long> { 0,1,4,5,6,7,8,10,11,12,13,14,23,24,25 }).ToList();
    }

    public User GetUser(int id)
    {
      return users.First(u => u.UserId.Equals(id));
    }
   
  }
}