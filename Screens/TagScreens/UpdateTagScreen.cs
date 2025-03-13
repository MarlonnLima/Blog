using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class UpdateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizar tag");
            Console.WriteLine("--------------");
            Console.WriteLine("Id:");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome:");
            var name = Console.ReadLine();
            Console.WriteLine("Slug:");
            var slug = Console.ReadLine();
            Update(new Tag()
            {
                Id = id,
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Update(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Update(tag);
                Console.WriteLine("Tag atualizada com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar a tag, tente novamente.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}