using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimerBestBoy2.Model;

namespace TimerBestBoy2.ViewModel
{
    public class InfoWinVM:BaseVM
    {
		private Employee _selectedEmployee;

		public Employee SelectedEmployee
		{
			get { return _selectedEmployee; }
			set 
			{
				_selectedEmployee = value;
				Signal();
			}
		}

	}
}
