using MahApps.Metro.Controls;
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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            var Persons = new ObservableCollection<Person>();
            Persons.Add(new Person { Name = "Peter" });
            Persons.Add(new Person { Name = "Tom" });
            Persons.Add(new Person { Name = "Jane" });


            var selectedPersons = new ObservableCollection<Person>();


            DataContext = new ViewModel(Persons, selectedPersons);
            selectedPersons.Add(Persons.ElementAt(0));
        }
    }
}
