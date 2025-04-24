using System;
using System.Collections.Generic;

namespace EFCore.Entities;

public partial class Ingredient
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<PizzaIngredient> PizzaIngredients { get; set; } = new List<PizzaIngredient>();
}
