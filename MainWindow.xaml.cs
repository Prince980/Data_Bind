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
            Datacanvas.SizeChanged += Datacanvas_SizeChanged; ;

        }

        public void Datacanvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double canvasWidth = Datacanvas.ActualWidth;
            double canvasHeight = Datacanvas.ActualHeight;
            double scalefactorx = canvasWidth / 1920;
            double scalefactory = canvasHeight / 1080;
            OriginX = (int)(960 * scalefactorx);
            OriginY = (int)(540 * scalefactory);

            
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
       

            private double _gradSaut4;
            private double _gradSaut3;
            private double _gradSaut2;
            private double _gradSaut1;
            private double _gradMaxSaut;

            private double _plotX;
            private double _plotY;
            private double _originX;
            private double _originY;

        private double _gradMaxVoile;
        private double _gradVoile4;
        private double _gradVoile3;
        private double _gradVoile2;
        private double _gradVoile1;

        



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


        private void CreatehandleChart(object sender, RoutedEventArgs e)
        {
            double sampleX;
            double sampleY;

            sampleX = Convert.ToDouble(Plot_x1.Text);
            sampleY = Convert.ToDouble(Plot_y1.Text);

            if (sampleX == 0)
            {
                PlotX = 502;
                GradMaxVoile = 5;
            }

            else if ((sampleX < 5 && sampleX > -5))
            {
                PlotX = 502 + (sampleX * 100.3);
                GradMaxVoile = 5;
            }

            else
            {
                if (sampleX >= 5)
                {
                    PlotX = (502 + (5 * 100.3));

                    GradMaxVoile = sampleX;
                }
                else if (sampleX <= -5)
                {
                    PlotX = 0;
                    GradMaxVoile = -sampleX;
                }

            }

            if (sampleY == 0)
            {
                PlotY = 318;
                GradMaxSaut = 5;

            }

            else if (sampleY <= 5 && sampleY >= -5)
            {
                PlotY = 318 - (sampleY * 63.3); ;
                GradMaxSaut = 5;
            }

            else
            {
                if (sampleY >= 5)
                {
                    PlotY = 0;
                    GradMaxSaut = sampleY;
                }
                else if (sampleY <= -5)
                {
                    PlotY = 318 + (5 * 63.3);
                    GradMaxSaut = -sampleY;
                }

            }

            GradSaut1 = GradMaxSaut / 5;
            GradSaut2 = GradSaut1 * 2;
            GradSaut3 = GradSaut1 * 3;
            GradSaut4 = GradSaut1 * 4;

            GradVoile1 = GradMaxVoile / 5;
            GradVoile2 = GradVoile1 * 2;
            GradVoile3 = GradVoile1 * 3;
            GradVoile4 = GradVoile1 * 4;
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
