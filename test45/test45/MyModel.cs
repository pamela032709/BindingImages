using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace test45
{
    public class MyModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;


        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Name
        {
            get;
            set;
        }
        public string Num
        {
            get;
            set;
        }

        private string imagePath = "plusign.png";
        public string ColorImage
        {
            get { return imagePath; }
            set
            {
                imagePath = value;
                NotifyPropertyChanged("ColorImage");
            }
        }


        public MyModel()
        {
        }
    }
}
