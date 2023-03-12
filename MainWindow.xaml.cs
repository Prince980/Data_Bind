using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Shapes;
using System.Drawing.Printing;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows;

namespace DataBind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow :  INotifyPropertyChanged
    {
        public MainWindow()
        {
           
            InitializeComponent();
            DataContext = this;

            
            _plotX =100;
            _plotY = 100;
            _originX =200;
            _originY = 200;
            

        }
        private int _boundNumber;
        public int BoundNumber
        {
            get { return _boundNumber; }
            set
            {
                _boundNumber = value;
                OnPropertyChanged();
            }
        }
       

            private double _gradSaut4=4;
            private double _gradSaut3=3;
            private double _gradSaut2=2;
            private double _gradSaut1=1;
            private double _gradMaxSaut =5;

            private double _plotX;
            private double _plotY;
            private double _originX;
            private double _originY;

        private double _gradMaxVoile=5;
        private double _gradVoile4=4;
        private double _gradVoile3=3;
        private double _gradVoile2=2;
        private double _gradVoile1=1;

        



        public double GradSaut4
            {
                get { return _gradSaut4; }
                set
                {
                    _gradSaut4 = value;
                OnPropertyChanged();

            }
            }

        public double GradSaut3
        {
            get { return _gradSaut3; }
            set
            {
                _gradSaut3 = value;
                OnPropertyChanged();

              

            }
        }

        public double GradSaut2
            {
                get { return _gradSaut2; }
                set
                {
                    _gradSaut2 = value;
                OnPropertyChanged();
            }
            }

            public double GradSaut1
            {
                get { return _gradSaut1; }
                set { _gradSaut1 = value;
                OnPropertyChanged();
            }
            }

            public double GradMaxSaut
            {
                get { return _gradMaxSaut; }
                set { _gradMaxSaut = value;
                OnPropertyChanged();
            }

            }

            public double PlotX
            {
                get { return _plotX; }
                set { _plotX = value;
                OnPropertyChanged();
            }
            }

            public double PlotY
            {
                get { return _plotY; }
                set { _plotY = value;
                OnPropertyChanged();
            }
            }

            public double OriginX
            {
                get { return _originX; }
                set { _originX = value;
                OnPropertyChanged();
            }
            }

            public double OriginY
            {
                get { return _originY; }
                set
                {
                    _originY = value;
                OnPropertyChanged();
                }
            }
        public double GradMaxVoile
        {
            get { return _gradMaxVoile; }
            set
            {
                _gradMaxVoile = value;
                OnPropertyChanged();
            }
        }

        

        public double GradVoile4
        {
            get { return _gradVoile4; }
            set
            {
                _gradVoile4 = value;
                OnPropertyChanged();
            }
        }

        public double GradVoile3
        {
            get { return _gradVoile3; }
            set
            {
                _gradVoile3 = value;
                OnPropertyChanged();
            }
        }

        public double GradVoile2
        {
            get { return _gradVoile2; }
            set
            {
                _gradVoile2 = value;
                OnPropertyChanged();
            }
        }

        public double GradVoile1
        {
            get { return _gradVoile1; }
            set
            {
                _gradVoile1 = value;
                OnPropertyChanged();
                
            }
           
        }

       


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

       

        private void MainWindow_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
