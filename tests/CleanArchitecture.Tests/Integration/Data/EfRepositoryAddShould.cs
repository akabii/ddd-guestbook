﻿using System.Linq;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces;
using Xunit;

namespace CleanArchitecture.Tests.Integration.Data
{
    public class EfRepositoryAddShould : EfRepositoryTestBase
    {
        [Fact]
        public void AddItemAndSetId()
        {
            var repository = GetRepository<ToDoItem>();
            var item = new ToDoItem();

            repository.Add(item);

            var newItem = repository.List().FirstOrDefault();

            Assert.Equal(item, newItem);
            Assert.True(newItem.Id > 0);
        }
    }
}