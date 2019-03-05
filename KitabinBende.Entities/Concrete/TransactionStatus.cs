using KitabinBende.Core.Entities;
using System;
using System.Collections.Generic;

namespace KitabinBende.Entities.Concrete
{
    public partial class TransactionStatus: IEntity
    {
        public TransactionStatus()
        {
            Transaction = new HashSet<Transaction>();
        }

        public int TransactionStatusId { get; set; }
        public string TransactionStatusName { get; set; }

        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}
