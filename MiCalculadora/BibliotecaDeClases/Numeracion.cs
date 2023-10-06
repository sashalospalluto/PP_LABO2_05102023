namespace BibliotecaDeClases
{
    public enum ESistema
    {
        Binario,
        Decimal
    }
    public abstract class Numeracion
    {
        protected static string msgError;
        protected string valor;

        #region PROPIEDADES
        public string Valor 
        {
            get 
            {
                return this.valor;
            }
        }

        internal abstract double ValorNumerico { get; }

        #endregion

        #region CONSTRUCTORES

        static Numeracion()
        {
            Numeracion.msgError = "Numero Invalido";
        }

        protected Numeracion(string valor)
        {
            this.InicializaValor(valor);
        }

        #endregion

        #region METODOS

        public abstract Numeracion CambiarSistemaDeNumeracion(ESistema sistema);

        protected virtual bool EsNumeracionValida(string valor)
        {
            bool valido = true;

            if(valor == null || valor.Contains(" "))
            {
                valido = false;
            }
            return valido;
        }

        private void InicializaValor(string valor)
        {
            if (this.EsNumeracionValida(valor)) //valido si es un numero
            {
                this.valor = valor; //lo guardo
            }
            else
            {
                this.valor = Numeracion.msgError;
            }
        }

        #endregion

        #region OPERADORES

        public static explicit operator double (Numeracion numeracion)
        {
            double valor = 0;
            double.TryParse(numeracion.valor, out valor);
            return valor;
        }

        public static bool operator == (Numeracion n1, Numeracion n2)
        {
            return n1.EsNumeracionValida(n1.valor) && n2.EsNumeracionValida(n2.valor) && n1.GetType() == n2.GetType();
        }

        public static bool operator != (Numeracion n1, Numeracion n2)
        {
            return !(n1==n2);
        }

        #endregion
    }
}