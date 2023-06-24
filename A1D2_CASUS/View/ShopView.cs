using A1D2_CASUS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1D2_CASUS.View
{
    public partial class ShopView : Form
    {
        public ShopView()
        {
            InitializeComponent();
            FillPanel();
        }

        public void FillPanel()
        {
            Outfit db = new Outfit();
            List<Outfit> outfits = db.Read();

            for (int i = 0; i < outfits.Count; i++)
            {
                Outfit outfit = outfits[i];

                PictureBox pictureBox = new PictureBox();
                pictureBox.Name = "pictureBox" + i.ToString();
                pictureBox.Size = new Size(200, 200);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Dock = DockStyle.Top;
                pictureBox.Image = Image.FromFile(outfit.ImageURL);


                Button button = new Button();
                button.Name = "button" + i.ToString();
                button.Size = new Size(250, 50);
                button.Text = $"BUY {outfit.Name.ToUpper()} FOR {outfit.Cost} POINTS";
                button.FlatAppearance.BorderSize = 0;
                button.Font = new Font(button.Font, FontStyle.Bold);
                button.FlatStyle = FlatStyle.Flat;
                button.Dock = DockStyle.Bottom;

                Panel containerPanel = new Panel();
                containerPanel.BorderStyle = BorderStyle.FixedSingle;
                containerPanel.Size = new Size(200, 250);
                containerPanel.Controls.Add(pictureBox);
                containerPanel.Controls.Add(button);
                containerPanel.Location = new Point(i * 225, 0);

                ItemShopPanel.Controls.Add(containerPanel);
            }
        }
    }
}
