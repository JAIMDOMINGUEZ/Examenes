using ConsoleApp1.models;
namespace ConsoleApp1
 
{
    public class Menu
    {
        Juego juego = new Juego();
        public void MostrarMenu(){
        int select =0;
        while (select==0)
        {
        Console.WriteLine("Menu");
        Console.WriteLine("1.Apostar");
        Console.WriteLine("2.Registros");
       
        Console.WriteLine("______________________________");
        select =int.Parse(Console.ReadLine());
        
            
        }
        switch (select)
        {
                case 1: MostrarMenu1();
                break;
                case 2:MostrarMenu2();
                break;
                case 3:MostrarMenu3();
                break;
                case 4:MostrarMenu4();
                break;
                case 5: MostrarMenu5();

                break;
            
        }
        
    }

    }
}