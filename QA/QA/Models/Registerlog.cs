using System;
using System.Collections.Generic;

namespace QA.Models;

public partial class Registerlog
{
    public int Userid { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string Clave { get; set; } = null!;
}
