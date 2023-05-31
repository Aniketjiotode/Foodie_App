using BusinessLayer.Interface;
using CommanLayer;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Service
{
    public class AddressBL:IAddressBL
    {
        private readonly IAddressRL iaddressRL;

        public AddressBL(IAddressRL iaddressRL)
        {
            this.iaddressRL = iaddressRL;
        }
        public bool InsertAddress(AddressModel address)
        {
            try
            {
                return iaddressRL.Insertaddress(address);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<AddressModel> GetAlladdress()
        {
            try
            {
                return iaddressRL.GetAlladdress();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateAddress(AddressModel address)
        {
            try
            {
                return iaddressRL.UpdateAddress(address);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool DeleteUser(int userId)
        {
            try
            {
                return iaddressRL.Deleteaddress(userId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
