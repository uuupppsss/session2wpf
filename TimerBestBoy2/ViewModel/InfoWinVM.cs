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

		private List<EmployeesAbsenceCalendar>  _timeoffs;

		public List<EmployeesAbsenceCalendar> TimeOffs
        {
			get { return _timeoffs; }
			set 
			{
				_timeoffs = value; 
				Signal() ;
			}
		}

        private List<EmployeesAbsenceCalendar> _vacations;

        public List<EmployeesAbsenceCalendar> Vacations
        {
            get { return _vacations; }
            set
            {
                _vacations = value;
                Signal();
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
			List<Education> full_educations = await api.GetEducationsList(SelectedEmployee.Id);

            //отгулы
            TimeOffs= full_calendar.Where(e=>e.DateStart<=DateOnly.FromDateTime(DateTime.Today)&&
			(e.DateEnd==null||e.DateEnd>=DateOnly.FromDateTime(DateTime.Today))&&
			e.ReasonId==2).ToList();

			//отпуска
			Vacations= full_calendar.Where(e => e.DateStart <= DateOnly.FromDateTime(DateTime.Today) &&
            (e.DateEnd == null || e.DateEnd >= DateOnly.FromDateTime(DateTime.Today)) &&
            e.ReasonId == 1).ToList();

            //Обучения
            Educations = full_educations.Where(e => e.DateStart <= DateOnly.FromDateTime(DateTime.Today)).ToList();


        }

        private async void GetPastAbsencesList()
        {
            List<EmployeesAbsenceCalendar> full_calendar = await api.GetAbsenceCalendarList(SelectedEmployee.Id);
            List<Education> full_educations = await api.GetEducationsList(SelectedEmployee.Id);

            //отгулы
            TimeOffs = full_calendar.Where(e => e.ReasonId==2&&
            e.DateStart<=DateOnly.FromDateTime(DateTime.Today)&&
            (e.DateEnd==null||e.DateEnd<=DateOnly.FromDateTime(DateTime.Today))).ToList();

            

        }

        private async void GetFutureAbsencesList()
        {
            List<EmployeesAbsenceCalendar> full_calendar = await api.GetAbsenceCalendarList(SelectedEmployee.Id);
            List<Education> full_educations = await api.GetEducationsList(SelectedEmployee.Id);

        }
    }
}
