using CommanLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface
{
    public interface IAddressBL
    {
        public bool InsertAddress(AddressModel address);
        public List<AddressModel> GetAlladdress();

        public bool UpdateAddress(AddressModel address);
        public bool DeleteUser(int userId);

    }
}
