using System;
using System.Collections.Generic;
using Practica.Models;

namespace Practica;

public partial class UsedPart
{
    public int Id { get; set; }

    public int RepairId { get; set; }

    public int DetailId { get; set; }

    public int QuantityUsed { get; set; }

    public virtual Detail Detail { get; set; } = null!;

    public virtual RepairHistory Repair { get; set; } = null!;
}
