using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{ // declarando variaveis
    class Pagamento
    {
        private int codigo;
        private string descricao;
        private double valortotal;
        private int Formadepagamento;
        private DateTime data;
        private DateTime hora;
        private int codcartao;
        private string bandeiracartao;


        // instanciando
        public Pagamento()
        {
            Modificarcodigo = 0;
            Modificardescricao = "";
            Modificarvalortotal = 0;
            ModificarFormadepagamento = 0;
            Modificardata = DateTime.Now;
            modificarhora = DateTime.Now;
            Modificarcodcartao = 0;
            Modificarbandeiracartao = "";
        }//fim do metodo costructor sem parametros 

        public Pagamento(int codigo, string descricao, double valortotal, int Formadepagamento, DateTime data, DateTime hora, int codcartao, string bandeiracartao)
        {
            Modificarcodigo = codigo;
            Modificardescricao = descricao;
            Modificarvalortotal = valortotal;
            ModificarFormadepagamento = Formadepagamento;
            Modificardata = data;
            modificarhora = hora;
            Modificarcodcartao = codcartao;
            Modificarbandeiracartao = bandeiracartao;
        }

        public int Modificarcodigo
        {

            get
            {
                return this.codigo;
            }// fim do get - retornar codigo

            set
            {
                this.codigo = value;
            }//fim do set - modifcar o codigo
        }// fim do modificar codigo

        public string Modificardescricao
        {
            get
            {
                return this.descricao;
            }// fim do get - retornar codigo

            set
            {
                this.descricao = value;
            }//fim do set - modifcar o codigo
        }// fim do modificar codigo


        public double Modificarvalortotal
        {
            get
            {
                return this.valortotal;
            }// fim do get - retornar codigo

            set
            {
                this.valortotal = value;
            }//fim do set - modifcar o codigo
        }// fim do modificar codigo

        public int ModificarFormadepagamento
        {

            get
            {
                return this.Formadepagamento;
            }// fim do get - retornar codigo

            set
            {
                this.Formadepagamento = value;
            }//fim do set - modifcar o codigo
        }// fim do modificar codigo

        public DateTime Modificardata
        {
            get
            {
                return this.Modificardata;
            }// fim do get - retornar codigo

            set
            {
                this.Modificardata = value;
            }//fim do set - modifcar o codigo
        }// fim do modificar codigo

        public DateTime modificarhora
        {
            get
            {
                return this.modificarhora;
            }// fim do get - retornar codigo

            set
            {
                this.modificarhora = value;
            }// fim do modificar codigo

        }
        public int Modificarcodcartao
        {
            get
            {
                return this.Modificarcodcartao;
            }// fim do get - retornar codigo

            set
            {
                this.Modificarcodcartao = value;
            }// fim do set - modificar codigo
        }// fim do modificar codigo

        public string Modificarbandeiracartao
        {
            get
            {
                return this.Modificarbandeiracartao;
            }// fim do get - retornar codigo
            set
            {
                this.Modificarbandeiracartao = value;
            }//fim do set - modificar codigo
        }// fim do modificar codigo

        //consulatar pagamento
        public string consultarPagamento(int codigo)
        {
            string msg = "";

            if (Modificarcodigo == codigo)



                msg = "\nCodigo: " + Modificarcodigo +
     "\nDescricao: " + Modificardescricao +
     "\nValortotal: " + Modificarvalortotal +
     "\nFormapagamento: " + ModificarFormadepagamento +
     "\nData de Validade: " + Modificardata +
     "\nHoradacompra: " + modificarhora +
     "\n codigocartao :" + Modificarcodcartao +
     "\n bandeiradocartao: " + Modificarbandeiracartao;
        }
        

      
      }



    } //fim do metodo construtor
} // fim do projeto
