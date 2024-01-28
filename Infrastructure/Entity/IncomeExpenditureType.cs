using Infrastructure.Entity.Common;
using Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entity
{
    public class IncomeExpenditureType : SoftDeleteBaseEntity
    {
        [StringLength(100)]
        public required string Name { get; set; }

        public MoneyFlowEnum MoneyFlow { get; set; }
    }
}
