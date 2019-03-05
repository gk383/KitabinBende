using KitabinBende.Core.Entities;
using System;
using System.Collections.Generic;

namespace KitabinBende.Entities.Concrete
{
    public partial class User: IEntity
    {
        public User()
        {
            BookComment = new HashSet<BookComment>();
            BookStarPoint = new HashSet<BookStarPoint>();
            Library = new HashSet<Library>();
            TransactionHolderUser = new HashSet<Transaction>();
            TransactionReceiverUser = new HashSet<Transaction>();
            UserAddress = new HashSet<UserAddress>();
        }

        public int UserId { get; set; }
        public int UserTypeId { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public byte GenderId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PhotoUrl { get; set; }

        public virtual UserType UserType { get; set; }
        public virtual ICollection<BookComment> BookComment { get; set; }
        public virtual ICollection<BookStarPoint> BookStarPoint { get; set; }
        public virtual ICollection<Library> Library { get; set; }
        public virtual ICollection<Transaction> TransactionHolderUser { get; set; }
        public virtual ICollection<Transaction> TransactionReceiverUser { get; set; }
        public virtual ICollection<UserAddress> UserAddress { get; set; }
    }
}
