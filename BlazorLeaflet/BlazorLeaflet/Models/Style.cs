using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorLeaflet.Models
{
    public class Style
    {
        /// <summary>
        /// Line color
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Line width
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// Fill color
        /// </summary>
        public string FillColor { get; set; }

        /// <summary>
        /// Fill opacity
        /// </summary>
        public float FillOpacity { get; set; }
    }
}
