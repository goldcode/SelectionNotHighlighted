using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public class Person
    {
        public string Name { get; set; } = string.Empty;
        public override string ToString()
        {
            return Name;
        }
    }

    public class ViewModel
    {
        public ObservableCollection<Person> PersonViewModels { get; set; } = new ();

        public ObservableCollection<Person> SelectedPersonViewModels { get; set; } = new();


        public ViewModel(ObservableCollection<Person> personViewModels, ObservableCollection<Person> selectedPersonViewModels)
        {
            PersonViewModels = personViewModels;
            SelectedPersonViewModels = selectedPersonViewModels;
        }
    }
}
