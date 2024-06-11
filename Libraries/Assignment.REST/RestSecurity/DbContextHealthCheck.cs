#if RestSecurity

using Assignment.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment.REST.RestSecurity
{
    public class DbContextHealthCheck : IHealthCheck
    {
        private readonly RestoContext _dbContext;

        public DbContextHealthCheck(RestoContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<HealthCheckResult> CheckHealthAsync(
            HealthCheckContext context,
            CancellationToken cancellationToken = default)
        {
            try
            {
               
                await _dbContext.Database.CanConnectAsync(cancellationToken);

              
                return HealthCheckResult.Healthy();
            }
            catch (Exception ex)
            {
                return HealthCheckResult.Unhealthy("DbContext connection test failed", ex);
            }
        }
    }
}

#endif

