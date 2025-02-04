using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace TimerBestBoy2.Model
{
    public class ApiConnect
    {
        private readonly HttpClient client;
        private static ApiConnect instance;
        public static ApiConnect Instance
        {
            get
            {
                if(instance==null) instance = new ApiConnect();
                return instance;
            }
        }
        public ApiConnect()
        {
            client = new HttpClient()
            {
                BaseAddress=new Uri("http://localhost:5039")
            };
        }

        public async Task<List<Subdivision>> GetSubdivisionsList()
        {
            try
            {
                var response = await client.GetAsync("Subdivision/GetSubdivisionsList");
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Что-то пошло не так", $"Ошибка: {response.StatusCode}");
                    return null;
                }
                else
                {
                    return await response.Content.ReadFromJsonAsync<List<Subdivision>>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Всё сломалось: {ex.Message}");
                return null;
            }
        }

        public async Task<List<Employee>> GetEmployeesList(int subdivision_id)
        {
            try
            {
                var response = await client.GetAsync($"Employees/GetEmployeesList?subdivision_id={subdivision_id}");
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Что-то пошло не так", $"Ошибка: {response.StatusCode}");
                    return null;
                }
                else
                {
                    return await response.Content.ReadFromJsonAsync<List<Employee>>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Всё сломалось: {ex.Message}");
                return null;
            }
        }

        public async Task<List<Event>> GetEventsList(int subdivision_id)
        {
            try
            {
                var response = await client.GetAsync($"Events/GetEmployeesList?subdivision_id={subdivision_id}");
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Что-то пошло не так", $"Ошибка: {response.StatusCode}");
                    return null;
                }
                else
                {
                    return await response.Content.ReadFromJsonAsync<List<Event>>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Всё сломалось: {ex.Message}");
                return null;
            }
        }
    }
}
