using System.Runtime.InteropServices;

namespace FociWebApp.Models
{
    public class Meccs
    {
        public int Id { get; set; }
        public int Fordulo { get; set; }
        public int HazaiVeg { get; set; }
        public int VendegVeg { get; set; }
        public int HazaiFelido  { get; set; }
        public int VendegFelido { get; set; }
        public string? Hazaicsapat {  get; set; }
        public string? Vendegcsapat { get; set; }
    }
}
