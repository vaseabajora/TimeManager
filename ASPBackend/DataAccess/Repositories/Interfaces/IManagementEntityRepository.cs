﻿using ASPBackend.Models;

namespace ASPBackend.DataAccess.Repositories.Interfaces
{
    public interface IManagementEntityRepository : IGenericRepository<ManagementEntity>
    {
        public Task<ManagementEntity> GetManagementEntityByDate(DateTime date, int userId);
    }
}
