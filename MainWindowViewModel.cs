using OxyPlot;
using OxyPlot.Axes;

namespace SkiaSharpTest
{
	public class MainWindowViewModel
	{
		public PlotModel PlotViewModel { get; }

		public MainWindowViewModel()
		{
			PlotViewModel = new PlotModel
							{
								Title = "Sample chart"
							};

			PlotViewModel.Axes.Add(new LinearAxis
								   {
									   Position = AxisPosition.Left,
									   Title = "Left axis"
								   });

			PlotViewModel.Axes.Add(new LinearAxis
								   {
									   Position = AxisPosition.Bottom,
									   Title = "Bottom axis"
								   });
		}
	}
}
