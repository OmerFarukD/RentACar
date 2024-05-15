using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;
using RentACar.WebApp.Models;
using RentACar.WebApp.Models.Entities;

namespace RentACar.WebApp.Repositories;

public interface IEntityRepository<TEntity,TId> where  TEntity : Entity<TId>
{
    
    IQueryable<TEntity?> Query();
    List<TEntity> GetAll(Expression<Func<TEntity, bool>>? predicate = null,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null);

    TEntity? Get(Expression<Func<TEntity?, bool>> predicate,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null);

    TEntity Add(TEntity entity);
    TEntity Update(TEntity entity);
    TEntity Delete(TEntity entity);

}