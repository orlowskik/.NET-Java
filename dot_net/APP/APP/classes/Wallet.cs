﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    /// <summary>
    /// Wallet object definition for Wallets table
    /// </summary>
    public class Wallet
    {
        public int WalletID { get; set; }
        public string E_Mail { get; set; }
        public string PhoneNumber { get; set; }
        public int Value { get; set; } 
    }
}
