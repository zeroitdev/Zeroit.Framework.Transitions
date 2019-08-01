using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeroit.Framework.Transitions.ZeroitFormAnimator
{

    /// <summary>
    /// Class Positions.
    /// </summary>
    public class Positions
    {
        /// <summary>
        /// The start
        /// </summary>
        private int start = 0;
        /// <summary>
        /// The end
        /// </summary>
        private int end = 100;
        /// <summary>
        /// The start point
        /// </summary>
        private Point startPoint = new Point(0, 0);
        /// <summary>
        /// The end point
        /// </summary>
        private Point endPoint = new Point(100, 100);

        /// <summary>
        /// The size
        /// </summary>
        private Size size = new Size(200, 200);
        /// <summary>
        /// The recalculate
        /// </summary>
        private bool recalculate = true;

        /// <summary>
        /// Gets or sets the start.
        /// </summary>
        /// <value>The start.</value>
        public int Start { get => start; set => start = value; }
        /// <summary>
        /// Gets or sets the end.
        /// </summary>
        /// <value>The end.</value>
        public int End { get => end; set => end = value; }
        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>The size.</value>
        public Size Size { get => size; set => size = value; }
        /// <summary>
        /// Gets or sets the start point.
        /// </summary>
        /// <value>The start point.</value>
        public Point StartPoint { get => startPoint; set => startPoint = value; }
        /// <summary>
        /// Gets or sets the end point.
        /// </summary>
        /// <value>The end point.</value>
        public Point EndPoint { get => endPoint; set => endPoint = value; }
        /// <summary>
        /// Gets or sets a value indicating whether [shrink to center].
        /// </summary>
        /// <value><c>true</c> if [shrink to center]; otherwise, <c>false</c>.</value>
        public bool ShrinkToCenter { get => recalculate; set => recalculate = value; }
    }

}
