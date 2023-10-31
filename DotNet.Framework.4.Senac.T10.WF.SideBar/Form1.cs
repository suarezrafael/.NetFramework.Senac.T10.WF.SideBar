using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNet.Framework._4.Senac.T10.WF.SideBar
{
    public partial class Form1 : Form
    {
        #region 1.Contrutores
        public Form1()
        {
            InitializeComponent();
        }

        #endregion 1.Contrutores

        #region 2.Variaveis
        // criei uma variavel booleana que tem o valor true
        bool sidebarExpandida = true;
        bool submenuExpandido = false;

        #endregion 2.Variaveis

        #region Eventos
        private void dashboard_Click(object sender, EventArgs e)
        {
            timerSidebar.Start();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerSubmenu.Start();
        }

        private void timerSidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpandida)
            {
                sidebar.Width -= 10;
                if(sidebar.Width <= 87)
                {
                    sidebarExpandida = false;
                    timerSidebar.Stop();
                    return;
                }    
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width >= 299)
                {
                    sidebarExpandida = true;
                    timerSidebar.Stop();
                    return;
                }     
            }
        }
        #endregion Eventos

        #region Metodos

        string RetornaMensagem()
        {
            return "";
        }
        #endregion Metodos

        private void timerSubmenu_Tick(object sender, EventArgs e)
        {   // se o submenu esta expandido
            if(submenuExpandido)
            {   // diminui a altura em 10 pixel's
                submenu.Height -= 10;
                // se a altura atual ja está no minimo
                if(submenu.Height <= 86)
                {   // paro o timer
                    submenuExpandido = false;
                    timerSubmenu.Stop();
                }
            }
            else
            {   // aumento a altura em 10 pixel's
                submenu.Height += 10;

                if(submenu.Height >= 256)
                {
                    submenuExpandido = true;
                    timerSubmenu.Stop();
                }
            }
        }
    }
}
