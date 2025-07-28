namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nome) // TODO: Sobrescrever o método "InstalarAplicativo"
        {
            Console.WriteLine($"Instalando aplicativo Nokia: {nome}");
        }
    }
}