using Infrastructure.Entity.Common;
using Microsoft.EntityFrameworkCore;
using Shared.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entity
{
    public class IncomeExpenditure : SoftDeleteBaseEntity
    {
        [Precision(18, 2)]
        public decimal Amount { get; set; }

        [StringLength(100)]
        public string? Note { get; set; }

        [ForeignKey("IncomeExpenditureType")]
        public long? IncomeExpenditureTypeId { get; set; }
        public IncomeExpenditureType? IncomeExpenditureType { get; set; }

        [ForeignKey("MoneyAccount")]
        public long? MoneyAccountId { get; set; }
        public MoneyAccount? MoneyAccount { get; set; }
    }
}
