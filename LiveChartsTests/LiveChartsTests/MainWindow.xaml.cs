using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LiveChartsTests
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SeriesCollection SeriesCollection { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            InitializeSeries();
            DataContext = this;
        }

        private void InitializeSeries()
        {
            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(3),
                        new ObservableValue(5),
                        new ObservableValue(2),
                        new ObservableValue(7),
                        new ObservableValue(7),
                        new ObservableValue(4)
                    },
                    PointGeometrySize = 0,
                    StrokeThickness = 4,
                    Fill = Brushes.Transparent
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(3),
                        new ObservableValue(4),
                        new ObservableValue(6),
                        new ObservableValue(8),
                        new ObservableValue(7),
                        new ObservableValue(5)
                    },
                    PointGeometrySize = 0,
                    StrokeThickness = 4,
                    Fill = Brushes.Transparent
                }
            };
        }
    }
}
