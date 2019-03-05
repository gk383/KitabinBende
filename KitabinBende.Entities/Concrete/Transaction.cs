using KitabinBende.Core.Entities;
using System;
using System.Collections.Generic;

namespace KitabinBende.Entities.Concrete
{
    public partial class Transaction: IEntity
    {
        public int TransactionId { get; set; }
        public int TransactionTypeId { get; set; }
        public int LibraryId { get; set; }
        public int HolderUserId { get; set; }
        public int ReceiverUserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? IsSucces { get; set; }
        public int TransactionStatusId { get; set; }
        public bool IsActive { get; set; }

        public virtual User HolderUser { get; set; }
        public virtual Library Library { get; set; }
        public virtual User ReceiverUser { get; set; }
        public virtual TransactionStatus TransactionStatus { get; set; }
        public virtual TransactionType TransactionType { get; set; }
    }
}
