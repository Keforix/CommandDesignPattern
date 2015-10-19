using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace HowAreYouFeeling
{
    class Receiver
    {
        public void ShowMood(string mood)
        {
            switch (mood)
            {
                case "awesome_btn":
                    MessageBox.Show("Awesome");
                    break;
                case "tired_btn":
                    MessageBox.Show("Tired");
                    break;
                case "weird_btn":
                    MessageBox.Show("Weird");
                    break;
                case "hitler_btn":
                    MessageBox.Show("Hitler");
                    break;
            }
        }
    }
}
