using TestETL.Commons.Models;

namespace TestETL.Models;

public class Item : BaseIdentity
{
    /// <summary>
    /// Číslo dokumentu
    /// </summary>
    public string DocumentId { get; set; }
    /// <summary>
    /// Název produktu
    /// </summary>
    public string ProductName { get; set; }
    /// <summary>
    /// Katalogový kód produktu
    /// </summary>
    public string CatalogCode { get; set; }
    /// <summary>
    /// Množství
    /// </summary>
    public int Quantity { get; set; }
    /// <summary>
    /// Jednotkovou cenu 
    /// </summary>
    public double UnitPrice { get; set; }
    /// <summary>
    /// Jednotka
    /// </summary>
    public string Unit { get; set; }
    /// <summary>
    /// Sazba DPH
    /// </summary>
    public double VATPercentage { get; set; }
}