using Microsoft.Data.SqlClient;
using Blog.Screens.TagScreens;
using Blog;

const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User Id=sa;Password=1q2w3e4r@#$;Trust Server Certificate=True;";
Database.Connection = new SqlConnection(CONNECTION_STRING);
Database.Connection.Open();

Load();

Console.ReadKey();
Database.Connection.Close();


void Load() {
    Console.WriteLine("Meu Blog");
    Console.WriteLine("-------------------");
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine();
    Console.WriteLine("1 - Gestão de usuário");
    Console.WriteLine("2 - Gestão de perfil");
    Console.WriteLine("3 - Gestão de categoria");
    Console.WriteLine("4 - Gestão de tag");
    Console.WriteLine("5 - Vincular perfil/usuário");
    Console.WriteLine("6 - Vincular post/tag");
    Console.WriteLine("7 - Relatórios");
    Console.WriteLine();
    Console.WriteLine();

    var option = short.Parse(Console.ReadLine()!);

    switch(option) {
        // case 1:
        //     MenuUserScreen.Load();
        //     break;
        // case 2:
        //     MenuPerfilScreen.Load();
        //     break;
        // case 3:
        //     MenuCategoryScreen.Load();
        //     break;
        case 4:
            MenuTagScreen.Load();
            break;
        // case 5:
        //     MenuUserScreen.Load();
        //     break;
        // case 6:
        //     MenuUserScreen.Load();
        //     break;
        // case 7:
        //     MenuUserScreen.Load();
        //     break;
        default: Load(); break;
    }
}