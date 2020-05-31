using Xamarin.Forms;

namespace MultiBindingPlayground.ViewModels
{
    public class MainViewModel : BindableObject
    {
        string _name;
        string _surname;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Surname
        {
            get { return _surname; }
            set
            {
                _surname = value;
                OnPropertyChanged();
            }
        }
    }
}