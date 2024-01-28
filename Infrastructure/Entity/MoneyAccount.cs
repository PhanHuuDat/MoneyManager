using Infrastructure.Entity.Common;
using Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entity
{
    public class MoneyAccount : SoftDeleteBaseEntity
    {
        [StringLength(100)]
        public required string Name { get; set; }

        [StringLength(1024)]
        public string? Note { get; set; }

        public AccountTypeEnum AccountType { get; set; }
    }
}
