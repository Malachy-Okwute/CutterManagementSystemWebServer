﻿using System.Linq.Expressions;

namespace CutterManagement.Core
{
    /// <summary>
    /// Provides access to the application database
    /// </summary>
    public interface IDataAccessService<T> : IDisposable
    {
        /// <summary>
        /// Event to run whenever data changes in the database
        /// </summary>
        event EventHandler<object> DataChanged;

        /// <summary>
        /// Create a new entry record and save it in the database
        /// </summary>
        /// <param name="entity">The new to save to database</param>
        /// <returns><see cref="Task"/></returns>
        Task CreateNewEntityAsync(T entity);

        /// <summary>
        /// Get all entities in the database table
        /// </summary>
        /// <returns><see cref="Task"/> of <see cref="IReadOnlyList{T}"/></returns>
        Task<IReadOnlyList<T>> GetAllEntitiesAsync();

        /// <summary>
        /// Get an entity by id
        /// </summary>
        /// <param name="entityId">The id of the entity to get</param>
        /// <returns><see cref="Task"/> of <see cref="T"/></returns>
        //Task<T?> GetEntityByIdAsync(int? entityId);
        Task<T?> GetEntityByIdAsync(int? entityId);

        /// <summary>
        /// Gets an entity including it's navigation properties
        /// </summary>
        /// <typeparam name="TProperty">The navigation property</typeparam>
        /// <param name="entityId">The main entity id to get</param>
        /// <param name="includeExpression">Expression used to get the navigation properties</param>
        /// <returns><see cref="Task{T}"/> of <see cref="T"/></returns>
        //Task<T> GetEntityByIdIncludingNavigationPropertyAsync<TEntity>(int entityId, params Expression<Func<T, object>>[] includes) where TEntity : class;

        /// <summary>
        /// Update an entity
        /// </summary>
        /// <param name="entity">The entity to update</param>
        /// <returns><see cref="Task"/></returns>
        Task SaveEntityAsync(T entity);

        /// <summary>
        /// Remove entity from the database
        /// </summary>
        /// <param name="entity">The entity to remove</param>
        /// <returns><see cref="Task"/></returns>
        Task DeleteEntityAsync(T entity);
    }
}
