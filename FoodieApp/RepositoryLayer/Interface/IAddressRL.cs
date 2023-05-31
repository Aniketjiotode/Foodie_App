using CommanLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interface
{
    public interface IAddressRL
    {
        public bool Insertaddress(AddressModel address);
        public List<AddressModel> GetAlladdress();
        public bool UpdateAddress(AddressModel address);
        public bool Deleteaddress(int addressId);

    }
}
