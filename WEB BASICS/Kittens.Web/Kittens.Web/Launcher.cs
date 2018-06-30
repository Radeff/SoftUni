namespace Kittens.Web
{
    using Kittens.Data;
    using Kittens.Models;
    using SimpleMvc.Framework;
    using SimpleMvc.Framework.Routers;
    using System.Collections.Generic;
    using System.Linq;
    using WebServer;

    public class Launcher
    {
        public static void Main()
        {
            var context = new KittensDbContext();

            if (!context.Breeds.Any())
            {
                SeedBreeds(context);
            }

            var server = new WebServer(42420, new ControllerRouter(), new ResourceRouter());
            MvcEngine.Run(server, new KittensDbContext());
        }

        private static void SeedBreeds(KittensDbContext context)
        {
            string[] breedNames = { "Street Transcended", "American Shorthair", "Munchkin", "Siamese" };
            var breeds = new List<Breed>();

            foreach (var name in breedNames)
            {
                var newBreed = new Breed()
                {
                    Name = name
                };

                breeds.Add(newBreed);
            }

            using (context)
            {
                context.AddRange(breeds);
                context.SaveChanges();
            }
        }
    }
}
