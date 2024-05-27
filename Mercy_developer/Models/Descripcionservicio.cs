using System;
using System.Collections.Generic;

namespace Mercy_developer.Models;

public partial class Descripcionservicio
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int ClienteId { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;
}
