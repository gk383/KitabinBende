using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KitabinBende.Business.Abstract
{
    public interface IUserAddressService
    {
        List<UserAddress> GetByUserID(int userID);
        UserAddress GetActiveByUserID(int userID);
        UserAddress GetByID(int userAddressID);

        void SetActive(int userAddressID);
        void Add(UserAddress userAddress);
        void Update(UserAddress userAddress);
        void Delete(UserAddress userAddress);
    }
}
