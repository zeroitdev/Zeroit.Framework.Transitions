using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeroit.Framework.Transitions.ZeroitFormAnimator
{

    /// <summary>
    /// Class Opacity.
    /// </summary>
    public class Opacity
    {
        /// <summary>
        /// The start
        /// </summary>
        double start = 0.5;

        /// <summary>
        /// The step
        /// </summary>
        double step = 1;

        /// <summary>
        /// Gets or sets the start.
        /// </summary>
        /// <value>The start.</value>
        public double Start
        {
            get { return start; }
            set
            {
                if (value > 100)
                {
                    value = 100;
                }
                start = value;
            }
        }
        /// <summary>
        /// Gets or sets the step.
        /// </summary>
        /// <value>The step.</value>
        public double Step { get => step; set => step = value; }
    }


}
