namespace poo_challenge.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }
        public List<string> Aplicativos { get; set; } = new List<string>();

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar(){
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao(){
            Console.WriteLine("Recebendo ligação...");
        }

        public void ListarAplicativos(){
            Console.WriteLine("Aplicativos instalados:");
            foreach (var app in Aplicativos)
            {
                Console.WriteLine(app);
            }
        }

        public abstract void InstalarAplicativo(string nomeAPP);

    }
}