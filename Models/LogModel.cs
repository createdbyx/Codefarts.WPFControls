// <copyright>
//   Copyright (c) 2012 Codefarts
//   All rights reserved.
//   contact@codefarts.com
//   http://www.codefarts.com
// </copyright>

namespace Codefarts.WPFControls.Models
{
    using System;
    using System.ComponentModel;

    /// <summary>
    ///     Provides a log model for a log entry.
    /// </summary>
    public class LogModel : INotifyPropertyChanged
    {
        #region Fields

        /// <summary>
        ///     The category associated with the entry.
        /// </summary>
        private string category;

        /// <summary>
        ///     A unique identifier associated with the log.
        /// </summary>
        private int id;

        /// <summary>
        ///     The message for the entry.
        /// </summary>
        private string message;

        /// <summary>
        ///     Holds the date/time associated with the log entry.
        /// </summary>
        private DateTime timeStamp;

        /// <summary>
        ///     The type of log entry.
        /// </summary>
        private LogEntryType type;     

        #endregion

        #region Public Events

        /// <summary>Occurs when a property value changes.</summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets a category associated with the entry.
        /// </summary>
        public string Category
        {
            get
            {
                return this.category;
            }

            set
            {
                this.category = value;
                this.OnPropertyChanged("Category");
            }
        }

        /// <summary>
        ///     Gets or sets a unique id associated with the entry.
        /// </summary>
        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
                this.OnPropertyChanged("Id");
            }
        }

        /// <summary>
        ///     Gets or sets the message associated with the entry.
        /// </summary>
        public string Message
        {
            get
            {
                return this.message;
            }

            set
            {
                this.message = value;
                this.OnPropertyChanged("Message");
            }
        }

        /// <summary>
        ///     Gets or sets a date time stamp of when the entry was made.
        /// </summary>
        public DateTime TimeStamp
        {
            get
            {
                return this.timeStamp;
            }

            set
            {
                this.timeStamp = value;
                this.OnPropertyChanged("TimeStamp");
            }
        }

        /// <summary>
        ///     Gets or sets the type associated with the entry.
        /// </summary>
        public LogEntryType Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.type = value;
                this.OnPropertyChanged("Type");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Called when [property changed].
        /// </summary>
        /// <param name="propertyName">
        /// Name of the property.
        /// </param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}