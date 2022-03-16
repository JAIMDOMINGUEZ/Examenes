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
            this._negro= new List<int>(){2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33 ,35};
            this._rojo=new List<int>(){1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34 , 36};
		}
    
    public void apostarnumeroespecífico(int numero,int apuesta){
        int num=ruleta();
        if(num==numero){
            _jugador.balance=_jugador.balance+(apuesta*10);
        }
    }
    public void apostarRojoNegro(int tipo){
        int numero = ruleta();
        switch (tipo)
        {   
            case 1:
                foreach (var item in _negro)
                {
                    _negro.Contains(numero);
                    if (true)
                    {
                        
                    }
                }
                break;
            case 2: 
                break;
            
          
        }
    }
    public int ruleta(){
        Random myObject = new Random();
        int aleatorio= myObject.Next(0, 36);
        return aleatorio;
    }


    
    }
    
    
}