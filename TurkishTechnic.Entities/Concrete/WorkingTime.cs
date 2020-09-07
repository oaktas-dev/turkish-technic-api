using System;
using System.Collections.Generic;
using System.Text;
using TurkishTechnic.Core.Entities;

namespace TurkishTechnic.Entities
{
    public class WorkingTime : IEntity
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ManagerId { get; set; }
        public DateTime WorkingDate { get; set; }
        public DateTime? WorkingStartTime { get; set; }
        public DateTime? WorkingEndTime { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
