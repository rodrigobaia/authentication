using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Support.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Domain.Repository.Config
{
    /// <summary>
    /// 
    /// </summary>
    internal class ApplicationIdConfig : IEntityTypeConfiguration<ApplicationId>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<ApplicationId> builder)
        {
            builder.ToTable("ApplicationIds");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .ValueGeneratedNever()
                .HasMaxLength(40)
                .IsRequired();

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Active)
                .HasColumnName("Active")
                .IsRequired();

            builder.Property(x => x.CreatedIn)
                .HasColumnName("CreatedIn")
                .IsRequired();

            builder.HasIndex(x => x.Name)
                .IsUnique();

            builder.HasData(LoadApplicationId());
        }

        private ApplicationId[] LoadApplicationId()
        {
            var lst = new List<ApplicationId>
            {
                new ApplicationId
                {
                    Active = true,
                    CreatedIn = DateTime.Now.GetCurrentDate(),
                    Id = Guid.NewGuid().ToString(),
                    Name = "FICHAPJ"
                }
            };

            return lst.ToArray();
        }
    }
}
