using VisualProgramming_LAB8.Models.Grids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgramming_LAB8.Models.Serializers
{
    public class SerializebleGrid : SerializebleElement
    {
        public string TypeGrid { get; set; }
        public string StartPoint { get; set; }
        public GridStrings GridText { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
    }
}
