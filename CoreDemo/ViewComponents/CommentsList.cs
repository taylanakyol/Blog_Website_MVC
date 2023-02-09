using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class CommentsList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                    {

                    ID = 1,
                    UserName = "Taylan"


                     },

                new UserComment
                    {

                    ID = 2,
                    UserName = "Serpil"


                     },

                new UserComment
                    {

                    ID = 3,
                    UserName = "Burcu"


                     },


            };

            return View(commentvalues);

        }


    }
}
