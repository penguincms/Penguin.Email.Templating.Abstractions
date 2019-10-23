using Penguin.Templating.Abstractions.Interfaces;

namespace Penguin.Email.Templating.Abstractions.Interfaces
{
    /// <summary>
    /// Represents a template used for generating email messages
    /// </summary>
    public interface IEmailTemplate : IModifiableEntity
    {
        /// <summary>
        /// Whether or not this template is currently enabled
        /// </summary>
        bool Enabled { get; }

        string HandlerName { get; }
    }
}