using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.Business.Abstract
{
    interface ITransactionService
    {
        List<Transaction> GetAllInProgress();
        List<Transaction> GetAllExpired();
        List<Transaction> GetAllSuccessful();
        List<Transaction> GetAllUnSuccessful();

        List<Transaction> GetByReceiverUserID(int userID);
        List<Transaction> GetByHolderUserID(int userID);
        List<Transaction> GetByUserID(int userID);

        Transaction GetByID(int transactionID);


        void Add(Transaction transaction);
        void Update(Transaction transaction);
    }
}
