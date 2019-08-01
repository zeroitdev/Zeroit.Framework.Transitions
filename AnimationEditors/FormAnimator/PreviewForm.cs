using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zeroit.Framework.Transitions.AnimationEditors
{
    public partial class PreviewForm : Form
    {
        public PreviewForm()
        {
            InitializeComponent();
        }

        private bool reset = false;

        public bool Reset
        {
            get { return reset; }
            set
            {
                reset = value;
                Invalidate();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();

            DialogResult = DialogResult.OK;
        }

        private void startReset_Click(object sender, EventArgs e)
        {

        }

        private void PreviewForm_Load(object sender, EventArgs e)
        {
            Size = new Size(524, 251);
        }
    }
}
