using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{

    public class PersonViewModel
    {
        public PersonViewModel(ObservableCollection<PersonViewModel> personViewModels)
        {
            PersonViewModels = personViewModels;
            // also some changes.
        }
        public string Name { get; set; } = string.Empty;

        public override string ToString()
        {
            return Name;
        }

        public ObservableCollection<PersonViewModel> PersonViewModels { get; set; }

        public ObservableCollection<PersonViewModel> SelectedPersonViewModels { get; set; } = new();

    }

    public partial class ViewModel : ObservableObject
    {
        public ObservableCollection<PersonViewModel> PersonViewModels { get;  } = new();

        public ViewModel()
        {
            var tom = new PersonViewModel(PersonViewModels) { Name = "Tom" };
            var dick = new PersonViewModel(PersonViewModels) { Name = "Dick" };
            var harry = new PersonViewModel(PersonViewModels) { Name = "Harry" };

            PersonViewModels.Add(tom);
            PersonViewModels.Add(dick);
            PersonViewModels.Add(harry);
            foreach (var p in PersonViewModels)
            {
                p.SelectedPersonViewModels.Add(PersonViewModels.Last());
            }
        }
    }
}
