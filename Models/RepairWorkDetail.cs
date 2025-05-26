using System;
using System.Collections.Generic;

namespace Practica;

public partial class RepairWorkDetail
{
    public int Id { get; set; }

    public int RepairId { get; set; }

    public int RepairWorkTypeId { get; set; }

    public virtual RepairHistory Repair { get; set; } = null!;

    public virtual RepairWorkType RepairWorkType { get; set; } = null!;
}
