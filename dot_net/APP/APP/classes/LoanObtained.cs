﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    /// <summary>
    /// LoanObtained object definition for LoansObtained table
    /// </summary>
    public class LoanObtained
    {
        public int LoanObtainedID { get; set; }
        public int LoanSize { get; set; }
        public string DateOfIssue { get; set; }
        public string DateOfExpiry { get; set; }


        //Navigation Properties
        [ForeignKey("Person")]
        public int PersonID { get; set; }
        public Person Person { get; set; }
    }
}
