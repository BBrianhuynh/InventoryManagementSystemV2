using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystemV2
{
    public partial class customerButton : PictureBox
    {
        public customerButton()
        {
            InitializeComponent();
        }

        private Image normalImage;
        private Image hoverImage;

        public Image imageNormal
        {
            get { return normalImage; }
            set { normalImage = value; }
        }

        public Image imageHover
        {
            get { return hoverImage; }
            set { hoverImage = value; }
        }

        private void customerButton_MouseHover(object sender, EventArgs e)
        {
            this.Image = hoverImage;
        }

        private void customerButton_MouseLeave(object sender, EventArgs e)
        {
            this.Image = normalImage;
        }
    }
}
