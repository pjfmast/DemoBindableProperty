using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace DemoBindableProperty.ViewModels
{
    public class FlagViewModel : INotifyPropertyChanged
    {
        private string _country;

        public string Country
        {
            get { return _country; }
            set
            {
                if (_country != value)
                {
                    _country = value;
                    OnPropertyChanged(nameof(Country));
                    OnPropertyChanged(nameof(FlagDescription));
                    OnPropertyChanged(nameof(FlagImage));
                }
            }
        }

        public FlagViewModel()
        {
            Country = Countries.FirstOrDefault();
        }
        public IEnumerable<string> Countries
        {
            get => new List<string> { "Belgium", "Croatia", "France", "Italy", "the Netherlands", "Spain", "Switzerland" };
        }


        public string FlagDescription
        {
            get => $"Flag of {Country}";
        }
        public string FlagImage
        {
            get => $"Flag_of_{Country.Replace(' ', '_')}.png";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
