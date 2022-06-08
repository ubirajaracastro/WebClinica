using System.Data.Entity;
using WebClinica.Dominio.Contratos.Repositorios;

namespace WebClinica.InfraEstrutura.Data.Repositorios
{
    public class EntityDatabaseTransaction:IDatabaseTransaction
    {
        private DbContextTransaction _transaction;

        public EntityDatabaseTransaction(DbContext context)
        {
            _transaction = context.Database.BeginTransaction();
        }
            
        public void Commit()
        {
            _transaction.Commit();
        }

        public void Rollback()
        {
            _transaction.Rollback();
        }

        public void Dispose()
        {
            _transaction.Dispose();
        }

    }
}
