using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class GameForm : System.Windows.Forms.Form
    {
        public string CookieName { get; set; }
        int score = 0;
        public GameForm()
        {
            InitializeComponent();
            Set_Lemon_Cookie();
        }



        #region METHODS      


        private void cookieclicker()
        {
            score = score + 1;
            lblScore_Number.Text = score.ToString();
        }

        private void Set_MM_Cookie()
        {
            lblCookie_Name.Text = "M+M Cookie";
            lblCookie_Name.ForeColor = Color.Blue;
            pbMM_Cookie.Visible = true;
            pbLemon_Cookie.Visible = false;
            pbFrosted.Visible = false;
            pbGinger.Visible = false;
            pbSugar.Visible = false;
            pcChoc_Cookie.Visible = false;
        }

        private void Set_Lemon_Cookie()
        {
            lblCookie_Name.Text = "Lemon Cookie";
            lblCookie_Name.ForeColor = Color.Gold;
            pbMM_Cookie.Visible = false;
            pbLemon_Cookie.Visible = true;
            pbFrosted.Visible = false;
            pbGinger.Visible = false;
            pbSugar.Visible = false;
            pcChoc_Cookie.Visible = false;

        }
        private void Set_Frosted_Cookie()
        {
            lblCookie_Name.Text = "Frosted Cookie";
            lblCookie_Name.ForeColor = Color.HotPink;
            pbMM_Cookie.Visible = false;
            pbLemon_Cookie.Visible = false;
            pbFrosted.Visible = true;
            pbGinger.Visible = false;
            pbSugar.Visible = false;
            pcChoc_Cookie.Visible = false;
        }
        public void Set_ginger_Cookie()
        {
            lblCookie_Name.Text = "Gingerbread Man";
            lblCookie_Name.ForeColor = Color.Green;
            pbMM_Cookie.Visible = false;
            pbLemon_Cookie.Visible = false;
            pbFrosted.Visible = false;
            pbGinger.Visible = true;
            pbSugar.Visible = false;
            pcChoc_Cookie.Visible = false;
        }
        public void Set_Sugar_Cookie()
        {
            lblCookie_Name.Text = "Sugar Cookie";
            lblCookie_Name.ForeColor = Color.Lavender;
            pbMM_Cookie.Visible = false;
            pbLemon_Cookie.Visible = false;
            pbFrosted.Visible = false;
            pbGinger.Visible = false;
            pbSugar.Visible = true;
            pcChoc_Cookie.Visible = false;
        }

        public void Set_Choc_Cookie()

        {
            lblCookie_Name.Text = "Chocolate Chip";
            lblCookie_Name.ForeColor = Color.Turquoise;
            pbMM_Cookie.Visible = false;
            pbLemon_Cookie.Visible = false;
            pbFrosted.Visible = false;
            pbGinger.Visible = false;
            pbSugar.Visible = false;
            pcChoc_Cookie.Visible = true;
        }
        #endregion METHODS

        #region EVENTS
        
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            cookieclicker();
        }
        private void Btnlemon_Click(object sender, EventArgs e)
        {
            Set_Lemon_Cookie();
        }

        private void Btnfrost_Click(object sender, EventArgs e)
        {
            Set_Frosted_Cookie();
        }

        private void Btnsugar_Click(object sender, EventArgs e)
        {
            Set_Sugar_Cookie();
        }

        private void Btnmm_Click(object sender, EventArgs e)
        {
            Set_MM_Cookie();
        }

        private void Btnginger_Click(object sender, EventArgs e)
        {
            Set_ginger_Cookie();
        }

        private void BtnDirections_Click(object sender, EventArgs e)
        {
            DirectionForm form = new DirectionForm();
            form.ShowDialog();

        }
        private void BtnChoc_Click(object sender, EventArgs e)
        {
            Set_Choc_Cookie();
        }
        #endregion EVENTS


    }
}
