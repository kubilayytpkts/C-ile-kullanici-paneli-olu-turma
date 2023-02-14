using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AnaForm : Form
    {
        public AnaForm(Kullanıcı kullanıcıtipi)
        {
            InitializeComponent();
            textBoxşifre.Text = kullanıcıtipi.şifre;
            textBoxsoyisim.Text = kullanıcıtipi.soyisim;
            textBoxaçıklama.Text = kullanıcıtipi.Açıklama;
            textBoxKullanıcıAdı.Text = kullanıcıtipi.kullanıcıAdı;
            textBoxisim.Text = kullanıcıtipi.İsim;
            textBoxid.Text = kullanıcıtipi.id;



        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
