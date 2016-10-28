using SuperKahraman.Lib;
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

namespace SuperKahraman.WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Superman superman = new Superman();
        Angel angel = new Angel();
        Cyclops cyclops = new Cyclops();

        private void cmbKahramanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbKahramanlar.SelectedIndex)
            {
                case 0:
                    pbHero.Image = heroResimler.Images[0];
                    gbSuperman.Visible = false;
                    break;
                case 1:
                    pbHero.Image = heroResimler.Images[1];
                    gbSuperman.Visible = false;
                    break;
                case 2:
                    pbHero.Image = heroResimler.Images[2];
                    gbSuperman.Visible = true;
                    break;
                default:
                    pbHero.Image = null;
                    gbSuperman.Visible = false;
                    break;
            }
        }

        private void btnUcur_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cmbKahramanlar.SelectedIndex)
                {
                    case 0:
                        this.Text = angel.Ucur();
                        break;
                    case 1:
                        MessageBox.Show("Cyclops uçamaz");
                        break;
                    case 2:
                        superman.ClarkKentModu = rbClarkKent.Checked;
                        this.Text = superman.Ucur();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIndir_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cmbKahramanlar.SelectedIndex)
                {
                    case 0:
                        this.Text = angel.Indir();
                        break;
                    case 1:
                        MessageBox.Show("Cyclops uçamaz");
                        break;
                    case 2:
                        superman.ClarkKentModu = rbClarkKent.Checked;
                        this.Text = superman.Indir();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLazer_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            try
            {
                switch (cmbKahramanlar.SelectedIndex)
                {
                    case 0:
                        MessageBox.Show("Angel Lazer Çıkartamaz");
                        break;
                    case 1:
                        lazerBar.Value = cyclops.LazerCikart();
                        this.Text = $"Laser Power: {lazerBar.Value}";
                        player.SoundLocation = @"http://static1.grsites.com/archive/sounds/scifi/scifi025.wav";
                        player.Play();
                        break;
                    case 2:
                        superman.ClarkKentModu = rbClarkKent.Checked;
                        lazerBar.Value = superman.LazerCikart();
                        this.Text = $"Laser Power: {lazerBar.Value}";

                        player.SoundLocation = @"http://static1.grsites.com/archive/sounds/scifi/scifi025.wav";
                        player.Play();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
