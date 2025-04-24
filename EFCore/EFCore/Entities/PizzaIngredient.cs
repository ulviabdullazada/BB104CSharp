using System;
using System.Collections.Generic;

namespace EFCore.Entities;

public partial class PizzaIngredient
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public int? IngredientId { get; set; }

    public virtual Ingredient? Ingredient { get; set; }

    public virtual Product? Product { get; set; }
}
