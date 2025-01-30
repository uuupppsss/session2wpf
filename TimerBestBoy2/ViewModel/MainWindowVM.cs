using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimerBestBoy2.Model;
using TimerBestBoy2.View;

namespace TimerBestBoy2.ViewModel
{
    class MainWindowVM:BaseVM
    {
        public CustomCommand Click {  get; set; }

        public MainWindowVM()
        {
            Click = new CustomCommand(() =>
            {
                var win=new InfoWin();
                win.ShowDialog();
            });
        }


    }
}
