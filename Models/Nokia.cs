namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" - RESOLVIDO
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo" - RESOLVIDO

        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Nokia {Modelo} - numero {Numero} - imei {Imei} - memoria {Memoria}");
        }
    }
}
