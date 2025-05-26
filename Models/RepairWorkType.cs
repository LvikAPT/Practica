using System;
using System.Collections.Generic;

namespace Practica;

public partial class RepairWorkType
{
    public int RepairWorkTypeId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<RepairWorkDetail> RepairWorkDetails { get; set; } = new List<RepairWorkDetail>();
}
