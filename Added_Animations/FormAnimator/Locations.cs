using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeroit.Framework.Transitions.ZeroitFormAnimator
{

    /// <summary>
    /// Class Locations.
    /// </summary>
    public class Locations
    {
        /// <summary>
        /// The form locations
        /// </summary>
        private FormLocations formLocations = FormLocations.TopLeft;

        /// <summary>
        /// Gets or sets the form locations.
        /// </summary>
        /// <value>The form locations.</value>
        public FormLocations FormLocations { get => formLocations; set => formLocations = value; }
    }
}
