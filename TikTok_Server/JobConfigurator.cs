using Bussiness_Logic.Interfaces;
using Hangfire;

namespace TikTok_Server
{
    public class JobConfigurator
    {
        public static void AddJobs()
        {
            RemoveExpiredTokensJob();
        }
        public static void RemoveExpiredTokensJob()
        {
            RecurringJob.AddOrUpdate<IAccountsService>(
                nameof(RemoveExpiredTokensJob),
                (service) => service.RemoveExpiredRefreshTokens(),
                Cron.Weekly(DayOfWeek.Monday, 3));
        }
    }
}
