using System;
using System.Collections.Generic;

namespace Practica;

public class RepairHistory
{
    public int Id { get; set; }
    public int TechnicId { get; set; }
    public DateTime RepairDate { get; set; }
    public string Description { get; set; }
    public virtual Technic Technic { get; set; }
}
