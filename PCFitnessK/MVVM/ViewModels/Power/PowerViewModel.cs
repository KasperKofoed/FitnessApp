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
        private List<int> _repRange;
        private PowerData _dataStorage;

        public PowerViewModel()
        {
            _repRange = new List<int>() { 8, 12, 15 };
            _dataStorage = new PowerData();
        }

        public List<int> GetRepRange { get {return _repRange; } set { value = _repRange; } }
        public PowerData DataStorage { get { return _dataStorage;} set { value = _dataStorage; } }


        //private string ItemIsSelected
        //{

        //}

    }
}
