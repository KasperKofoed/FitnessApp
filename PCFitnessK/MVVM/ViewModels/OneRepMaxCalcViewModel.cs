using PCFitnessK.DataStorage;
using PCFitnessK.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCFitnessK.MVVM.ViewModels
{
    public class OneRepMaxCalcViewModel : ViewModelBase
    {
        private List<double> _repRange;
        private RepMaxCalcDataStorage _dataStorage;
        private int _ItemIsSelected;

        public OneRepMaxCalcViewModel ()
        {
            _repRange = new List<double>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            _dataStorage = new RepMaxCalcDataStorage();
        }

        public List<double> GetRepRange { get { return _repRange; } set { _repRange = value; } }
        public RepMaxCalcDataStorage DataStorage { get { return _dataStorage; } set { _dataStorage = value ; } }
        public int SelectedRep
        {
            get { return _ItemIsSelected; }
            set
            {
                _dataStorage.CalculateRepRange = value ;
                _ItemIsSelected = value;
                OnPropertyChanged(nameof(RepMaxCalcDataStorage));
            }
        }
    }
}

