using PCFitnessK.MVVM;
using PCFitnessK.DataStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCFitnessK.MVVM.ViewModels.Power
{
    class PPushViewModel : ViewModelBase
    {

        private List<int> _repRange;
        private PPushDataStorage _dataStorange;

        public PPushViewModel()
        {
            _repRange = new List<int>() { 8, 12, 15 };
            _dataStorange = new PPushDataStorage();
        }

        public List<int> GetRepRange { get { return _repRange; } set { value = _repRange; } }
        public PPushDataStorage DataStorage { get { return _dataStorange; } set { value = _dataStorange; } }


        //private string ItemISSelected
        //{

        //}
    }
}
