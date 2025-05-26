using System;
using System.Collections.Generic;
using Practica.Models;

namespace Practica;

public partial class Technic
{
    public int TechnicId { get; set; }

    public string Name { get; set; } = null!;

    public string? Model { get; set; }

    public string? SerialNumber { get; set; }

    public DateOnly? PurchaseDate { get; set; }

    public virtual ICollection<Diagnostic> Diagnostics { get; set; } = new List<Diagnostic>();

    public virtual ICollection<MaintenancePlan> MaintenancePlans { get; set; } = new List<MaintenancePlan>();

    public virtual ICollection<RepairHistory> RepairHistories { get; set; } = new List<RepairHistory>();
}
