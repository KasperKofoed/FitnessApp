using PCFitnessK.MVVM.Models;
using PCFitnessK.DataStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCFitnessK.MVVM.ViewModels.Power
{
    public class PPullViewModel : ViewModelBase
    {

        private List<int> _repRange;
        private PPullDataStorage _dataStorange;

        public PPullViewModel()
        {
            _repRange = new List<int>() { 1, 5, 8, 12, 15 };
            _dataStorange = new PPullDataStorage();
        }

        public List<int> GetRepRange { get { return _repRange; } set { value = _repRange; } }
        public PPullDataStorage DataStorage { get { return _dataStorange; } set { value = _dataStorange; } }


        //private string ItemISSelected
        //{

        //}
    }
}
