// <copyright>
//   Copyright (c) 2012 Codefarts
//   All rights reserved.
//   contact@codefarts.com
//   http://www.codefarts.com
// </copyright>

namespace Codefarts.WPFControls.Models
{
    /// <summary>
    /// Provides identifiers for various log entry types.
    /// </summary>
    public enum LogEntryType
    {
        /// <summary>
        /// General information.
        /// </summary>
        Information,

        /// <summary>
        /// Non critical warning.
        /// </summary>
        Warning,

        /// <summary>
        /// Failure notice.
        /// </summary>
        Fail,

        /// <summary>
        /// Event notification entry.
        /// </summary>
        Event,

        /// <summary>
        /// A generic entry.
        /// </summary>
        Generic,

        /// <summary>
        /// A error occurred.
        /// </summary>
        Error,
    }
}
