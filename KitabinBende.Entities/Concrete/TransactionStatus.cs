using System;
using System.Collections.Generic;
using KitabinBende.Core.Entities;

namespace KitabinBende.Entities.Concrete
{
    public partial class TransactionStatus : IEntity
    {
        public TransactionStatus()
        {
            Transaction = new HashSet<Transaction>();
        }

        public int TransactionStatusId { get; set; }
        public string TransactionStatusName { get; set; }

        public ICollection<Transaction> Transaction { get; set; }
    }
}
