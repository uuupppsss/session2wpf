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
		private ApiConnect api;

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

		private List<EmployeesAbsenceCalendar>  _absenceslist;

		public List<EmployeesAbsenceCalendar> Absenceslist
        {
			get { return _absenceslist; }
			set 
			{
				_absenceslist = value; 
				Signal() ;
			}
		}

		private List<Education> _educations;

		public List<Education> Educations
        {
			get { return _educations; }
			set {
				_educations = value;
				Signal();
			}
		}


		public CustomCommand Save {  get; set; }

        public InfoWinVM()
        {
            api=ApiConnect.Instance;
        }

		private async void GetEducationsList()
		{
			Educations = await api.GetEducationsList(SelectedEmployee.Id);
		}

		private async void GetCurrentAbsencesList()
		{
			List<EmployeesAbsenceCalendar> full_calendar= await api.GetAbsenceCalendarList(SelectedEmployee.Id);
			
		}

        private async void GetPastAbsencesList()
        {
            List<EmployeesAbsenceCalendar> full_calendar = await api.GetAbsenceCalendarList(SelectedEmployee.Id);
            
        }

        private async void GetFutureAbsencesList()
        {
            List<EmployeesAbsenceCalendar> full_calendar = await api.GetAbsenceCalendarList(SelectedEmployee.Id);
            
        }
    }
}
