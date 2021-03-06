﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Calendar.Library.Repositories
{
    /// <summary>
    /// Интерфейс для взаимодействия с БД с помощью Dapper.
    /// </summary>
    public interface IRepository
    {
        #region Methods

        /// <summary>
        /// Возвращает колекцию данных из БД.
        /// </summary>
        /// <typeparam name="T">Модель данных</typeparam>
        /// <returns></returns>
        Task<IEnumerable<T>> GetData<T>(string sqlQuery) where T : class;

        /// <summary>
        /// Выполняет запрос записиси/удаления данных в БД.
        /// </summary>
        /// <typeparam name="T">Модель данных</typeparam>
        /// <param name="data">Колекция данных</param>
        void LoadData<T>(string sqlQuery, IEnumerable<T> data) where T : class;

        #endregion
    }
}
