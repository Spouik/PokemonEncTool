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
using System.Globalization;
using System.Threading;
using System.CodeDom;

namespace PokemonEncTool
{
    public partial class MainPage : Form
    {
        public static ResourceManager resourceManager;

        public MainPage()
        {
            InitializeComponent(); 
            //resourceManager = new ResourceManager("Resources.resx", typeof(MainPage).);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr");
            //cbGameVer.DataSource = Enum.GetValues(typeof(GameVer));
            cbGameVer.Items.Add(resourceManager.GetString("game0"));
            cbGameVer.Items.Add(resourceManager.GetString("game17"));
            cbGameVer.Items.Add(resourceManager.GetString("game18"));
            cbGameVer.Items.Add(resourceManager.GetString("game19"));
            cbGameVer.Items.Add(resourceManager.GetString("game20"));
            cbGameVer.Items.Add(resourceManager.GetString("game21"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void cbGameVer_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            GameVer gameVer = GameVer.None;
            switch (cb.Text)
            {
                case "Diamond":
                    gameVer = GameVer.Diamond;
                    lblTestGameVer.Text = gameVer.ToString();
                    break;
                case "Pearl":
                    gameVer = GameVer.Pearl;
                    lblTestGameVer.Text = gameVer.ToString();
                    break;
                case "Platinum":
                    gameVer = GameVer.Platinum;
                    lblTestGameVer.Text = gameVer.ToString();
                    break;
                case "HeartGold":
                    gameVer = GameVer.Gold2;
                    lblTestGameVer.Text = gameVer.ToString();
                    break;
                case "SoulSilver":
                    gameVer = GameVer.Silver2;
                    lblTestGameVer.Text = gameVer.ToString();
                    break;
            }
        }
    }
}
