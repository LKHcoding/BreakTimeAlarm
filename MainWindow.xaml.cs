using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
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


namespace WpfAlarm
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public static System.Timers.Timer clock;
        public static bool canAlarm = true;
        public MainWindow()
        {
            InitializeComponent();
            SetClock();


        }

        private void SetClock()
        {
            clock = new System.Timers.Timer(250);
            clock.Elapsed += OnTimedEvent;
            clock.AutoReset = true;
            clock.Enabled = true;
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Normal, new Action(delegate
            {
                MediaPlayer media1 = new MediaPlayer();
                string asdf = AppDomain.CurrentDomain.BaseDirectory.Replace("\\", "/");
                media1.Open(new Uri(asdf + "/Resources/1.mp3"));
                MediaPlayer media2 = new MediaPlayer();
                media2.Open(new Uri(asdf + "/Resources/2.mp3"));
                MediaPlayer media3 = new MediaPlayer();
                media3.Open(new Uri(asdf + "/Resources/3.mp3"));

                //UI 시간 업데이트
                this.clocklabel.Content = DateTime.Now.ToString("yyyy-MM-dd \n HH:mm:ss");

                if (DateTime.Now > new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 1, 0) && !(DateTime.Now.DayOfWeek.ToString() == "Sunday" || DateTime.Now.DayOfWeek.ToString() == "Saturday")
                && DateTime.Now < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 0, 0))
                {
                    if ((DateTime.Now.Minute >= 1 && DateTime.Now.Minute <= 49) &&
                    (DateTime.Now < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 18, 0, 0)))
                    {
                        canAlarm = true;
                    }

                    if (DateTime.Now > new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 50, 0) && DateTime.Now < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 0, 0))
                    {
                        if (canAlarm == true)
                        {
                            media1.Play();
                            MessageBox.Show("쌤 쉬는시간 이에요", "Break Time!", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.DefaultDesktopOnly);
                            canAlarm = false;
                        }
                    }
                    if (DateTime.Now > new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 50, 0) && DateTime.Now < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 11, 0, 0))
                    {
                        if (canAlarm == true)
                        {
                            media1.Play();
                            MessageBox.Show("쌤 쉬는시간 이에요", "Break Time!", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.DefaultDesktopOnly);
                            canAlarm = false;
                        }
                    }
                    if (DateTime.Now > new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 11, 50, 0) && DateTime.Now < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 0, 0))
                    {
                        if (canAlarm == true)
                        {
                            media1.Play();
                            MessageBox.Show("쌤 쉬는시간 이에요", "Break Time!", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.DefaultDesktopOnly);
                            canAlarm = false;
                        }
                    }
                    if (DateTime.Now > new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 50, 0) && DateTime.Now < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 0, 0))
                    {
                        if (canAlarm == true)
                        {
                            media2.Play();
                            MessageBox.Show("쌤 점심시간 이에요 밥먹으러가요", "Break Time!", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.DefaultDesktopOnly);
                            canAlarm = false;
                        }
                    }
                    if (DateTime.Now > new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 50, 0) && DateTime.Now < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 0, 0))
                    {
                        if (canAlarm == true)
                        {
                            media1.Play();
                            MessageBox.Show("쌤 쉬는시간 이에요", "Break Time!", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.DefaultDesktopOnly);
                            canAlarm = false;
                        }
                    }
                    if (DateTime.Now > new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 50, 0) && DateTime.Now < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 15, 0, 0))
                    {
                        if (canAlarm == true)
                        {
                            media1.Play();
                            MessageBox.Show("쌤 쉬는시간 이에요", "Break Time!", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.DefaultDesktopOnly);
                            canAlarm = false;
                        }
                    }
                    if (DateTime.Now > new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 15, 50, 0) && DateTime.Now < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 0, 0))
                    {
                        if (canAlarm == true)
                        {
                            media1.Play();
                            MessageBox.Show("쌤 쉬는시간 이에요", "Break Time!", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.DefaultDesktopOnly);
                            canAlarm = false;
                        }
                    }
                    if (DateTime.Now > new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 50, 0) && DateTime.Now < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 0, 0))
                    {
                        if (canAlarm == true)
                        {
                            media1.Play();
                            MessageBox.Show("쌤 쉬는시간 이에요", "Break Time!", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.DefaultDesktopOnly);
                            canAlarm = false;
                        }
                    }
                    if (DateTime.Now > new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 50, 0) && DateTime.Now < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
                        23, 0, 0))
                    {
                        if (canAlarm == true)
                        {
                            media3.Play();
                            MessageBox.Show("쌤 수업끝났어요 ㅎㅎ", "Break Time!", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.DefaultDesktopOnly);
                            canAlarm = false;
                        }
                    }
                }
            }));
        }
    }
}
