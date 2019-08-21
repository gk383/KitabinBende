using System;
using System.Collections.Generic;
using KitabinBende.Core.Entities;

namespace KitabinBende.Entities.Concrete
{
    public partial class Message : IEntity
    {
        public int MessageId { get; set; }
        public int FromId { get; set; }
        public int ToId { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public AspNetUsers From { get; set; }
        public AspNetUsers To { get; set; }
    }
}
