using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.Business.Abstract
{
    public interface ITransactionTypeService
    {
        List<TransactionType> GetAll();
        TransactionType GetByID(int TransactionTypeID);
    }
}
