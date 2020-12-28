using System;
using System.Collections.Generic;
using System.Text;

namespace ModelingObject.Models
{
    public class ConnectorPath
    {
        public int ConnectorPathId { get; set; }
        public List<PointXY> Points { get; set; }
    }
}
