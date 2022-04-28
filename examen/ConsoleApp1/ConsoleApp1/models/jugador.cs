namespace ConsoleApp1.models
{
    public class Jugador
    {
        private int _balance;
        private int _cantidadGiros;
        private int _cantidadRojos;
        private int _cantidadNegros;
        private int _pares;
        private int _impares;
        private List<int> _historial;
        public Jugador()
		{
			this._balance = 300;
			this._historial= new List<int>();
            this._cantidadNegros=0;
            this._cantidadRojos=0;
            this.pares=0;
            this._impares=0;
            this._cantidadGiros=0;

		}
        public int balance { set; get; }
		public int cantidadGiros { set; get; }
		public int cantidadRojos { set; get; }
		public int cantidadNegros { set; get; }

        public int pares { set; get; }
        public int impares { set; get; }
         public List<int> historial { set; get; }
        
    }
}