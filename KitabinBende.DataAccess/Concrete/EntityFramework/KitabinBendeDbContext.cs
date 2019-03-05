using System;
using KitabinBende.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KitabinBende.DataAccess.Concrete.EntityFramework
{
    public partial class KitabinBendeDbContext : DbContext
    {
        public KitabinBendeDbContext()
        {
        }

        public KitabinBendeDbContext(DbContextOptions<KitabinBendeDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<AuthorType> AuthorType { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<BookAuthor> BookAuthor { get; set; }
        public virtual DbSet<BookComment> BookComment { get; set; }
        public virtual DbSet<BookImage> BookImage { get; set; }
        public virtual DbSet<BookStarPoint> BookStarPoint { get; set; }
        public virtual DbSet<BookTranslator> BookTranslator { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<Library> Library { get; set; }
        public virtual DbSet<Publisher> Publisher { get; set; }
        public virtual DbSet<Transaction> Transaction { get; set; }
        public virtual DbSet<TransactionStatus> TransactionStatus { get; set; }
        public virtual DbSet<TransactionType> TransactionType { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserAddress> UserAddress { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=KitabinBendeDb;user id=sa;password=123qaz;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity<Author>(entity =>
            {
                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.AuthorName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AuthorTypeId).HasColumnName("AuthorTypeID");

                entity.HasOne(d => d.AuthorType)
                    .WithMany(p => p.Author)
                    .HasForeignKey(d => d.AuthorTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Author_AuthorType");
            });

            modelBuilder.Entity<AuthorType>(entity =>
            {
                entity.Property(e => e.AuthorTypeId).HasColumnName("AuthorTypeID");

                entity.Property(e => e.AuthorTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.BookName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Isbn).HasColumnName("ISBN");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.PointValue).HasDefaultValueSql("((10))");

                entity.Property(e => e.PublisherId).HasColumnName("PublisherID");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Book)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Book_Language");

                entity.HasOne(d => d.Publisher)
                    .WithMany(p => p.Book)
                    .HasForeignKey(d => d.PublisherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Book_Publisher");
            });

            modelBuilder.Entity<BookAuthor>(entity =>
            {
                entity.Property(e => e.BookAuthorId).HasColumnName("BookAuthorID");

                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.BookAuthor)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookAuthor_Author");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookAuthor)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookAuthor_Book");
            });

            modelBuilder.Entity<BookComment>(entity =>
            {
                entity.Property(e => e.BookCommentId).HasColumnName("BookCommentID");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Detail)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Header)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookComment)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookComment_Book");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BookComment)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookComment_User");
            });

            modelBuilder.Entity<BookImage>(entity =>
            {
                entity.Property(e => e.BookImageId).HasColumnName("BookImageID");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookImage)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookImage_Book");
            });

            modelBuilder.Entity<BookStarPoint>(entity =>
            {
                entity.Property(e => e.BookStarPointId).HasColumnName("BookStarPointID");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookStarPoint)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookStarPoint_Book");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BookStarPoint)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookStarPoint_User");
            });

            modelBuilder.Entity<BookTranslator>(entity =>
            {
                entity.Property(e => e.BookTranslatorId).HasColumnName("BookTranslatorID");

                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.BookTranslator)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookTranslator_Author");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookTranslator)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookTranslator_Book");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Library>(entity =>
            {
                entity.Property(e => e.LibraryId).HasColumnName("LibraryID");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Library)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Library_Book");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Library)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Library_User");
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.Property(e => e.PublisherId).HasColumnName("PublisherID");

                entity.Property(e => e.PublisherName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.HolderUserId).HasColumnName("HolderUserID");

                entity.Property(e => e.LibraryId).HasColumnName("LibraryID");

                entity.Property(e => e.ReceiverUserId).HasColumnName("ReceiverUserID");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TransactionStatusId).HasColumnName("TransactionStatusID");

                entity.Property(e => e.TransactionTypeId).HasColumnName("TransactionTypeID");

                entity.HasOne(d => d.HolderUser)
                    .WithMany(p => p.TransactionHolderUser)
                    .HasForeignKey(d => d.HolderUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transaction_User");

                entity.HasOne(d => d.Library)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.LibraryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transaction_Library");

                entity.HasOne(d => d.ReceiverUser)
                    .WithMany(p => p.TransactionReceiverUser)
                    .HasForeignKey(d => d.ReceiverUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transaction_User1");

                entity.HasOne(d => d.TransactionStatus)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.TransactionStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transaction_TransactionStatus");

                entity.HasOne(d => d.TransactionType)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.TransactionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transaction_TransactionType");
            });

            modelBuilder.Entity<TransactionStatus>(entity =>
            {
                entity.Property(e => e.TransactionStatusId).HasColumnName("TransactionStatusID");

                entity.Property(e => e.TransactionStatusName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransactionType>(entity =>
            {
                entity.Property(e => e.TransactionTypeId).HasColumnName("TransactionTypeID");

                entity.Property(e => e.TransactionTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_UserType");
            });

            modelBuilder.Entity<UserAddress>(entity =>
            {
                entity.Property(e => e.UserAddressId).HasColumnName("UserAddressID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AddressName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.UserAddress)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserAddress_City");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserAddress)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserAddress_User");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");

                entity.Property(e => e.UserTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
