using Events2._0.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Events2._0.Pages
{
    /// <summary>
    /// Логика взаимодействия для Client.xaml
    /// </summary>
    public partial class Client : Page
    {
        public Client()
        {
            InitializeComponent();

            var events = EventEntities.GetContext().Events.ToList();

            LViewEvent.ItemsSource = events;
            cmbSorting.ItemsSource = SortingList;
            
        }
        public List<string> SortingList = new List<string>();

        public string[] FilterList { get; set; } =     
        {

        };

        private void UpdateData()
        {
            var events = EventEntities.GetContext().Events.ToList();

            if (datePicker.SelectedDate != null)
            {
                events = events.Where(e => getNormalDate(e.DATE) == ((DateTime)datePicker.SelectedDate).ToString("dd MM yyyy")).ToList();
            }

            LViewEvent.ItemsSource = events;
        }

        private void datePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData();
        }

        private string getNormalDate(string dateString) 
        {

            dateString = dateString.Trim(new char[] {'г', '.'});
            dateString = dateString.Remove(dateString.Length-1);
            DateTime date;
            string format = "d MMMM yyyy";
            if (DateTime.TryParseExact(dateString, format, new CultureInfo("ru-RU"), DateTimeStyles.None, out date)) 
            {
                return date.ToString("dd MM yyyy");
            }


            return "";
        }

    }
}
