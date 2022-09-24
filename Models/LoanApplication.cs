using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace LoanManagementDone.Models
{
    public partial class LoanApplication
    {
        public LoanApplication()
        {
            LoanTransactions = new HashSet<LoanTransaction>();
        }

        public int LoanApplicationId { get; set; }
        public string LoanControlNumber { get; set; }
        public decimal LoanAmount { get; set; }
        public string Purpose { get; set; }
        public DateTime LoanApplicationSubmissionDate { get; set; }
        public DateTime? LoanApplicationApprovedDate { get; set; }
        public string LoanStatus { get; set; } = "Submitted";
        public string Remarks { get; set; }
        public int? CustomerId { get; set; }
      
        public int? LoanTypeId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual LoanType LoanType { get; set; }
        public virtual ICollection<LoanTransaction> LoanTransactions { get; set; }
    }
}
