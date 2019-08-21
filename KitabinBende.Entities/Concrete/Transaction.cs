using System;
using System.Collections.Generic;
using KitabinBende.Core.Entities;

namespace KitabinBende.Entities.Concrete
{
    public partial class Transaction : IEntity
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

        public AspNetUsers HolderUser { get; set; }
        public Library Library { get; set; }
        public AspNetUsers ReceiverUser { get; set; }
        public TransactionStatus TransactionStatus { get; set; }
        public TransactionType TransactionType { get; set; }
    }
}
