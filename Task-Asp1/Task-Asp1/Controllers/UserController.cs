using Microsoft.AspNetCore.Mvc;
using Task_Asp1.Models;

namespace Task_Asp1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult User()
        {
            List<User> datas = GetAllUsers();
            return View(datas);
        }

        private List<User> GetAllUsers()
        {
            return new List<User>
            {
                new User { Id = 1,FullName="Abbasova Metanet",Adress="Sumgait",Email="m@mail.ru",Age=22},
                new User { Id = 2,FullName="Ehmedov Haci",Adress="Bileceri",Email="h@mail.ru",Age=29},
                new User { Id = 3,FullName="Abdullayev Emil",Adress="Dernegul",Email="e@mail.ru",Age=21}
            };
        }
    }
}
