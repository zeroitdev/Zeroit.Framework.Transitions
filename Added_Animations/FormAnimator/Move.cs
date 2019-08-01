using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeroit.Framework.Transitions.ZeroitFormAnimator
{

    /// <summary>
    /// Class Move.
    /// </summary>
    public class Move
    {
        /// <summary>
        /// The random locations
        /// </summary>
        private List<Point> randomLocations = new List<Point>()
        {
            new Point(10, 10),
            new Point(50,50),
            new Point(100, 100),
            new Point(50, 50),
            new Point(10, 10)

        };

        /// <summary>
        /// The start point
        /// </summary>
        private Point startPoint = new Point(0, 0);
        /// <summary>
        /// The end point
        /// </summary>
        private Point endPoint = new Point(100, 100);
        /// <summary>
        /// The direct trajectory
        /// </summary>
        private bool directTrajectory = true;


        /// <summary>
        /// Gets or sets the random locations.
        /// </summary>
        /// <value>The random locations.</value>
        [TypeConverter(typeof(List<Point>))]
        public List<Point> RandomLocations
        {
            get { return randomLocations; }
            set { randomLocations = value; }

        }
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
        /// Gets or sets a value indicating whether [direct trajectory].
        /// </summary>
        /// <value><c>true</c> if [direct trajectory]; otherwise, <c>false</c>.</value>
        public bool DirectTrajectory { get => directTrajectory; set => directTrajectory = value; }
    }


}
