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
            canvas.MouseMove += Canvas_MouseMove;
           
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

            private double _plotX=47;
            private double _plotY=97;
            private double _originX = 43;
            private double _originY = 40;

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

        public void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            // Get the position of the mouse cursor.
            Point mousePos = e.GetPosition(canvas);
            double canvasWidth = canvas.ActualWidth;
            double canvasHeight = canvas.ActualHeight;
            double scalefactorx = canvasWidth / 1920;
            double scalefactory = canvasHeight / 1080;
            // Update the text block with the mouse position.
            mousePosTextBlock.Text = string.Format("Mouse Position: X={0}, Y={1}", mousePos.X, mousePos.Y);

            // Define the data
            double[,] data = new double[,]
                {
                     { mousePos.X, mousePos.Y},
                };
            // Create a new Line object
            Line line = new Line();
            Line line2 = new Line();
            


            // Set the start and end points of the line
            line.X1 = (int)(960 * scalefactorx);
           line.Y1 = mousePos.Y;
            line.X2 = mousePos.X;
           line.Y2 = mousePos.Y;

            line2.X1 = mousePos.X;
           line2.Y1 = (int)(541 * scalefactory);
           line2.X2 = mousePos.X;
            line2.Y2 = mousePos.Y;


            

            // Set the stroke and thickness of the line
            line.Stroke = Brushes.Blue;
           line.StrokeThickness = 2;
           line2.Stroke = Brushes.Red;
            line2.StrokeThickness = 2;
            

            // Add the line to a Canvas object
            canvas.Children.Clear();
            canvas.Children.Add(line);
           
           canvas.Children.Add(line2);
            




        }

        private void MainWindow_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
