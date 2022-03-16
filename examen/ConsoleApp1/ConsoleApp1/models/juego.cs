namespace ConsoleApp1.models
{
    public class Juego
    {
        private List<int> _negro;
        private List<int> _rojo;
        private Jugador _jugador; 
    public Juego()
		{
			
            this._jugador= new Jugador();
		}
    
    public void apostarnumeroespecífico(int numero,int apuesta){
        int num=ruleta();
        if(num==numero){
            _jugador.balance=_jugador.balance+(apuesta*10);
        }
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