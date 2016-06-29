using System;
using System.Windows;
using WPFReports.Reports;

namespace WPFReports
{
    /// <summary>
    /// Report Preview
    /// </summary>
    public partial class ReportPrintPreview : Window
    {
        public ReportPrintPreview()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                loading.Visibility = Visibility.Visible;
                ReportAfleverEtiket report = new ReportAfleverEtiket();
                docPreviewCtrl.DocumentSource = report;
                report.CreateDocument();

            }
            finally
            {
                loading.Visibility = Visibility.Hidden;
            }
        }

    }
}
