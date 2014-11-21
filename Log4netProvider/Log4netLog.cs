//-----------------------------------------------------------------------------
// <copyright file="Log4netLog.cs" company="Neudesic">
// Copyright 2006-2014 Neudesic, LLC
// </copyright>
// <license>
// Copyright 2006-2014 Neudesic, LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </license>
//-----------------------------------------------------------------------------

namespace Neuron.Esb.Logging.Log4net
{
    using System;

    using log4net;

    /// <summary>
    /// Wraps a log4net logger and writes tracing/logging output using log4net.
    /// </summary>
    internal class Log4netLog : Log
    {
        /// <summary>
        /// The log4net <see cref="ILog"/> object.
        /// </summary>
        private readonly ILog log;

        /// <summary>
        /// Initializes a new instance of the <see cref="Log4netLog"/> class.
        /// </summary>
        /// <param name="log">
        /// An <see cref="ILog"/> object.
        /// </param>
        internal Log4netLog(ILog log)
        {
            this.log = log;
        }

        /// <summary>
        /// Gets a value indicating whether debug/verbose logging is enabled.
        /// </summary>
        /// <value>
        /// <c>True</c> if verbose logging is enabled, otherwise <c>false</c>.
        /// </value>
        public override bool IsDebugEnabled
        {
            get
            {
                return this.log.IsDebugEnabled;
            }
        }

        /// <summary>
        /// Gets a value indicating whether logging errors is enabled.
        /// </summary>
        /// <value>
        /// <c>True</c> if error logging is enabled, otherwise <c>false</c>.
        /// </value>
        public override bool IsErrorEnabled
        {
            get
            {
                return this.log.IsErrorEnabled;
            }
        }

        /// <summary>
        /// Gets a value indicating whether logging fatal events is enabled.
        /// </summary>
        /// <value>
        /// <c>True</c> if fatal event logging is enabled, otherwise
        /// <c>false</c>.
        /// </value>
        public override bool IsFatalEnabled
        {
            get
            {
                return this.log.IsFatalEnabled;
            }
        }

        /// <summary>
        /// Gets a value indicating whether informational event logging is
        /// enabled.
        /// </summary>
        /// <value>
        /// <c>True</c> if logging is enabled for informational events,
        /// otherwise <c>false</c>.
        /// </value>
        public override bool IsInfoEnabled
        {
            get
            {
                return this.log.IsInfoEnabled;
            }
        }

        /// <summary>
        /// Gets a value indicating whether logging warnings is enabled.
        /// </summary>
        /// <value>
        /// <c>True</c> if logging warnings is enabled, otherwise <c>false</c>.
        /// </value>
        public override bool IsWarnEnabled
        {
            get
            {
                return this.log.IsWarnEnabled;
            }
        }

        /// <summary>
        /// Write a debug or verbose message to the log.
        /// </summary>
        /// <param name="message">
        /// The object or message to be logged.
        /// </param>
        public override void Debug(object message)
        {
            this.log.Debug(message);
        }

        /// <summary>
        /// Write a debug or verbose message to the log.
        /// </summary>
        /// <param name="message">
        /// The object or message to be logged.
        /// </param>
        /// <param name="exception">
        /// An <see cref="Exception"/> object if an error is being logged.
        /// </param>
        public override void Debug(object message, Exception exception)
        {
            this.log.Debug(message, exception);
        }

        /// <summary>
        /// Writes a formatted debug or verbose message to the log.
        /// </summary>
        /// <param name="formatProvider">
        /// A <see cref="IFormatProvider"/> object to use to format the values
        /// property for the locale.
        /// </param>
        /// <param name="format">
        /// The format string for the message to be logged.
        /// </param>
        /// <param name="args">
        /// An array containing the arguments to insert into the format
        /// string.
        /// </param>
        public override void DebugFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            this.log.DebugFormat(formatProvider, format, args);
        }

        /// <summary>
        /// Write an error message to the log.
        /// </summary>
        /// <param name="message">
        /// The object or message to be logged.
        /// </param>
        public override void Error(object message)
        {
            this.log.Error(message);
        }

