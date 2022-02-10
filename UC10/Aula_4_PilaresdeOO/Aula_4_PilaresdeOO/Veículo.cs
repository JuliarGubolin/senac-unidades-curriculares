using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_4_PilaresdeOO
{
    public class Veículo
    {
        //Propriedades
        public string tipoCombustível { get; set; }
        public string setas { get; set; }
        public string tipoBancos { get; set; }
        public int potencia { get; set; }
        public bool isCambioAutomatico { get; set; }
        public float aroRodas { get; set; }
        public int qtdLugares { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public float peso { get; set; }
        public int qtdRodas { get; set; }

        //Método Construtor Padrão, sem argumentos
        //Posso criar mais de um método construtor
        public Veículo(){ }

        //Método construtor com parâmetros
        public Veículo(string tipoCombustível, string setas, string tipoBancos, int potencia, bool isCambioAutomatico, float aroRodas, int qtdLugares, string marca, string modelo, float peso)
        {
            this.tipoCombustível = tipoCombustível;
            this.setas = setas;
            this.tipoBancos = tipoBancos;
            this.potencia = potencia;
            this.isCambioAutomatico = isCambioAutomatico;
            this.aroRodas = aroRodas;
            this.qtdLugares = qtdLugares;
            this.marca = marca;
            this.modelo = modelo;
            this.peso = peso;
        }
        //ctor tabtab
        //Métodos/Funções
        public void MoverFrente() { }
        public void MoverParaTras() { }
        public void Estacionar() { }
        public void Frear(string pedalFreio, string manete) 
        { 
            //Implementação do código
        }

    }
}
