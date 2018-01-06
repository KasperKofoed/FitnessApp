using PCFitnessK.DataStorage;
using PCFitnessK.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouchpointApp.Command;

namespace PCFitnessK.MVVM.ViewModels
{
    public class OneRepMaxCalcViewModel : ViewModelBase
    {
        private List<double> _repRange;
        private RepMaxCalcDataStorage _dataStorage;
        private RelayCommand _relayCommand;
        private double _calculationResults;
        private double _calculationResults90;
        private double _calculationResults80;
        private double _calculationResults75;
        private double _calculationResults65;


        public OneRepMaxCalcViewModel ()
        {
            _repRange = new List<double>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            _dataStorage = new RepMaxCalcDataStorage();
            _relayCommand = new RelayCommand(CalculateMax);
        }

        public List<double> GetRepRange
        {
            get { return _repRange; }
            set { _repRange = value; }
        }

        public RepMaxCalcDataStorage DataStorage
        {
            get { return _dataStorage; }
            set { _dataStorage = value ; }
        }

        public int SelectedRep
        {
            get { return _dataStorage.CalculateRepRange; }
            set
            {
                _dataStorage.CalculateRepRange = value ;
                OnPropertyChanged();
            }
        }

        public RelayCommand GetCalculationResults
        {
            get { return _relayCommand; }
            set { _relayCommand = value; OnPropertyChanged(); }
        }

        public double GetResults
        {
            get { return _calculationResults; }
            set { _calculationResults = value; OnPropertyChanged(); }
        }

        public void CalculateMax()
        {
            _calculationResults = (DataStorage.CalculateWeightUsed * DataStorage.CalculateRepRange * 0.033) + DataStorage.CalculateWeightUsed;
            OnPropertyChanged(nameof(GetResults));
        }
    }
}

