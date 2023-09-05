/* -------------------------------------------------------------------------------------------------
   Copyright (C) Siemens Healthcare GmbH 2023, All rights reserved. Restricted.
   ------------------------------------------------------------------------------------------------- */

using WebAppWithSQLDB.Models;

namespace WebAppWithSQLDB.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