        /// <summary>
        /// Write an error message to the log.
        /// </summary>
        /// <param name="message">
        /// The object or message to be logged.
        /// </param>
        /// <param name="exception">
        /// An <see cref="Exception"/> object if an error is being logged.
        /// </param>
        public override void Error(object message, Exception exception)
        {
            this.log.Error(message, exception);
        }

        /// <summary>
        /// Writes a formatted error message to the log.
        /// </summary>
        /// <param name="formatProvider">
        /// A <see cref="IFormatProvider"/> object to use to format the values
        /// property for the locale.
        /// </param>
        /// <param name="format">
        /// The format string for the message to be logged.
        /// </param>
        /// <param name="args">
        /// An array containing the arguments to insert into the format
        /// string.
        /// </param>
        public override void ErrorFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            this.log.ErrorFormat(formatProvider, format, args);
        }

        /// <summary>
        /// Write an error message to the log.
        /// </summary>
        /// <param name="message">
        /// The object or message to be logged.
        /// </param>
        public override void Fatal(object message)
        {
            this.log.Fatal(message);
        }

        /// <summary>
        /// Write an error message to the log.
        /// </summary>
        /// <param name="message">
        /// The object or message to be logged.
        /// </param>
        /// <param name="exception">
        /// An <see cref="Exception"/> object if an error is being logged.
        /// </param>
        public override void Fatal(object message, Exception exception)
        {
            this.log.Fatal(message, exception);
        }

        /// <summary>
        /// Writes a formatted error message to the log.
        /// </summary>
        /// <param name="formatProvider">
        /// A <see cref="IFormatProvider"/> object to use to format the values
        /// property for the locale.
        /// </param>
        /// <param name="format">
        /// The format string for the message to be logged.
        /// </param>
        /// <param name="args">
        /// An array containing the arguments to insert into the format
        /// string.
        /// </param>
        public override void FatalFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            this.log.FatalFormat(formatProvider, format, args);
        }

        /// <summary>
        /// Write an informational message to the log.
        /// </summary>
        /// <param name="message">
        /// The object or message to be logged.
        /// </param>
        public override void Info(object message)
        {
            this.log.Info(message);
        }

        /// <summary>
        /// Write an informational message to the log.
        /// </summary>
        /// <param name="message">
        /// The object or message to be logged.
        /// </param>
        /// <param name="exception">
        /// An <see cref="Exception"/> object if an error is being logged.
        /// </param>
        public override void Info(object message, Exception exception)
        {
            this.log.Info(message, exception);
        }

        /// <summary>
        /// Writes a formatted error message to the log.
        /// </summary>
        /// <param name="formatProvider">
        /// A <see cref="IFormatProvider"/> object to use to format the values
        /// property for the locale.
        /// </param>
        /// <param name="format">
        /// The format string for the message to be logged.
        /// </param>
        /// <param name="args">
        /// An array containing the arguments to insert into the format
        /// string.
        /// </param>
        public override void InfoFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            this.log.InfoFormat(formatProvider, format, args);
        }

        /// <summary>
        /// Write a warning message to the log.
        /// </summary>
        /// <param name="message">
        /// The object or message to be logged.
        /// </param>
        public override void Warn(object message)
        {
            this.log.Warn(message);
        }

        /// <summary>
        /// Write a warning message to the log.
        /// </summary>
        /// <param name="message">
        /// The object or message to be logged.
        /// </param>
        /// <param name="exception">
        /// An <see cref="Exception"/> object if an error is being logged.
        /// </param>
        public override void Warn(object message, Exception exception)
        {
            this.log.Warn(message, exception);
        }

        /// <summary>
        /// Writes a formatted error message to the log.
        /// </summary>
        /// <param name="formatProvider">
        /// A <see cref="IFormatProvider"/> object to use to format the values
        /// property for the locale.
        /// </param>
        /// <param name="format">
        /// The format string for the message to be logged.
        /// </param>
        /// <param name="args">
        /// An array containing the arguments to insert into the format
        /// string.
        /// </param>
        public override void WarnFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            this.log.WarnFormat(formatProvider, format, args);
        }
    }
}
