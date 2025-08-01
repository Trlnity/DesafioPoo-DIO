
    namespace DesafioPOO.Models
    {
        public abstract class Smartphone
        {
            public string Numero { get; set; }
            // TODO: Implementar as propriedades faltantes de acordo com o diagrama(ok)
            private string Modelo;
            private string IMEI;
            private int Memoria;

            public Smartphone(string numero, string modelo, string imei, int memoria)
            {
                // TODO: Passar os parâmetros do construtor para as propriedades (ok)
                Numero = numero;
                Modelo = modelo;
                IMEI = imei;
                Memoria = memoria;
                
            }

            public void Ligar()
            {
                Console.WriteLine("Ligando...");
            }

            public void ReceberLigacao()
            {
                Console.WriteLine("Recebendo Ligacão ...");
            }

            public abstract void InstalarAplicativo(String nome);

        }
    }