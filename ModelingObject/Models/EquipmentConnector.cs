using System;
using System.Collections.Generic;
using System.Text;

namespace ModelingObject.Models
{
    public class EquipmentConnector
    {
        public int EquipmentConnectorId { get; set; }

        public int UpstreamEquipmentId { get; set; }
        public Equipment UpstreamEquipment { get; set; }
        public int DownstreamEquipmentId { get; set; }
        public Equipment DownstreamEquipment { get; set; }

        public int UpstreamConnectionPosition { get; set; }
        public int DownstreamConnectionPosition { get; set; }

        public ShapeColor ShapeColor { get; set; }
        public ConnectorPath ConnectorPath { get; set; }
    }
}
