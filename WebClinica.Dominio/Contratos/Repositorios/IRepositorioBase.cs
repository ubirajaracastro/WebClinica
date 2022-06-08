using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Contratos.Repositorios
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> GetAllRelation(string relation1, string relation2, string relation3,
            Expression<Func<TEntity, bool>> filter);

        IEnumerable<TEntity> GetAllRelation(string relation1, string relation2, string relation3, string relation4,
          Expression<Func<TEntity, bool>> filter);

        IEnumerable<TEntity> GetAllRelation(string relation,Expression<Func<TEntity, bool>> filter);
        TEntity GetRelation(string relation, Expression<Func<TEntity, bool>> filter);
        IQueryable<TEntity> GetWhere(Func<TEntity, bool> predicate);
        TEntity GetFirst();
        TEntity GetFirst(Expression<Func<TEntity, bool>> filter);
        IEnumerable<TEntity> TWhere(Expression<Func<TEntity, bool>> filter);       
        void Update(TEntity objSource, TEntity objTo);
        void Remove(TEntity obj);

    }
}
