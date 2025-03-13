using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens {
    public static class DeleteTagScreen {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Deletar tag");
            Console.WriteLine("--------------");
            Console.WriteLine("Id:");
            var id = int.Parse(Console.ReadLine());
            Delete(id);
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Tag deletada com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar a tag, tente novamente.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}