using System;
using System.Data;

namespace DataAccess.Abstraction
{
    public interface IUnitOfWork: IDisposable
    {
        /// <summary>
        /// Получить репозиторий.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T Repository<T>();

        /// <summary>
        /// Сохранить данные
        /// </summary>
        void Save();

        /// <summary>
        /// 
        /// </summary>
        void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted);

        /// <summary>
        /// Подтвердить транзакцию
        /// </summary>
        void CommitTransaction();

        /// <summary>
        /// Откатить транзакцию
        /// </summary>
        void RollbackTransaction();
    }
}
