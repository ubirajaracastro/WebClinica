using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using WebClinica.Dominio.Contratos.Repositorios;
using System.Linq.Expressions;
using System.Collections;

namespace WebClinica.InfraEstrutura.Data.Repositorios
{

    public class RepositorioBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly WebClinicaDataContext Db;

        public RepositorioBase(WebClinicaDataContext _Db)
        {
            Db = _Db;
        }

        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);

          
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().AsNoTracking().ToList();
        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);

        }

        public void Update(TEntity objSource, TEntity objTo)
        {
            Db.Entry(objSource).CurrentValues.SetValues(objTo);
        }

        public TEntity GetFirst()
        {
            return Db.Set<TEntity>().FirstOrDefault();
        }

        public TEntity GetFirst(Expression<Func<TEntity, bool>> filter)
        {
            return Db.Set<TEntity>().Where(filter).FirstOrDefault();
        }

        public IEnumerable<TEntity> TWhere(Expression<Func<TEntity, bool>> filter)
        {
            return Db.Set<TEntity>().Where(filter);
        }

        public IEnumerable<TEntity> GetAll(int id)
        {
            return Db.Set<TEntity>().AsNoTracking();
        }

        public IQueryable<TEntity> GetWhere(Func<TEntity, bool> predicate)
        {   
            return GetAll().Where(predicate).AsQueryable();
                      
        }

        public IEnumerable<TEntity> GetAllRelation(string relation1, string relation2, string relation3,
            Expression<Func<TEntity, bool>> filter)
        {
            return Db.Set<TEntity>().Include(relation1).Include(relation2).Include(relation3).Where(filter);
        }

        public IEnumerable<TEntity> GetAllRelation(string relation1, string relation2, string relation3, string relation4,
           Expression<Func<TEntity, bool>> filter)
        {
            return Db.Set<TEntity>().Include(relation1).Include(relation2).Include(relation3).Include(relation4).Where(filter);
        }

        public IEnumerable<TEntity> GetAllRelation(string relation, Expression<Func<TEntity, bool>> filter)
        {
            return Db.Set<TEntity>().Include(relation).Where(filter);
        }

        public TEntity GetRelation(string relation, Expression<Func<TEntity, bool>> filter)
        {
            return Db.Set<TEntity>().Include(relation).First(filter);
        }

              
    }
}
