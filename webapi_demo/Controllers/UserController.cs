using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using webapi_demo.Models;

namespace webapi_demo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<UserModel> GetUser()
        {
            List<UserModel> list = new List<UserModel>();
            list.Add(new UserModel
            {
                Id = 1,
                Name = "Test",
                Age = 1,
            });
            list.Add(new UserModel
            {
                Id = 2,
                Name = "Test2",
                Age = 23,
            });

            return list;
        }

        [HttpGet("{id}")]
        public UserModel GetUserId(int id)
        {
            //return "Hello " + id;
            return new UserModel { 
                Id = id,
                Name= "user1",
                Age=20
            };
        }

        [HttpDelete("{id}")]
        public UserModel DeleteUser(int id)
        {
            //return "Hello " + id;
            return new UserModel
            {
                Id = id,
                Name = "Deleted!",
                Age = 20
            };
        }

        [HttpPost("{id}")]
        public UserModel CreateUser(UserModel data)
        {
            //return "Hello " + id;
            //return new UserModel
            //{
            //    Id = id,
            //    Name = "Deleted!",
            //    Age = 20
            //};
            data.Name += " Created";
            return data;
        }

        [HttpPut("{id}")]
        public UserModel UpdateUser(UserModel data)
        {
            //return "Hello " + id;
            //return new UserModel
            //{
            //    Id = id,
            //    Name = "Deleted!",
            //    Age = 20
            //};
            data.Name += " Updated";
            return data;
        }
    }
}