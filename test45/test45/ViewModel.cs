using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace test45
{
    public class ViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand command { get; set; }

        public ObservableCollection<MyModel> MyItemsSource { get; set; }
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void AddImg(object obj)
        {
            var model = obj as MyModel;

            model.ColorImage = "minusign.png";

        }


        public ViewModel()
        {
            MyItemsSource = new ObservableCollection<MyModel>() {
    new MyModel()
        {
            Name = "Umair", Num = "0456445450945",
        },
        new MyModel()
        {
            Name = "Cat", Num = "034456445905",
        },
        new MyModel()
        {
            Name = "Nature", Num = "56445905",
        },
};


    



            command = new Command(AddImg);

        }

    


}
    }
