using System;
using System.Collections.Generic;

namespace Practica.Models;

public partial class Detail
{
    public int DetailId { get; set; }

    public string Name { get; set; } = null!;

    public string ArticleNumber { get; set; } = null!;

    public int QuantityInStock { get; set; }

    public decimal UnitPrice { get; set; }

    public virtual ICollection<HistoryOrderDetail> HistoryOrderDetails { get; set; } = new List<HistoryOrderDetail>();

    public virtual ICollection<UsedPart> UsedParts { get; set; } = new List<UsedPart>();
}
