using System;
using System.Collections.Generic;

namespace Practica;

public partial class RepairHistory
{
    public int RepairId { get; set; }

    public int TechnicId { get; set; }

    public DateOnly RepairDate { get; set; }

    public string? Notes { get; set; }

    public virtual ICollection<RepairWorkDetail> RepairWorkDetails { get; set; } = new List<RepairWorkDetail>();

    public virtual Technic Technic { get; set; } = null!;

    public virtual ICollection<UsedPart> UsedParts { get; set; } = new List<UsedPart>();
}
