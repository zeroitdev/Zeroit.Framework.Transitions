using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeroit.Framework.Transitions.ZeroitFormAnimator
{
    /// <summary>
    /// Class Timer.
    /// </summary>
    public class Timer
    {
        /// <summary>
        /// The time
        /// </summary>
        private int time = 10;

        /// <summary>
        /// The step x
        /// </summary>
        private int stepX = 5;

        /// <summary>
        /// The step y
        /// </summary>
        private int stepY = 5;

        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value>The time.</value>
        public int Time
        {
            get { return time; }
            set
            {
                time = value;
            }
        }

        /// <summary>
        /// Gets or sets the step x.
        /// </summary>
        /// <value>The step x.</value>
        public int StepX
        {
            get { return stepX; }
            set
            {
                stepX = value;
            }
        }

        /// <summary>
        /// Gets or sets the step y.
        /// </summary>
        /// <value>The step y.</value>
        public int StepY
        {
            get { return stepY; }
            set
            {
                stepY = value;
            }
        }
    }
}
