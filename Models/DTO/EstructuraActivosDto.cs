namespace CorePilarh.Models.DTO
{
    public class EstructuraActivosDto
    {
        public int SecRubro { get; set; } = 0;
        public string CodigoRubro { get; set; } = string.Empty;
        public string NombreRubro { get; set; } = string.Empty;
        public int SecItem { get; set; } = 0;
        public string CodigoItem { get; set; } = string.Empty;
        public string NombreItem { get; set; } = string.Empty;
        public int SecSubItem { get; set; } = 0;
        public string CodigoSubItem { get; set; } = string.Empty;
        public string NombreSubItem { get; set; } = string.Empty;

    }
    public class Rubro
    {
        public int SecRubro { get; set; } = 0;
        public string CodigoRubro { get; set; } = string.Empty;
        public string NombreRubro { get; set; } = string.Empty;
        public List<Item> Items { get; set; } = new List<Item>();
    }
    public class Item
    {
        public int SecItem { get; set; } = 0;
        public string CodigoItem { get; set; } = string.Empty;  
        public string NombreItem { get; set; } = string.Empty;
        public List<SubItem> SubItems { get; set; } =  new List<SubItem>();
    }
    public class SubItem
    {
        public int SecSubItem { get; set; } = 0;
        public string CodigoSubItem { get; set; } = string.Empty;
        public string NombreSubItem { get; set; } = string.Empty; 
    }
}
