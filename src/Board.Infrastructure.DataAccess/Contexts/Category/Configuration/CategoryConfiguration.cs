using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board.Infrastucture.DataAccess.Contexts.Category.Configuration
{
    /// <summary>
    /// Конфигурация сущности категории.
    /// </summary>
    public class CategoryConfiguration : IEntityTypeConfiguration<Board.Domain.Categories.Category>
    {

        public void Configure(EntityTypeBuilder<Board.Domain.Categories.Category> builder)
        {
            throw new NotImplementedException();
        }
    }
}