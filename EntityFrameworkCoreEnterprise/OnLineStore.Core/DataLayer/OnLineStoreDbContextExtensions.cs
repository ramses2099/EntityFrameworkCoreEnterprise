﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnLineStore.Core.EntityLayer;
using OnLineStore.Core.EntityLayer.Dbo;

namespace OnLineStore.Core.DataLayer
{
    public static class OnLineStoreDbContextExtensions
    {
        public static void Add<TEntity>(this OnLineStoreDbContext dbContext, TEntity entity, IUserInfo userInfo) where TEntity : class, IAuditableEntity
        {
            if (entity is IAuditableEntity cast)
            {
                if (string.IsNullOrEmpty(cast.CreationUser))
                    cast.CreationUser = userInfo.Name;

                if (!cast.CreationDateTime.HasValue)
                    cast.CreationDateTime = DateTime.Now;
            }

            dbContext.Set<TEntity>().Add(entity);
        }

        public static void Update<TEntity>(this OnLineStoreDbContext dbContext, TEntity entity, IUserInfo userInfo) where TEntity : class, IAuditableEntity
        {
            if (entity is IAuditableEntity cast)
            {
                if (string.IsNullOrEmpty(cast.LastUpdateUser))
                    cast.LastUpdateUser = userInfo.Name;

                if (!cast.LastUpdateDateTime.HasValue)
                    cast.LastUpdateDateTime = DateTime.Now;
            }

            dbContext.Set<TEntity>().Update(entity);
        }

        public static void Remove<TEntity>(this OnLineStoreDbContext dbContext, TEntity entity) where TEntity : class, IAuditableEntity
            => dbContext.Set<TEntity>().Remove(entity);


        private static IEnumerable<ChangeLog> GetChanges(this OnLineStoreDbContext dbContext, IUserInfo userInfo)
        {
            var exclusions = dbContext.ChangeLogExclusions.ToList();

            foreach (var entry in dbContext.ChangeTracker.Entries())
            {
                if (entry.State != EntityState.Modified)
                    continue;

                var entityType = entry.Entity.GetType();

                if (exclusions.Count(item => item.EntityName == entityType.Name && item.PropertyName == "*") == 1)
                    yield break;

                foreach (var property in entityType.GetTypeInfo().DeclaredProperties)
                {
                    // Validate if there is an exclusion for *.Property
                    if (exclusions.Count(item => item.EntityName == "*" && string.Compare(item.PropertyName, property.Name, true) == 0) == 1)
                        continue;

                    // Validate if there is an exclusion for Entity.Property
                    if (exclusions.Count(item => item.EntityName == entityType.Name && string.Compare(item.PropertyName, property.Name, true) == 0) == 1)
                        continue;

                    var originalValue = entry.Property(property.Name).OriginalValue;
                    var currentValue = entry.Property(property.Name).CurrentValue;

                    if (string.Concat(originalValue) == string.Concat(currentValue))
                        continue;

                    // todo: improve the way to retrieve primary key value from entity instance
                    var key = entry.Entity.GetType().GetProperties().First().GetValue(entry.Entity, null).ToString();

                    yield return new ChangeLog
                    {
                        ClassName = entityType.Name,
                        PropertyName = property.Name,
                        Key = key,
                        OriginalValue = originalValue == null ? string.Empty : originalValue.ToString(),
                        CurrentValue = currentValue == null ? string.Empty : currentValue.ToString(),
                        UserName = userInfo.Name,
                        ChangeDate = DateTime.Now
                    };
                }
            }
        }


    }


}

