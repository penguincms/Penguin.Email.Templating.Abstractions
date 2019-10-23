using Penguin.Email.Abstractions.Interfaces;
using System;
using System.Collections.Generic;

namespace Penguin.Email.Templating.Abstractions.Interfaces
{
    public interface ISendTemplates
    {
        void GenerateEmailFromTemplate(Dictionary<string, object> Model, DateTime? SendDate = null, string HandlerName = null, bool skipCallerValidation = false, IEmailMessage Overrides = null);
    }
}