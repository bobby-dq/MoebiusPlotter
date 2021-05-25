using System;
using ScottPlot;
using static System.Math;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ScottPlotCookBook();
            MoebiusPlot(10000000);
        }

        static void ScottPlotCookBook()
        {
            var plt = new ScottPlot.Plot(600, 400);

            // sample data
            double[] xs = DataGen.Consecutive(51);
            double[] sin = DataGen.Sin(51);
            double[] cos = DataGen.Cos(51);

            // plot the data
            plt.AddScatter(xs, sin);
            plt.AddScatter(xs, cos);

            // customize the axis labels
            plt.Title("ScottPlot Quickstart");
            plt.XLabel("Horizontal Axis");
            plt.YLabel("Vertical Axis");

            plt.SaveFig("quickstart_scatter2.png");
        }

        static void MoebiusPlot(ulong limit)
        {
            Plot plt = new ScottPlot.Plot(600, 400);

            // generate data
            // double[] xAxis = new double[limit];
            double[] moebiusCoord = new double[limit];
            double[] positiveBound = new double[limit];
            double[] negativeBound = new double[limit];
            double n = 0;
            
            for (ulong i = 0; i < limit; i++)
            {
                positiveBound[i] = Sqrt(i);
                negativeBound[i] = -Sqrt(i);
                n += (Functions.Moebius(i));
                moebiusCoord[i] = n;
            }

            plt.AddSignal(moebiusCoord);
            plt.AddSignal(positiveBound);
            plt.AddSignal(negativeBound);
            plt.SaveFig($"plot_moebius_{limit}.png");


        }
    }
}
