using System;
using System.Collections.Generic;
using KitabinBende.Core.Entities;

namespace KitabinBende.Entities.Concrete
{
    public partial class AspNetUsers : IEntity
    {
        public AspNetUsers()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaims>();
            AspNetUserLogins = new HashSet<AspNetUserLogins>();
            AspNetUserRoles = new HashSet<AspNetUserRoles>();
            AspNetUserTokens = new HashSet<AspNetUserTokens>();
            BookComment = new HashSet<BookComment>();
            BookStarPoint = new HashSet<BookStarPoint>();
            Library = new HashSet<Library>();
            MessageFrom = new HashSet<Message>();
            MessageTo = new HashSet<Message>();
            TransactionHolderUser = new HashSet<Transaction>();
            TransactionReceiverUser = new HashSet<Transaction>();
            UserAddress = new HashSet<UserAddress>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public byte GenderId { get; set; }
        public string PhotoUrl { get; set; }

        public Gender Gender { get; set; }
        public ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }
        public ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }
        public ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
        public ICollection<AspNetUserTokens> AspNetUserTokens { get; set; }
        public ICollection<BookComment> BookComment { get; set; }
        public ICollection<BookStarPoint> BookStarPoint { get; set; }
        public ICollection<Library> Library { get; set; }
        public ICollection<Message> MessageFrom { get; set; }
        public ICollection<Message> MessageTo { get; set; }
        public ICollection<Transaction> TransactionHolderUser { get; set; }
        public ICollection<Transaction> TransactionReceiverUser { get; set; }
        public ICollection<UserAddress> UserAddress { get; set; }
    }
}
