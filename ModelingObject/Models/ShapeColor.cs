using System;
using System.Collections.Generic;
using System.Text;

namespace ModelingObject.Models
{
    public class ShapeColor
    {
        public int ShapeColorId { get; set; }
        public string Fill { get; set; }
        public string Stroke { get; set; }
        public double StrokeThickness { get; set; }
    }
}
