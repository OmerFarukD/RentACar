using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using RentACar.WebApp.Models;
using RentACar.WebApp.Models.Entities;

namespace RentACar.WebApp.Repositories;

public class EfRepositoryBase<TEntity,TId,TContext> : IEntityRepository<TEntity,TId>
    where TEntity : Entity<TId> 
    where TContext : DbContext
{

    protected TContext Context;

    public EfRepositoryBase(TContext context)
    {
        Context = context;
    }


    public IQueryable<TEntity?> Query() => Context.Set<TEntity>();

    public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? predicate = null,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null)
    {
        IQueryable<TEntity?> queryable = Query();

        if (include != null)
            queryable = include(queryable!);
        if (predicate != null)
            queryable = queryable.Where(predicate!);

        return queryable.ToList();

    }

    public TEntity? Get(Expression<Func<TEntity?, bool>> predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null)
    {
        IQueryable<TEntity?> queryable = Query();
        if (include != null)
            queryable = include(queryable);

        return queryable.FirstOrDefault(predicate);
    }

    public TEntity Add(TEntity entity)
    {
        Context.Add(entity);
        Context.SaveChanges();

        return entity;
    }

    public TEntity Update(TEntity entity)
    {
        Context.Update(entity);
        Context.SaveChanges();

        return entity;
    }

    public TEntity Delete(TEntity entity)
    {
        Context.Remove(entity);
        Context.SaveChanges();
        return entity;
    }
}