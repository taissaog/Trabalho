/*cadastrar produtos(código, marca, descrição, valor unitário)*/

namespace POO.Programa{

    public class Produto{
        //private Produto produtos;
        private int Codigo = "";
        private string Marca = "";
        private string Descricao = "";
        private double Preco = "";

        public Produto(){
            ultimoCodigo++;
            this.Codigo = ultimoCodigo;
            this.Marca = Marca;
            this.Descricao = Descricao;
            this.Preco = Preco;
        }

        public Produto(int Condigo, string Marca, string Descricao, double Preco){
  
        }

         public int GetCodigo(){
            this.Codigo = Codigo;
        }

        public void SetCodigo(int Codigo){
            this.Codigo = Codigo;
        }
//---
        public string GetMarca(){
            this.Marca = Marca;
        }

        public void SetMarca(string Marca){
            this.Marca = Marca;
        }
//--
        public string GetDescricao(){
            this.Descricao = Descricao;
        }

        public void SetDescricao(string Descricao){
            this.Descricao = Descricao;
        }  
//--
        public double GetPreco(){
            this.Preco = Preco;
        }

        public void SetMarca(string Preco){
            this.Marca = Marca;
        }

        public static void SolicitandoDados(){
            Console.WriteLine("---Dados do Produto---");
            Console.WriteLine("Digite o código do produto: ");
            Codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a marca do produto: ");
            Marca = string(ReadLine());
            Console.WriteLine("Digite a descrição do produto: ");
            Descricao = string(ReadLine());
            Console.WriteLine("Digite o preço do produto: ");
            Preco = double.Parse(ReadLine());
        }

        

    }
}.