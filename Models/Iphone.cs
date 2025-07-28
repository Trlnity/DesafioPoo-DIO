namespace DesafioPOO.Models
{
    public class Iphone : Smartphone  // TODO: Herdar da classe "Smartphone"
    {
        
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nome)  // TODO: Sobrescrever o método "InstalarAplicativo"
        {
            Console.WriteLine($"Instalando aplicativo Iphone pela AppStore: {nome}");
        }
    }
}