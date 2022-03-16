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
         int ganancia=0;
        if(num==numero){
            _jugador.balance=_jugador.balance+(apuesta*10);
            ganancia=apuesta*10;
        }
        _jugador.cantidadGiros=_jugador.cantidadGiros+1;
         List<int> jugada = new List<int>();
        jugada.Add(numero);
        jugada.Add(apuesta);
        jugada.Add(ganancia);
        _jugador.historial.add(jugada);

    }
    public void apostarRojoNegro(int tipo,int apuesta){
        int numero = ruleta();
        int ganancia=0;
        switch (tipo)
        {   
            case 1://negro
                    if (_negro.Contains(numero))
                    {
                        _jugador.balance=_jugador.balance+(apuesta*5);
                        _jugador.cantidadNegros=_jugador.cantidadNegros+1;
                        ganancia=apuesta*5;
                    }
                    else
                    {
                        _jugador.balance=_jugador.balance-apuesta;
                        ganancia=0;
                    }
                break;
            case 2: //rojo
                if (_rojo.Contains(numero))
                    {
                        _jugador.balance=_jugador.balance+(apuesta*5);
                        _jugador.cantidadRojos=_jugador.cantidadRojos+1;
                        ganancia=apuesta*5;
                    }
                    else
                    {
                        _jugador.balance=_jugador.balance-apuesta;
                        ganancia=0;
                    }
                break;

        }
        _jugador.cantidadGiros=_jugador.cantidadGiros+1;
         List<int> jugada = new List<int>();
        jugada.Add(numero);
        jugada.Add(apuesta);
        jugada.Add(ganancia);
        _jugador.historial.add(jugada);
    }
    public void apostarParImpar(int tipo,int apuesta){
        int ganancia=0;
        int numero=ruleta();
  
        switch (tipo)
        {   
            case 1:
                        //si espar
                        if((numero % 2) == 0)
                         {
                            _jugador.balance=_jugador.balance+(apuesta*2);
                            ganancia=apuesta*2;
                            _jugador.pares=_jugador.pares+1;
                         }
                        else
                         {
                             
                            _jugador.balance=_jugador.balance-apuesta;
                            _jugador.impares=_jugador.impares+1;
                            ganancia=0;
                         }
                         break;
            case 2: //si es impar
                         if((numero % 2) == 0)
                        {
                            _jugador.balance=_jugador.balance-apuesta;
                            _jugador.pares=_jugador.pares+1;
                             ganancia=0;
                        }
                        else
                         {  
                            _jugador.impares=_jugador.impares+1;
                            _jugador.balance=_jugador.balance+(apuesta*2);
                             ganancia=apuesta*2;
                         }
                break;
        }
        _jugador.cantidadGiros=_jugador.cantidadGiros+1;
        List<int> jugada = new List<int>();
        jugada.Add(numero);
        jugada.Add(apuesta);
        jugada.Add(ganancia);
        _jugador.historial.add(jugada);
    }
    public int ruleta(){
        Random myObject = new Random();
        int aleatorio= myObject.Next(0, 36);
        return aleatorio;
    }
    public void gananciaoperdidas(){
        if(_jugador.balance>300){
             Console.WriteLine(_jugador.balance-300);
        }
        if (_jugador.balance<300)
        {
            Console.WriteLine(300-_jugador.balance);
        }
        if (_jugador.balance==300)
        {
             Console.WriteLine(0);
        }
        
    }


    
    }
    
    
}