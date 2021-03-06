﻿using PCFitnessK.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCFitnessK.DataStorage
{
    public class HLegsDataStorage : ViewModelBase
    {
        #region Fields
        private double _itemSelectedSquatReps;
        private double _itemSelectedSquatSets;
        private double _WeightSquat;

        private double _itemSelectedLegPressReps;
        private double _itemSelectedLegPressSets;
        private double _WeightLegPress;

        private double _itemSelectedLungesReps;
        private double _itemSelectedLungesSets;
        private double _WeightLunge;

        private double _itemSelectedHamstringCurlReps;
        private double _itemSelectedHamstringCurlSets;
        private double _WeightHamstringCurl;

        private double _itemSelectedQuadExtensionsReps;
        private double _itemSelectedQuadExtensionsSets;
        private double _WeightQuadExtension;

        private double _itemSelectedOuterThighPressReps;
        private double _itemSelectedOuterThighPressSets;
        private double _WeightOuterThighPress;

        #endregion

        #region Properties
        public double ItemSelectedSquatReps
        {
            get { return _itemSelectedSquatReps; }
            set { _itemSelectedSquatReps = value; OnPropertyChanged(); }
        }

        public double ItemSelectedSquatSets
        {
            get { return _itemSelectedSquatSets; }
            set { _itemSelectedSquatSets = value; OnPropertyChanged(); }
        }

        public double WeightSquat
        {
            get { return _WeightSquat; }
            set { _WeightSquat = value; OnPropertyChanged(); }
        }

        public double ItemSelectedLegPressReps
        {
            get { return _itemSelectedLegPressReps; }
            set { _itemSelectedLegPressReps = value; OnPropertyChanged(); }
        }

        public double ItemSelectedLegPressSets
        {
            get { return _itemSelectedLegPressSets; }
            set { _itemSelectedLegPressSets = value; OnPropertyChanged(); }
        }

        public double WeightLegPress
        {
            get { return _WeightLegPress; }
            set { _WeightLegPress = value; OnPropertyChanged(); }
        }

        public double ItemSelectedLungesReps
        {
            get { return _itemSelectedLungesReps; }
            set { _itemSelectedLungesReps = value; OnPropertyChanged(); }
        }

        public double ItemSelectedLungesSets
        {
            get { return _itemSelectedLungesSets; }
            set { _itemSelectedLungesSets = value; OnPropertyChanged(); }
        }

        public double WeightLunge
        {
            get { return _WeightLunge; }
            set { _WeightLunge = value; OnPropertyChanged(); }
        }

        public double ItemSelectedHamstringCurlReps
        {
            get { return _itemSelectedHamstringCurlReps; }
            set { _itemSelectedHamstringCurlReps = value; OnPropertyChanged(); }
        }

        public double ItemSelectedHamstringCurlSets
        {
            get { return _itemSelectedHamstringCurlSets; }
            set { _itemSelectedHamstringCurlSets = value; OnPropertyChanged(); }
        }

        public double WeightHamstringCurl
        {
            get { return _WeightHamstringCurl; }
            set { _WeightHamstringCurl = value; OnPropertyChanged(); }
        }

        public double ItemSelectedQuadExtensionsReps
        {
            get { return _itemSelectedQuadExtensionsReps; }
            set { _itemSelectedQuadExtensionsReps = value; OnPropertyChanged(); }
        }

        public double ItemSelectedQuadExtensionsSets
        {
            get { return _itemSelectedQuadExtensionsSets; }
            set { _itemSelectedQuadExtensionsSets = value; OnPropertyChanged(); }
        }

        public double WeightQuadExtension
        {
            get { return _WeightQuadExtension; }
            set { _WeightQuadExtension = value; OnPropertyChanged(); }
        }

        public double ItemSelectedOuterThighPressReps
        {
            get { return _itemSelectedOuterThighPressReps; }
            set { _itemSelectedOuterThighPressReps = value; OnPropertyChanged(); }
        }

        public double ItemSelectedOuterThighPressSets
        {
            get { return _itemSelectedOuterThighPressSets; }
            set { _itemSelectedOuterThighPressSets = value; OnPropertyChanged(); }
        }

        public double WeightOuterThighPress
        {
            get { return _WeightOuterThighPress; }
            set { _WeightOuterThighPress = value; OnPropertyChanged(); }
        }
        #endregion
    }
}
