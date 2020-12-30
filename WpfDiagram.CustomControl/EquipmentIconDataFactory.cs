using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace WpfDiagram.CustomControl
{
    internal static class EquipmentIconDataFactory
    {
        internal static PathGeometry CreateGeometry(string key)
        {
            PathGeometry pathGeometry = new PathGeometry();

            if (key == "Inlet")
            {
                //<Path  Stroke="White" StrokeThickness="1" Fill="Blue">
                //    <Path.Data>
                //        <PathGeometry>
                //            <PathGeometry.Figures>
                //                <PathFigure StartPoint="12,2">
                //                    <PathFigure.Segments>
                //                        <ArcSegment Size="10, 10" RotationAngle="0" IsLargeArc="False" SweepDirection="Counterclockwise" Point="2, 12" />
                //                        <ArcSegment Size="10, 10" RotationAngle="0" IsLargeArc="False" SweepDirection="Counterclockwise" Point="12, 22" />
                //                        <ArcSegment Size="10, 10" RotationAngle="0" IsLargeArc="False" SweepDirection="Counterclockwise" Point="22, 12" />
                //                        <ArcSegment Size="10, 10" RotationAngle="0" IsLargeArc="False" SweepDirection="Counterclockwise" Point="12, 2" />
                //                    </PathFigure.Segments>
                //                </PathFigure>
                //                <PathFigure StartPoint="12,2">
                //                    <PathFigure.Segments>
                //                        <LineSegment Point="12,14" />
                //                    </PathFigure.Segments>
                //                </PathFigure>
                //                <PathFigure StartPoint="8,8" IsFilled="False">
                //                    <PathFigure.Segments>
                //                        <PolyLineSegment Points="12,14 16,8" />
                //                    </PathFigure.Segments>
                //                </PathFigure>
                //            </PathGeometry.Figures>
                //        </PathGeometry>
                //    </Path.Data>
                //</Path>

                PathFigure f1 = new PathFigure();
                f1.StartPoint = new Point(12, 2);
                f1.Segments.Add(new ArcSegment(new Point(2, 12), new Size(10, 10), 0, false, SweepDirection.Counterclockwise, true));
                f1.Segments.Add(new ArcSegment(new Point(12, 22), new Size(10, 10), 0, false, SweepDirection.Counterclockwise, true));
                f1.Segments.Add(new ArcSegment(new Point(22, 12), new Size(10, 10), 0, false, SweepDirection.Counterclockwise, true));
                f1.Segments.Add(new ArcSegment(new Point(12, 2), new Size(10, 10), 0, false, SweepDirection.Counterclockwise, true));
                pathGeometry.Figures.Add(f1);

                PathFigure f2 = new PathFigure();
                f2.StartPoint = new Point(12, 2);
                f2.Segments.Add(new LineSegment(new Point(12, 14), true));
                pathGeometry.Figures.Add(f2);

                PathFigure f3 = new PathFigure();
                f3.StartPoint = new Point(8, 8);
                f3.IsFilled = false;
                f3.Segments.Add(new PolyLineSegment(new Point[] { new Point(12, 14), new Point(16, 8)}, true));
                pathGeometry.Figures.Add(f3);
            }
            else if (key == "Outlet")
            {
                //<Path  Stroke="White" StrokeThickness="1" Fill="Blue">
                //    <Path.Data>
                //        <PathGeometry>
                //            <PathGeometry.Figures>
                //                <PathFigure StartPoint="12,2">
                //                    <PathFigure.Segments>
                //                        <ArcSegment Size="10, 10" RotationAngle="0" IsLargeArc="False" SweepDirection="Counterclockwise" Point="2, 12" />
                //                        <ArcSegment Size="10, 10" RotationAngle="0" IsLargeArc="False" SweepDirection="Counterclockwise" Point="12, 22" />
                //                        <ArcSegment Size="10, 10" RotationAngle="0" IsLargeArc="False" SweepDirection="Counterclockwise" Point="22, 12" />
                //                        <ArcSegment Size="10, 10" RotationAngle="0" IsLargeArc="False" SweepDirection="Counterclockwise" Point="12, 2" />
                //                    </PathFigure.Segments>
                //                </PathFigure>
                //                <PathFigure StartPoint="12,14">
                //                    <PathFigure.Segments>
                //                        <LineSegment Point="12,2" />
                //                    </PathFigure.Segments>
                //                </PathFigure>
                //                <PathFigure StartPoint="8,8" IsFilled="False">
                //                    <PathFigure.Segments>
                //                        <PolyLineSegment Points="12,2 16,8" />
                //                    </PathFigure.Segments>
                //                </PathFigure>
                //            </PathGeometry.Figures>
                //        </PathGeometry>
                //    </Path.Data>
                //</Path>

                PathFigure f1 = new PathFigure();
                f1.StartPoint = new Point(12, 2);
                f1.Segments.Add(new ArcSegment(new Point(2, 12), new Size(10, 10), 0, false, SweepDirection.Counterclockwise, true));
                f1.Segments.Add(new ArcSegment(new Point(12, 22), new Size(10, 10), 0, false, SweepDirection.Counterclockwise, true));
                f1.Segments.Add(new ArcSegment(new Point(22, 12), new Size(10, 10), 0, false, SweepDirection.Counterclockwise, true));
                f1.Segments.Add(new ArcSegment(new Point(12, 2), new Size(10, 10), 0, false, SweepDirection.Counterclockwise, true));
                pathGeometry.Figures.Add(f1);

                PathFigure f2 = new PathFigure();
                f2.StartPoint = new Point(12, 14);
                f2.Segments.Add(new LineSegment(new Point(12, 2), true));
                pathGeometry.Figures.Add(f2);

                PathFigure f3 = new PathFigure();
                f3.StartPoint = new Point(8, 8);
                f3.IsFilled = false;
                f3.Segments.Add(new PolyLineSegment(new Point[] { new Point(12, 2), new Point(16, 8) }, true));
                pathGeometry.Figures.Add(f3);
            }
            else if (key == "Valve")
            {
                //<Path  Stroke="White" StrokeThickness="1" Fill="Blue">
                //    <Path.Data>
                //        <PathGeometry>
                //            <PathGeometry.Figures>
                //                <PathFigure StartPoint="2,6" IsClosed="True">
                //                    <PathFigure.Segments>
                //                        <PolyLineSegment Points="22,22 22,6 2,22" />
                //                    </PathFigure.Segments>
                //                </PathFigure>
                //                <PathFigure StartPoint="12,14" IsClosed="True">
                //                    <PathFigure.Segments>
                //                        <PolyLineSegment Points="12,14 12,5 5,5 5,2 19,2 19,5 12,5 12,14" />
                //                    </PathFigure.Segments>
                //                </PathFigure>
                //            </PathGeometry.Figures>
                //        </PathGeometry>
                //    </Path.Data>
                //</Path>

                PathFigure f1 = new PathFigure();
                f1.StartPoint = new Point(2, 6);
                f1.IsClosed = true;
                f1.Segments.Add(new PolyLineSegment(new Point[] { new Point(22, 22), new Point(22, 6), new Point(2, 22) }, true));
                pathGeometry.Figures.Add(f1);

                PathFigure f2 = new PathFigure();
                f2.StartPoint = new Point(12, 14);
                f2.IsClosed = true;
                f2.Segments.Add(new PolyLineSegment(new Point[] { new Point(12, 14), new Point(12, 5), new Point(5, 5), new Point(5, 2), new Point(19, 2), new Point(19, 5), new Point(12, 5), new Point(12, 14) }, true));
                pathGeometry.Figures.Add(f2);
            }
            else if (key == "Pipe")
            {
                //<Path  Stroke="White" StrokeThickness="1" Fill="Blue">
                //    <Path.Data>
                //        <PathGeometry>
                //            <PathGeometry.Figures>
                //                <PathFigure StartPoint="3,6">
                //                    <PathFigure.Segments>
                //                        <LineSegment Point="21,6" />
                //                        <ArcSegment Size="1, 1" RotationAngle="0" IsLargeArc="False" SweepDirection="Clockwise" Point="22, 7" />
                //                        <LineSegment Point="22,17" />
                //                        <ArcSegment Size="1, 1" RotationAngle="0" IsLargeArc="False" SweepDirection="Clockwise" Point="21, 18" />
                //                        <LineSegment Point="3,18" />
                //                        <ArcSegment Size="1, 1" RotationAngle="0" IsLargeArc="False" SweepDirection="Clockwise" Point="2, 17" />
                //                        <LineSegment Point="2,7" />
                //                        <ArcSegment Size="1, 1" RotationAngle="0" IsLargeArc="False" SweepDirection="Clockwise" Point="3, 6" />
                //                    </PathFigure.Segments>
                //                </PathFigure>
                //            </PathGeometry.Figures>
                //        </PathGeometry>
                //    </Path.Data>
                //</Path>

                PathFigure f1 = new PathFigure();
                f1.StartPoint = new Point(3, 6);
                f1.Segments.Add(new LineSegment(new Point(21, 6), true));
                f1.Segments.Add(new ArcSegment(new Point(22, 7), new Size(1, 1), 0, false, SweepDirection.Clockwise, true));
                f1.Segments.Add(new LineSegment(new Point(22, 17), true));
                f1.Segments.Add(new ArcSegment(new Point(21, 18), new Size(1, 1), 0, false, SweepDirection.Clockwise, true));
                f1.Segments.Add(new LineSegment(new Point(3, 18), true));
                f1.Segments.Add(new ArcSegment(new Point(2, 17), new Size(1, 1), 0, false, SweepDirection.Clockwise, true));
                f1.Segments.Add(new LineSegment(new Point(2, 7), true));
                f1.Segments.Add(new ArcSegment(new Point(3, 6), new Size(1, 1), 0, false, SweepDirection.Clockwise, true));
                pathGeometry.Figures.Add(f1);
            }

            return pathGeometry;
        }
    }
}
