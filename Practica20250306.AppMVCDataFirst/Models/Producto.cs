﻿using System;
using System.Collections.Generic;

namespace Practica20250306.AppMVCDataFirst.Models;

public partial class Producto
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal Precio { get; set; }

    public int Stock { get; set; }
}
