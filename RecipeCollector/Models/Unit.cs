using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace RecipeCollector.Models {
    public enum Unit {
        [Description("l")]
        Liter,
        [Description("Prise")]
        Dash,
        [Description("Stk")]
        Piece,
        [Description("g")]
        Gramm,
        [Description("cl")]
        Centiliter,
        [Description("kg")]
        Kilogramm,
        [Description("ml")]
        Milliliter
    }
}
