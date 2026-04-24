using System;
using System.Collections.Generic;

namespace Bolanos_GUI_Winforms_Activity;

public partial class Groceryitemt
{
    public int ProductId { get; set; }

    public int? CategoryId { get; set; }

    public string? ProdName { get; set; }

    public decimal? Price { get; set; }
}
