using Kittens.Models;
using Kittens.Web.Models.BindingModels;
using Microsoft.EntityFrameworkCore;
using SimpleMvc.Framework.Attributes.Methods;
using SimpleMvc.Framework.Attributes.Security;
using SimpleMvc.Framework.Interfaces;
using System.Linq;
using System.Text;

namespace Kittens.Web.Controllers
{
    public class KittensController : BaseController
    {
        [HttpGet]
        [PreAuthorize]
        public IActionResult Add()
        {
            this.Model.Data["error"] = string.Empty;
            return this.View();
        }

        [HttpPost]
        [PreAuthorize]
        public IActionResult Add(KittenAddingModel model)
        {
            if (!this.IsValidModel(model))
            {
                this.Model.Data["error"] = "Please, fill all the fields!";
                return this.View();
            }

            if (!this.Context.Breeds.Any(b => b.Name == model.Breed))
            {
                this.Model.Data["error"] = "Invalid breed!";
                return this.View();
            }

            var kitten = new Kitten()
            {
                Name = model.Name,
                Age = model.Age,
                Breed = this.Context.Breeds.FirstOrDefault(b => b.Name == model.Breed)
            };

            using (this.Context)
            {
                this.Context.Kittens.Add(kitten);
                this.Context.SaveChanges();
            }

            return RedirectToAction("/kittens/all");
        }


        [HttpGet]
        [PreAuthorize]
        public IActionResult All()
        {
            var contentHtml = new StringBuilder();
            var kittens = this.Context.Kittens.Include(k => k.Breed).ToList();

            if (!kittens.Any())
            {
                this.Model.Data["content"] = @"<div class=""text-center""><p>No kittens found.</p></div>";
                return this.View();
            }

            var kittenImgFile = string.Empty;
            contentHtml.Append(@"<div class=""text-center"">
                                    <div class=""text-center""> 
                                        <h2>All Cats</h2>
                                    </div>
                                    <hr class=""my-2""/> 
                                 </div>
                                  <div class=""row text-center offset-2"">");

            for (int i = 0; i < kittens.Count; i++)
            {               
                switch (kittens[i].BreedId)
                {
                    case 1: kittenImgFile = "street-transcended.jpg";
                        break;
                    case 2:
                        kittenImgFile = "american-shorthair.jpg";
                        break;
                    case 3:
                        kittenImgFile = "munchkin.jpg";
                        break;
                    case 4:
                        kittenImgFile = "siamese.jpg";
                        break;
                }; 
            
                contentHtml.Append
                    (
                    $@"<div class=""col-3"">
                          <img class=""img-thumbnail"" src=""img/{kittenImgFile}"" alt=""Kitten image"">
                          <div>
                               <p>Name: {kittens[i].Name}</p>
                               <p>Age: {kittens[i].Age}</p>
                               <p>Breed: {kittens[i].Breed.Name}</p>
                          </div>
                     </div>"
                    );

                if (i % 3 == 2)
                {
                    contentHtml.Append(@"</div><div class=""row text-center offset-2"">");
                }
            }

            contentHtml.Append(@"</div>");

            this.Model.Data["content"] = contentHtml.ToString();
            return this.View();
        }
    }
}
