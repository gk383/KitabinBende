using KitabinBende.Core.Entities;
using System;
using System.Collections.Generic;

namespace KitabinBende.Entities.Concrete
{
    public partial class TransactionType: IEntity
    {
        public TransactionType()
        {
            Transaction = new HashSet<Transaction>();
        }

        public int TransactionTypeId { get; set; }
        public string TransactionTypeName { get; set; }
        public int ValidityHours { get; set; }

        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}
