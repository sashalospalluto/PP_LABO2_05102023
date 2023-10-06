using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class SistemaDecimal : Numeracion
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

        public SistemaDecimal(string valor) : base(valor)
        {

        }

        #endregion

        #region METODOS

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
                if (sistema == ESistema.Binario) //verifico que se quiera convertir a binario
                {
                    conversion = (Numeracion)this.DecimalABinario();
                }
                else
                {
                    SistemaBinario sistemaBinario = this.valor;
                    conversion = (Numeracion)sistemaBinario.CambiarSistemaDeNumeracion(sistema);
                }
            }
            else
            {
                conversion = this;
            }
            return conversion;
        }

        private SistemaBinario DecimalABinario()
        {
            SistemaBinario sistema = null;
            double valorReal = 0;
            double.TryParse(base.Valor, out valorReal);
            if (this.EsNumeracionValida(this.Valor) && valorReal > 0)
            {
                string binario = "";
                string valorAbsoluto;
                long aux;
                aux = (long)Math.Floor(valorReal);
                valorAbsoluto = aux.ToString();
                valorAbsoluto = Math.Abs(decimal.Parse(valorAbsoluto)).ToString();
                int.TryParse(valorAbsoluto, out int valor);

                while (valor > 1)
                {
                    if (valor % 2 == 0)
                    {
                        binario = "0" + binario;
                    }
                    else
                    {
                        binario = "1" + binario;
                    }

                    valor = valor / 2;
                }

                binario = '1' + binario;

                sistema = binario.ToString();
            }
            else
            {
                sistema = Numeracion.msgError;
            }

            return sistema;
        }

        protected override bool EsNumeracionValida(string valor)
        {
            return base.EsNumeracionValida(valor) && this.EsSistemaDecimalValido(valor);
        }

        private bool EsSistemaDecimalValido(string valor)
        {
            return double.TryParse(valor, out double esValido);
        }
        #endregion

        #region OPERADORES

        public static implicit operator SistemaDecimal(double valor)
        {
            SistemaDecimal sistema = valor.ToString();
            return sistema;
        }

        public static implicit operator SistemaDecimal(string valor)
        {
            return new SistemaDecimal(valor);
        }

        #endregion
    }
}
