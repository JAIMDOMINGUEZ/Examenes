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
            this._jugador.balance = 300;
            this._negro= new List<int>(){2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33 ,35};
            this._rojo=new List<int>(){1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34 , 36};
		}
        public int jugador { set; get; }
        
        
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
        //_jugador.historial.Add(jugada);

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
        //_jugador.historial.Add(jugada);
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
        //_jugador.historial.Add(jugada);
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
                case 1: MostrarMenuapostar();
                break;
                case 2:MostrarMenuregistros();
                break;
            
        }

    }
    public bool esmultiplo(int numero){
        
        if (numero % 5 == 0) {
        return false;
        } else {
        return true;
    }
    }
    public void MostrarMenuapostar(){
        Console.WriteLine("|Apostar|");
        Console.WriteLine("1.Apostar a un numero especifico");
        Console.WriteLine("2.Apostar a un color");
        Console.WriteLine("3.Apostar par o impar");
        int tipo =int.Parse(Console.ReadLine());
        Console.WriteLine(_jugador.balance);
        Console.WriteLine("Ingresa la cantidad a apostar(solo se permiten numeros multiplos de 5");
        int cantidad =int.Parse(Console.ReadLine());

        if(_jugador.balance>cantidad){
            if (esmultiplo(cantidad))
            {
                switch (tipo)
                {
                    case 1:
                         mostramenuapuestanumero(cantidad);

                    break;
                    case 2:
                         MostrarMenuapostarcolor(cantidad);

                    break;
                    case 3:
                         MostrarMenuapostarparimpar(cantidad);

                    break;
                    
                }
            }
        }
        else
        {
          Console.WriteLine(" no tienes dinero suficiente, tu saldo es de"+_jugador.balance);   
        }

        Console.WriteLine("______________________________"); 
        
       
        MostrarMenu();
    }
    public void mostramenuapuestanumero(int cantidad){
        int validacion=37;
        int numero=0;
        while (validacion<0 || validacion>36)
        {
            Console.WriteLine("|Apuesta a un numero|");
            Console.WriteLine("Ingresa el numero, recuerda que debe estar en unrango de 0-36");
            numero =int.Parse(Console.ReadLine());
            validacion=numero;
            
        }
        apostarnumeroespecífico(numero,cantidad);
        
        MostrarMenu();
    }

    public void MostrarMenuapostarcolor(int cantidad){
        int validacion=0;
        int tipo=0;
        while (validacion!=1 || validacion!=2)
        {
            Console.WriteLine("|Apuesta a un color|");
            Console.WriteLine("Seleccione un color 1:negro 2.rojo");
            tipo =int.Parse(Console.ReadLine());
            validacion=tipo;
            
        }
        apostarRojoNegro(tipo,cantidad);
        Console.WriteLine("______________________________"); 
        MostrarMenu();

        
    }
     public void MostrarMenuapostarparimpar(int cantidad){
        int validacion=0;
        int tipo=0;
        while (validacion!=1 || validacion!=2)
        {
            Console.WriteLine("|Apuesta par o impar|");
            Console.WriteLine("Seleccione un color 1:par 2.impar");
            tipo =int.Parse(Console.ReadLine());
            validacion=tipo;
            
        }
        apostarParImpar(tipo,cantidad);
        Console.WriteLine("______________________________"); 
        MostrarMenu();



     }
    public void MostrarMenuregistros(){
     Console.WriteLine("giros"); 
     Console.WriteLine(_jugador.cantidadGiros);
     Console.WriteLine("numeros negros"); 
     Console.WriteLine(_jugador.cantidadNegros);
     Console.WriteLine("numeros rojos");
    Console.WriteLine(_jugador.cantidadRojos);
     Console.WriteLine("pares"); 
     Console.WriteLine(_jugador.pares);    
     Console.WriteLine("impares");
     Console.WriteLine(_jugador.impares); 
      Console.WriteLine("ganancias");
     gananciaoperdidas();
      Console.WriteLine("______________________________"); 
        MostrarMenu();
    }
    }
    
    
}