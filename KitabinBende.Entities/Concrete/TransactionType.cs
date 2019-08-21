using System;
using System.Collections.Generic;
using KitabinBende.Core.Entities;

namespace KitabinBende.Entities.Concrete
{
    public partial class TransactionType : IEntity
    {
        public TransactionType()
        {
            Transaction = new HashSet<Transaction>();
        }

        public int TransactionTypeId { get; set; }
        public string TransactionTypeName { get; set; }
        public int ValidityHours { get; set; }

        public ICollection<Transaction> Transaction { get; set; }
    }
}
