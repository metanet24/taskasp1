using Asp_taskfirst.Models;
using Asp_taskfirst.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Asp_taskfirst.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var datas = GetAllUser();

            List<UserVM> users = new List<UserVM>();

            foreach (var user in datas)
            {
                users.Add(new UserVM { FullName=user.FullName, Email=user.Email,Adress=user.Adress,Age=user.Age});
            }

            return View(users);
        }
        private List<User> GetAllUser()
        {
            return new List<User>
        {
            new User { Id = 1,FullName="Metanet Abbasova",Age=23,Email="m@mail.ru",Adress="Sumgait"},
            new User { Id = 2,FullName="Shelale Necefova",Age=15,Email="s@mail.ru",Adress="Sheki"},
            new User { Id = 3,FullName="Cavid Bashirov",Age=30,Email="c@mail.ru",Adress="Ahmedli"},
            new User { Id = 4,FullName="Ilham Abasli",Age=20,Email="i@mai;.ru",Adress="Lokbatan"}
        };
        }


    }


}
