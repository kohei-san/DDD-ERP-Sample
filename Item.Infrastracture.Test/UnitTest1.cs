using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Item.Infrastracture.Db;
using Item.Infrastracture.Repositories;
using Item.Domain.Entities;

namespace Item.Infrastracture.Tests.Repositories
{
    public class UnitMasterRepositoryTests
    {
        [Fact]
        public void FindAll_Returns_All_Seeded_UnitMasters()
        {
            // Arrange: インメモリ DB を使う（ユニーク名で隔離）
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: $"TestDb_{Guid.NewGuid()}")
                .Options;

            using (var context = new AppDbContext(options))
            {
                // データシード
                context.UnitMasters.Add(new UnitMaster("U01", "個"));
                context.UnitMasters.Add(new UnitMaster("U02", "箱"));
                context.SaveChanges();
            }

            using (var context = new AppDbContext(options))
            {
                var repo = new UnitMasterReporitory(context);

                // Act
                var list = repo.FindAll().ToList();

                // Assert
                Assert.Equal(2, list.Count);
                Assert.Contains(list, u => u.Code == "U01" && u.Name == "個");
                Assert.Contains(list, u => u.Code == "U02" && u.Name == "箱");
            }
        }
    }
}