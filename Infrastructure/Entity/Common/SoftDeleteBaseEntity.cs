using Infrastructure.Database;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entity.Common
{
    public abstract class SoftDeleteBaseEntity
    {
        [Key]
        public long Id { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime UpdatedDate { get; set;}

        [ForeignKey("CreatedUser")]
        public  string? CreatedUserId { get; set; }

        public  ApplicationUser? CreatedUser { get; set; }

        [ForeignKey("UpdatedUser")]
        public string? UpdatedUserId { get; set; }

        public ApplicationUser? UpdatedUser { get; set; }

        public bool IsDeleted { get; set; }
    }
}
