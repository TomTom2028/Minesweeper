using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLogic
{
    public class Gameboard
    {
        bool isBomb { get; set; }

        int threatNumber { get; set; }

        Panel attachedPanel;

        public Gameboard(Panel attachedPanel)
        {
            this.isBomb = false;
            this.attachedPanel = attachedPanel;
            threatNumber = 0;
        }

        public void Show()
        {
            if (this.isBomb)
            {

            }
        }
    }
}
