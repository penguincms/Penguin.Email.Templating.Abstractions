using Penguin.Email.Abstractions.Interfaces;
using Penguin.Email.Templating.Abstractions.Interfaces;
using System;
using System.Collections.Generic;

namespace Penguin.Email.Templating.Abstractions.Extensions
{
    public static class ISendTemplateExtensions
    {
        public static void TrySendTemplate(this ISendTemplates sender, Dictionary<string, object> model, DateTime? SendDate = null, string HandlerName = null, IEmailMessage Overrides = null)
        {
            sender?.GenerateEmailFromTemplate(model, SendDate, HandlerName, true, Overrides);
        }
    }
}