using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;

namespace PokemonEncTool
{
    public partial class MainPage : Form
    {
        public static ResourceManager resourceManager;

        public MainPage()
        {
            InitializeComponent();
            cbGameVer.DataSource = Enum.GetValues(typeof(GameVer));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }
    }
}
