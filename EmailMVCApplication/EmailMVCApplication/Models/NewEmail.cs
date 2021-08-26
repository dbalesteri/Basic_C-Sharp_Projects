using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using EmailSender;
using Hangfire;
using System.Net.Mail;

namespace EmailMVCApplication.Models
{

    public class NewEmail : Email
    {
        [Key]
        public int Id { get; set; }

    }


    public class NewEmailDBContext : DbContext
    {
        public DbSet<NewEmail> NewEmails { get; set; }
    }
}
