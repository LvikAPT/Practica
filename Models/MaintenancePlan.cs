using System;
using System.Collections.Generic;

namespace Practica.Models;

public partial class MaintenancePlan
{
    public int PlanId { get; set; }

    public int TechnicId { get; set; }

    public DateOnly PlannedDate { get; set; }

    public string MaintenanceType { get; set; } = null!;

    public string? Notes { get; set; }

    public bool? Completed { get; set; }

    public virtual Technic Technic { get; set; } = null!;
}
