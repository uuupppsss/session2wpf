using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

        public async List<Subdivision> GetSubdivisionsList()
        {
            try
            {
                var response = await client.GetAsync("");
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Что-то пошло не так", $"Ошибка: {response.StatusCode}");
                    return null;
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Всё сломалось: {ex.Message}");
            }
        }
    }
}
