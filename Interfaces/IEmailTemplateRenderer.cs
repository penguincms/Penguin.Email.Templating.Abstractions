using Penguin.Templating.Abstractions;
using System.Collections.Generic;
using System.Reflection;

namespace Penguin.Email.Templating.Abstractions.Interfaces
{
    /// <summary>
    /// An interface used for classes intended to render out email templates into HTML
    /// </summary>
    public interface IEmailTemplateRenderer
    {
        /// <summary>
        /// Takes information required by the email template and attempts to return bound HTML representing the provided field
        /// </summary>
        /// <param name="Parameters">A collection of object names and values to be passed into the template</param>
        /// <param name="Template">The template to use for generation</param>
        /// <param name="Field">The field/property on the email template that this call is binding (in case its not the body)</param>
        /// <returns>The Html contents of the post-bound template field</returns>
        string RenderEmail(IEnumerable<TemplateParameter> Parameters, IEmailTemplate Template, PropertyInfo Field);
    }
}