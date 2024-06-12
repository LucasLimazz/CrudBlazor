namespace CrudBlazor.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string CodInterno { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string TipoProduto { get; set; } = string.Empty;
        public float PesoBruto { get; set; } 
        public float PesoLiq { get; set; } 
        public string Estoque { get; set; } = string.Empty;
        public float EstoqueQtd { get; set; } 
        public string Unidade { get; set; } = string.Empty;
        public string Grupo { get; set; } = string.Empty;
    }
}
