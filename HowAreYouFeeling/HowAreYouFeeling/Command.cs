using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace HowAreYouFeeling
{
    interface Command
    {
        void Execute(string mood);
    }
}
