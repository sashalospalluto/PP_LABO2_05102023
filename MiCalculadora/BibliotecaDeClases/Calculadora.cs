using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Calculadora
    {
        private string nombreAlumno;
        private List<string> operaciones;
        private Numeracion primerOperando;
        private Numeracion resultado;
        private Numeracion segundoOperando;
        private static ESistema sistema;

        #region CONSTRUCTORES

        static Calculadora()
        {
            sistema = ESistema.Decimal;
        }

        public Calculadora()
        {
            this.operaciones = new List<string>();
            this.operaciones.Add("+");
            this.operaciones.Add("-");
            this.operaciones.Add("*");
            this.operaciones.Add("/");
        }

        public Calculadora(string nombreAlumno) :this()
        {
            this.nombreAlumno = nombreAlumno;
        }

        #endregion

        #region PROPIEDADES
        public string NombreAlumno { get; set; }
        public List<string> Operaciones 
        { 
            get 
            {
                return this.operaciones;
            }
        }
        public Numeracion PrimerOperando 
        { 
            get 
            {
                return this.primerOperando;
            }
            set
            {                 
                this.primerOperando = value;
            }
        }
        public Numeracion Resultado 
        { 
            get 
            {
                return this.resultado;
            } 
        }
        public Numeracion SegundoOperando
        {
            get
            {
                return this.SegundoOperando;
            }
            set
            {
                this.SegundoOperando = value;
            }
        }

        public static ESistema Sistema 
        {
            get 
            {
                return sistema;
            } 
            set 
            {
                if(Enum.IsDefined(typeof(ESistema), value))
                {
                    sistema = value;
                }
            }
        }

        #endregion

        #region METODOS

        public void ActualizarHistorialDeOperaciones(char operador)
        {

        }

        public void Calcular()
        {

        }

        public void Calcular(char operador)
        {
            double total=0;
            switch (operador)
            {
                case '-':
                    total = (double)this.primerOperando - (double)this.SegundoOperando;
                    break;
                case '*':
                    total = (double)this.PrimerOperando * (double)this.SegundoOperando;
                    break;
                case '/':
                    total = (double)this.PrimerOperando / (double)this.SegundoOperando;
                    break;
                default:
                    total = (double)this.PrimerOperando + (double)this.SegundoOperando;
                    break;
            }

            this.resultado=this.MapeaResultado(total);
                       
        }

        public void EliminarHistorialDeOperaciones()
        {
            this.operaciones.Clear();
        }

        private Numeracion MapeaResultado(double valor)
        {
            SistemaDecimal sistemaDecimal = null;
            SistemaBinario sistemaBinario = null;
            if (Sistema == ESistema.Decimal)
            {
                sistemaDecimal = valor;
                return (Numeracion)sistemaDecimal;
            }
            else
            {
                sistemaBinario = valor.ToString();
                return (Numeracion)sistemaBinario;
            }
        }
       

        #endregion

    }
}
