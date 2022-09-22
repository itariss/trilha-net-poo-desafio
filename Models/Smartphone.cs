namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private static List<Smartphone> smartphonesCadastrados = new List<Smartphone>();

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
            smartphonesCadastrados.Add(this);
        }

        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public string Modelo { get; set; }
        public string  Imei { get; set; }
        public string Marca { get; set; }
        public int Memoria { get; set; }

        public void Ligar(string numero)
        {
            
            Console.WriteLine($"Ligando para o número {numero}... | {Modelo} {Marca}");
            Smartphone phone = GetPhone(numero);
            if(phone != null)
            {
            phone.ReceberLigacao(this.Numero);
            }
            else
            {
            System.Console.WriteLine($"O número chamado não existe  | {Modelo} {Marca}");
            }
        }

        public void ReceberLigacao(string numero)
        {
            Console.WriteLine($"Recebendo ligação do número {numero}... | {Modelo} {Marca}");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public static void consultarSmartphonesCadastrados()
        {
            smartphonesCadastrados.ForEach(phone =>
            {
                Console.WriteLine($"Número: {phone.Numero}, Modelo: {phone.Modelo}, Marca: {phone.Marca}");
            });
        }

        public Smartphone GetPhone(string numero)
        {
            return smartphonesCadastrados.FirstOrDefault(phone => phone.Numero.Equals(numero));
        }

        
    }
}