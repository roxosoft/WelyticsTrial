using System.Linq;
using Microsoft.EntityFrameworkCore;
using Abp.Configuration;
using Abp.Localization;
using Abp.Net.Mail;

namespace RIMIKS.EntityFrameworkCore.Seed.Host
{
    public class DefaultSettingsCreator
    {
        private readonly RIMIKSDbContext _context;

        public DefaultSettingsCreator(RIMIKSDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            // Mailing
            AddSettingIfNotExists(EmailSettingNames.DefaultFromAddress, "no-reply@rimiks.info");
            AddSettingIfNotExists(EmailSettingNames.DefaultFromDisplayName, "RIMIKS");

            // Languages
            AddSettingIfNotExists(LocalizationSettingNames.DefaultLanguage, "de");
        }

        private void AddSettingIfNotExists(string name, string value, int? tenantId = null)
        {
            if (_context.Settings.IgnoreQueryFilters().Any(s => s.Name == name && s.TenantId == tenantId && s.UserId == null))
            {
                return;
            }

            _context.Settings.Add(new Setting(tenantId, null, name, value));
            _context.SaveChanges();
        }
    }
}
