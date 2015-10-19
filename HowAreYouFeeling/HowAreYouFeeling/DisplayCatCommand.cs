using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace HowAreYouFeeling
{
    class DisplayCatCommand : Command
    {
        private Receiver cmdReceiver;

        public DisplayCatCommand(Receiver cmdReceiver)
        {
            this.cmdReceiver = cmdReceiver;
        }

        public void Execute(string pressedButton)
        {
            cmdReceiver.ShowMood(pressedButton);
        }
    }
}
