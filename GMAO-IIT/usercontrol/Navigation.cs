using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAO_IIT.usercontrol
{
    public class Navigation
    {
        List<UserControl> userControls = new List<UserControl>();   
        Panel panel;
        public Navigation(List<UserControl> userControls, Panel panel)
        {
            this.userControls = userControls;
            this.panel = panel;
            adduser();
        }
        private void adduser()
        {
            for (int i=0; i<userControls.Count(); i++)
            {
                userControls[i].Dock= DockStyle.Fill;
                panel.Controls.Add(userControls[i]);
            }
        }
        public void Display(int index)
        {
            if (index <  userControls.Count()) {
                userControls[index].BringToFront();
            }
        }
    }
}
