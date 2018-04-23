Imports System
Imports System.Drawing
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web
' ...

Namespace WebStrips
    Partial Public Class _Default
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Create a WebChartControl instance.
            Dim WebChartControl1 As New WebChartControl()

            ' Add the chart to the form.
            Me.form1.Controls.Add(WebChartControl1)

            ' Create a line series and add points to it.
            Dim series1 As New Series("My Line Series", ViewType.Line)
            series1.Points.Add(New SeriesPoint("A", New Double() { 10 }))
            series1.Points.Add(New SeriesPoint("B", New Double() { 12 }))
            series1.Points.Add(New SeriesPoint("C", New Double() { 14 }))
            series1.Points.Add(New SeriesPoint("D", New Double() { 17 }))

            ' Add the series to the chart.
            WebChartControl1.Series.Add(series1)

            ' Add two strips to the axis' collection of strips,
            ' with the immediately defined minValue and MaxValue range.
            Dim myAxis As AxisY = CType(WebChartControl1.Diagram, XYDiagram).AxisY
            myAxis.Strips.Add(New Strip("Strip 1", 0, 5))
            myAxis.Strips.Add(New Strip("Strip 2", 5, 10))

            ' Customize the appearance of the strips.
            myAxis.Strips(0).Color = Color.Azure
            myAxis.Strips(0).LegendText = "My First Strip"
            myAxis.Strips(1).Color = Color.Coral
            myAxis.Strips(1).LegendText = "My Second Strip"
        End Sub

    End Class
End Namespace
