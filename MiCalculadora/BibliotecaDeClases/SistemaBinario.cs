using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class SistemaBinario : Numeracion
    {
        #region PROPIEDADES
        internal override double ValorNumerico
        {
            get
            {
                return (double)this.CambiarSistemaDeNumeracion(ESistema.Decimal);
            }
        }
        #endregion

        #region CONSTRUCTORES

        public SistemaBinario(string valor) : base(valor)
        {

        }

        #endregion

        #region METODOS
        private SistemaDecimal BinarioADecimal()
        {
            string valorAEvaluar = double.MinValue.ToString();

            if(this.valor != Numeracion.msgError && this.EsSistemaBinarioValido(this.Valor)) 
            {
                string aux;
                int numeroSolo;
                double nroDecimal = double.Parse(this.Valor);
                int contador = this.Valor.Length;
                valorAEvaluar = this.Valor;

                if (EsSistemaBinarioValido(valorAEvaluar.ToString()))
                {
                    for (int i = 0; i < contador; i++)
                    {
                        aux = valorAEvaluar.Substring(valorAEvaluar.Length - 1, 1); //tomo solo el ultimo caracter del string
                        int.TryParse(aux, out numeroSolo); //lo convierto a entero 

                        if (numeroSolo == 1) // solo si es 1 lo elevo y lo sumo
                        {
                            nroDecimal = (int)Math.Pow(2, i) + nroDecimal;
                        }

                        valorAEvaluar = valorAEvaluar.Remove(valorAEvaluar.Length - 1); //elimino el ultimo caracter del string
                    }
                }
            }

            return (SistemaDecimal)valorAEvaluar;
        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            Numeracion conversion;
            long aux;
            string valorAbsoluto;
            double valorReal = 0;
            double.TryParse(this.Valor, out valorReal);
            aux = (long)Math.Floor(valorReal);
            valorAbsoluto = aux.ToString();
            valorAbsoluto = Math.Abs(decimal.Parse(valorAbsoluto)).ToString();
            if (valorAbsoluto != "1" && valorAbsoluto != "0")
            {
                if (sistema == ESistema.Decimal) //verifico que se quiera convertir a Decimal
                {
                    conversion = (Numeracion)this.BinarioADecimal();
                }
                else
                {
                    SistemaDecimal sistemaDecimal = this.valor;
                    conversion = (Numeracion)sistemaDecimal.CambiarSistemaDeNumeracion(sistema);
                }
            }
            else
            {
                conversion = this;
            }
            return conversion;
        }

        protected override bool EsNumeracionValida(string valor)
        {
            return base.EsNumeracionValida(valor) && this.EsSistemaBinarioValido(valor);
        }

        private bool EsSistemaBinarioValido(string valor)
        {
            bool esBinario = false;

            foreach (var i in valor)
            {
                if (i == '0' || i == '1')
                {
                    esBinario = true;
                }
                else
                {
                    esBinario = false;
                    break;
                }
            }

            return esBinario;
        }

        #endregion

        #region OPERADORES

        public static implicit operator SistemaBinario (string valor)
        {
            return new SistemaBinario(valor);
        }

        #endregion
    }
}
