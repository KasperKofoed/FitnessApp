using PCFitnessK.MVVM.Models;
using PCFitnessK.DataStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCFitnessK.MVVM.ViewModels.Hypertrophy
{
    public class HLegsViewModel : ViewModelBase
    {
        private List<int> _repRange;
        private HLegsDataStorage _dataStorage;

        public HLegsViewModel()
        {
            _repRange = new List<int>() { 8, 12, 15 };
            _dataStorage = new HLegsDataStorage();
        }

        public List<int> GetRepRange { get { return _repRange; } set{value = _repRange; } }
        public HLegsDataStorage DataStorage { get {return _dataStorage; } set {value = _dataStorage; } }

        //public string ItemIsSelected
        //{

        //}

    }
}
