using PCFitnessK.MVVM.Models;
using PCFitnessK.DataStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCFitnessK.MVVM.ViewModels.Hypertrophy
{
    public class HPullPageViewModel : ViewModelBase
    {
        private List<int> _repRange;
        private HPullDataStorage _dataStorage;

        public HPullPageViewModel()
        {
            _repRange = new List<int>() { 8, 12, 15 };
            _dataStorage = new HPullDataStorage();
        }

        public List<int> GetRepRange { get { return _repRange; } set { value = _repRange; } }
        public HPullDataStorage DataStorage { get { return _dataStorage; } set { value = _dataStorage; } }

        //public string ItemIsSelected
        //{

        //}

    }
}
