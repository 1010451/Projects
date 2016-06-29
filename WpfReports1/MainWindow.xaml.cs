using DevExpress.Xpf.Printing;
using DevExpress.XtraReports.UI;
using System;
using System.Windows;
using WPFReports.Reports;

namespace WPFReports
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();
            Environment.Exit(1);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            loading.Visibility = Visibility.Visible;
            ReportPrintPreview windowPopup = new ReportPrintPreview();
            loading.Visibility = Visibility.Hidden;
            windowPopup.ShowDialog();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ReportAfleverEtiket report = new ReportAfleverEtiket();
            var window = new DocumentPreviewWindow();
            window.PreviewControl.DocumentSource = report;
            report.CreateDocument();
            window.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ReportAfleverEtiket report = new ReportAfleverEtiket();
            PrintHelper.ShowRibbonPrintPreviewDialog(this, report);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ReportAfleverEtiket report = new ReportAfleverEtiket();
            report.CreateDocument();
            //   report.PrinterName = LocalPrintServer.GetDefaultPrintQueue().Name;

            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                printTool.Print();
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            ReportAfleverEtiket report = new ReportAfleverEtiket();
            report.CreateDocument();
            //   report.PrinterName = LocalPrintServer.GetDefaultPrintQueue().Name;

            using (ReportPrintTool printTool = new ReportPrintTool(report))
            {
                printTool.PrintDialog();
            }
        }
    }
}
