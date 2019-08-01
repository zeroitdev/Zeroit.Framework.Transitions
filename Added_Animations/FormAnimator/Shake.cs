using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeroit.Framework.Transitions.ZeroitFormAnimator
{

    /// <summary>
    /// Class Shake.
    /// </summary>
    public class Shake
    {
        /// <summary>
        /// The shake distance
        /// </summary>
        private int shakeDistance = 30;
        /// <summary>
        /// The shake speed
        /// </summary>
        private int shakeSpeed = 20;
        /// <summary>
        /// The shake type
        /// </summary>
        private ShakeType shakeType = ShakeType.Horizontal;

        /// <summary>
        /// Gets or sets the shake distance.
        /// </summary>
        /// <value>The shake distance.</value>
        public int ShakeDistance { get => shakeDistance; set => shakeDistance = value; }
        /// <summary>
        /// Gets or sets the shake speed.
        /// </summary>
        /// <value>The shake speed.</value>
        public int ShakeSpeed { get => shakeSpeed; set => shakeSpeed = value; }
        /// <summary>
        /// Gets or sets the type of the shake.
        /// </summary>
        /// <value>The type of the shake.</value>
        public ShakeType ShakeType { get => shakeType; set => shakeType = value; }
    }

}
