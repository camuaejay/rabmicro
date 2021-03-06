﻿using Rabbit.Banking.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rabbit.Banking.Data.Interfaces
{
    public interface IBankingDataGateway
    {
        IEnumerable<AccountModel> GetAccounts();
    }
}
