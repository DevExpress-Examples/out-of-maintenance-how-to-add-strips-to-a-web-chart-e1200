using System;
using System.Drawing;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Web;
// ...

namespace WebStrips {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void ASPxButton1_Click(object sender, EventArgs e) {
            // Create a WebChartControl instance.
            WebChartControl WebChartControl1 = new WebChartControl();

            // Add the chart to the form.
            this.form1.Controls.Add(WebChartControl1);

            // Create a line series and add points to it.
            Series series1 = new Series("My Line Series", ViewType.Line);
            series1.Points.Add(new SeriesPoint("A", new double[] { 10 }));
            series1.Points.Add(new SeriesPoint("B", new double[] { 12 }));
            series1.Points.Add(new SeriesPoint("C", new double[] { 14 }));
            series1.Points.Add(new SeriesPoint("D", new double[] { 17 }));

            // Add the series to the chart.
            WebChartControl1.Series.Add(series1);

            // Add two strips to the axis' collection of strips,
            // with the immediately defined minValue and MaxValue range.
            AxisY myAxis = ((XYDiagram)WebChartControl1.Diagram).AxisY;
            myAxis.Strips.Add(new Strip("Strip 1", 0, 5));
            myAxis.Strips.Add(new Strip("Strip 2", 5, 10));

            // Customize the appearance of the strips.
            myAxis.Strips[0].Color = Color.Azure;
            myAxis.Strips[0].LegendText = "My First Strip";
            myAxis.Strips[1].Color = Color.Coral;
            myAxis.Strips[1].LegendText = "My Second Strip";
        }

    }
}
