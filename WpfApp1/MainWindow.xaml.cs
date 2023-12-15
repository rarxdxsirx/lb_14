using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var list = new ObservableCollection<Client>()
               {
                new Client(){Id=1,FirstName="Син",LastName="Карсарович", PreferredColor=Colors.Beige, ShortInfo="Умею создавать динамит",
                    Tariff = new ObservableCollection<string>()
                {
                    "Граната",
                    "Мина"
                } },
                new Client(){Id=2,FirstName="Василий",LastName="Кисилив", PreferredColor=Colors.Azure, ShortInfo="Умею кататься на скутере", 
                    Tariff = new ObservableCollection<string>()
                {
                    "Линейка",
                    "Бокосины"
                } },
                new Client(){Id=3,FirstName="Константин",LastName="Чукчин", PreferredColor=Colors.BlanchedAlmond, ShortInfo="Сломал 10 деревьев", 
                    Tariff = new ObservableCollection<string>()
                {
                    "Топор",
                    "Бензопила"
                } },
                new Client(){Id=4,FirstName="Сергей",LastName="Кораблев", PreferredColor=Colors.Gainsboro, ShortInfo="Разработчик самолетов",
                    Tariff =  new ObservableCollection<string>()
                {

                    "Вертолет",
                    "Велик"
                } }
            };
            ClientsList.ItemsSource = list;
        }
    }
}
