namespace poo_challenge.Models
{
    public class Nokia: Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeAPP)
        {
            Console.WriteLine($"Instalando aplicativo {nomeAPP} na OviStore");
        }
    }
}