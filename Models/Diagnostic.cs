using System;
using System.Collections.Generic;

namespace Practica.Models;

public partial class Diagnostic
{
    public int DiagnosticId { get; set; }

    public int TechnicId { get; set; }

    public DateOnly DiagnosticDate { get; set; }

    public string? Result { get; set; }

    public string? Technician { get; set; }

    public virtual Technic Technic { get; set; } = null!;
}
