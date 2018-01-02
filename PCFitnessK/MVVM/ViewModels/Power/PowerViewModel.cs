using PCFitnessK.MVVM.Models;
using PCFitnessK.DataStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace PCFitnessK.MVVM.ViewModels.Power
{
    public class PowerViewModel : ViewModelBase
    {
        private PowerData _dataStorage;

        public PowerViewModel()
        {
            _dataStorage = new PowerData();
        }
      
        public PowerData DataStorage { get { return _dataStorage;} set { value = _dataStorage; } }


        //private string ItemIsSelected
        //{

        //}

    }
}
