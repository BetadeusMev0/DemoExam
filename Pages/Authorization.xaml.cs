using System;
using System.Collections.Generic;
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
using System.Windows.Threading;
using Events2._0.Entities;
using Events2._0.Model;

namespace Events2._0.Pages
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        public Authorization()
        {
            InitializeComponent();
        }
        private players user;
        private int _countUnsuccessful = 0;


        private void btnEnterGuest_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Client());
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            string login = txtLogin.Text;
            string passw = paswordBox.Password;
            var dbConn = EventEntities.GetContext();
            if (login.Length > 0 && passw.Length > 0)
            {
                user = dbConn.players.Where(x => x.Mail == login && x.Password == passw).FirstOrDefault();
                if (_countUnsuccessful < 1)
                {
                    if (user != null)
                    {
                        clearForm();

                    }
                    else
                    {
                        _countUnsuccessful++;
                        MessageBox.Show("Неверно введены логин или пароль!?", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
                        if (_countUnsuccessful == 1)
                        {
                            txtBlockCaptcha.Visibility = Visibility.Visible;
                            txtCaptcha.Visibility = Visibility.Visible;
                            txtBlockCaptcha.Text = Model.Captcha.GeneratedCaptcha();
                            txtBlockCaptcha.TextDecorations = TextDecorations.Strikethrough;
                        }
                    }
                }
                else
                {
                    if (user != null && user.Mail == txtLogin.Text && user.Password == passw && txtBlockCaptcha.Text == txtCaptcha.Text)
                    {
                        clearForm();
                        /// сюда вставить переход
                    }
                    else
                    {
                        MessageBox.Show("Введите данные заного через 10 секунд!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                        txtBlockCaptcha.Text = string.Empty;
                        txtCaptcha.Clear();
                        txtBlockCaptcha.Visibility = Visibility.Hidden;
                        txtCaptcha.Visibility = Visibility.Hidden;
                        txtLogin.Clear();
                        txtLogin.IsEnabled = false;
                        paswordBox.IsEnabled = false;
                        btnEnter.IsEnabled = false;
                        txtBlockTimer.Visibility = Visibility.Visible;
                        CountDown(10, TimeSpan.FromSeconds(1), cur => txtBlockTimer.Text = cur.ToString() + " сек.");
                    }
                }
            }
            else 
            {
                MessageBox.Show("Не заполнены поля Логин и Пароль!","Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            





        }


        private void ShowClient(Entities.players user) 
        {
            NavigationService.Navigate(new Client(/*user*/));
        }




        private void enableForm()
        {
            txtLogin.IsEnabled = true;
            paswordBox.IsEnabled = true;
            btnEnter.IsEnabled = true;
           txtBlockTimer.Visibility = Visibility.Hidden;
        }
        private void clearForm() 
        {
            paswordBox.Clear();
            txtLogin.Clear();
            txtCaptcha.Clear();
            txtBlockCaptcha.Visibility = Visibility.Hidden;
            txtCaptcha.Visibility = Visibility.Hidden;
            txtBlockTimer.Visibility = Visibility.Hidden;
        }
        void CountDown(int count, TimeSpan interval, Action<int> ts)
        {
            var dt = new DispatcherTimer();
            dt.Interval = interval;
            dt.Tick += (_, a) =>
            {
                if(count--==0)
                {
                    enableForm();
                    dt.Stop();
                }
                else
                {
                    ts(count);
                }
            };
            ts(count);
            dt.Start();
        }
    }
}
