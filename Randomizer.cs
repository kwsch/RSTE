using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RSTE
{
    public partial class Randomizer : Form
    {
        public Randomizer()
        {
            InitializeComponent();
        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void B_Save_Click(object sender, EventArgs e)
        {
            Form1.rPKM = CHK_RandomPKM.Checked;
            Form1.rMove = CHK_RandomMoves.Checked;
            Form1.rAbility = CHK_RandomAbilities.Checked;

            Form1.rDiffAI = CHK_MaxDiffAI.Checked;
            Form1.rDiffIV = CHK_MaxDiffPKM.Checked;

            Form1.rClass = CHK_RandomClass.Checked;
            Form1.rGift = CHK_RandomGift.Checked;
            Form1.rGiftPercent = NUD_GiftPercent.Value;
            Form1.rItem = CHK_RandomItems.Checked;

            Form1.rDoRand = true;
            this.Close();
        }

        private void CHK_RandomGift_CheckedChanged(object sender, EventArgs e)
        {
            NUD_GiftPercent.Enabled = CHK_RandomGift.Checked;
        }
    }
}
