using System;
using System.Collections.Generic;

namespace Practica.Models;

public partial class HistoryOrderDetail
{
    public int OrderId { get; set; }

    public int DetailId { get; set; }

    public DateOnly OrderDate { get; set; }

    public int QuantityOrdered { get; set; }

    public decimal TotalPrice { get; set; }

    public string? Supplier { get; set; }

    public virtual Detail Detail { get; set; } = null!;
}
