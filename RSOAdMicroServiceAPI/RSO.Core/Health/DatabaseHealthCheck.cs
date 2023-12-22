﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using RSO.Core.AdModels;

namespace RSO.Core.Health
{
    public class DatabaseHealthCheck : IHealthCheck
    {
        private readonly AdServicesRSOContext _context;

        public DatabaseHealthCheck(AdServicesRSOContext context)
        {
            _context = context;
        }

        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new())
        {
            try
            {
                // connect to database and execute "select 1" query
                await _context.Database.OpenConnectionAsync(cancellationToken);
                await _context.Database.ExecuteSqlRawAsync("SELECT 1", cancellationToken);

                return HealthCheckResult.Healthy();
            }
            catch (Exception ex)
            {
                return HealthCheckResult.Unhealthy(ex.Message);
            }

        }
    }
}
