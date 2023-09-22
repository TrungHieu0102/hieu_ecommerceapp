using Volo.Abp.Settings;

namespace HieuEcommerce.Emailing
{
    public class EmailSettingProvider : SettingDefinitionProvider
    {
        private readonly ISettingEncryptionService encryptionService;

        public EmailSettingProvider(ISettingEncryptionService encryptionService)
        {
            this.encryptionService = encryptionService;
        }

        public override void Define(ISettingDefinitionContext context)
        {
            var passSetting = context.GetOrNull("Abp.Mailing.Smtp.Password");
            if (passSetting != null)
            {
                string debug = encryptionService.Encrypt(passSetting,"fqgr qgyx msmf qflu");
            }

        }
    }
}
