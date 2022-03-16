namespace ConsoleApp1.models
{
    public class juego
    {
        private List<int> _negro;
        private List<int> _rojo;

    
    public void apostarnumeroespecífico(int numero){

    }
    public void apostarRojoNegro(int numero){

    }
    public int ruleta(){
        Random myObject = new Random();
        int aleatorio= myObject.Next(100, 150);
        return aleatorio;
    }


    
    }
    
    
}