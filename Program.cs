using smartphone.models;
using System;
using System.Collections.Generic;
using System.Linq;



namespace smartphone
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criação de instâncias de Smartphone
            Smartphone iphone = new Iphone("123456789");
            Smartphone nokia = new Nokia("987654321");

            // Testando os métodos
            iphone.Ligar();
            nokia.ReceberLigacao();

            // Instalando aplicativos
            iphone.InstalarAplicativo("WhatsApp");
            nokia.InstalarAplicativo("Facebook");

            Console.WriteLine("Aplicativos instalados com sucesso!");
        }
    }
}