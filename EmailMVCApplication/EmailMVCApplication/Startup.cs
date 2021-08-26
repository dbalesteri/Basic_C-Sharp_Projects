using Hangfire;
using Owin;
using Hangfire.SqlServer;
using System;

namespace EmailMVCApplication
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            GlobalConfiguration.Configuration
                .UseSqlServerStorage(
                    "NewEmailDBContext",
                    new SqlServerStorageOptions { QueuePollInterval = TimeSpan.FromSeconds(1) });


            app.UseHangfireDashboard();
            app.UseHangfireServer();


        }

    }
}