using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModelingObject.Models
{
    public abstract class Equipment
    {
        public int EquipmentId { get; set; }
        public string Name { get; set; }

        [InverseProperty("DownstreamEquipment")]
        public List<EquipmentConnector> UpstreamEquipmentConnectors { get; set; }
        [InverseProperty("UpstreamEquipment")]
        public List<EquipmentConnector> DownstreamEquipmentConnectors { get; set; }

        public ShapeColor ShapeColor { get; set; }
        public MappingLocation MappingLocation { get; set; }
    }
}
