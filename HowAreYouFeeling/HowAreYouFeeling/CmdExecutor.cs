using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace HowAreYouFeeling
{
    class CmdExecutor
    {
        private Command cmd;

        public CmdExecutor(Command cmd)
        {
            this.cmd = cmd;
        }

        public void ExecuteCatCommand(string mood)
        {
            cmd.Execute(mood);
        }
    }
}
