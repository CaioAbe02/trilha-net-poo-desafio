namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" (CONCLUÍDO!)
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo" (CONCLUÍDO!)
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Aplicativo {nomeApp} instalado no Iphone!");
        }
    }
}