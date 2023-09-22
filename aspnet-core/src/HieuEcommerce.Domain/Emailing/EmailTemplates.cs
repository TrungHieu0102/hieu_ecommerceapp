﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.TextTemplating;

namespace HieuEcommerce.Emailing
{
    public static class EmailTemplates
    {
        public const string Layout = "HieuEcommerce.Emailing.Templates.Layout";

        public const string WelcomeEmail = "HieuEcommerce.Emailing.Templates.WelcomeEmail";
        public const string CreateOrderEmail = "HieuEcommerce.Emailing.Templates.CreateOrderEmail";
    }
}
