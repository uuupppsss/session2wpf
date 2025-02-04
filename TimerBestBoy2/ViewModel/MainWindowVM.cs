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
        private List<Employee> _employees;

        public List<Employee> Employees
        {
            get { return _employees; }
            set { _employees = value; }
        }

        private Subdivision _selectedSubdivision;

        public Subdivision SelectedSubdivision
        {
            get { return _selectedSubdivision; }
            set { _selectedSubdivision = value; }
        }

        private List<Subdivision> _subdivisions;

        public List<Subdivision> Subdivisions
        {
            get { return _subdivisions; }
            set { _subdivisions = value; }
        }



        public CustomCommand<Subdivision> SubdivisionClick { get; set; } 
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
