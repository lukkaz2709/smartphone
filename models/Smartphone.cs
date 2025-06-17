using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smartphone.models
{
public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public string Memoria { get; set; }

        // TODO: Implementar as propriedades faltantes de acordo com o diagrama


        public Smartphone(string numero)
        {
            Numero = numero;
            Modelo = "Modelo Padrão"; // Valor padrão, pode ser alterado
            IMEI = "000000000000000"; // Valor padrão, pode ser alterado
            Memoria = "64GB"; // Valor padrão, pode ser alterado

            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}