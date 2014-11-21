//-----------------------------------------------------------------------------
// <copyright file="Log4netLogProvider.cs" company="Neudesic">
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

    /// <summary>
    /// Log provider class that is used by Neuron ESB to obtain instances of
    /// the <see cref="Log4netLog"/> class at runtime.
    /// </summary>
    public class Log4netLogProvider : LogProvider
    {
        /// <summary>
        /// Creates a logger to write to the specified log.
        /// </summary>
        /// <param name="name">
        /// The name of the log (log4net hierarchical name).
        /// </param>
        /// <returns>
        /// A <see cref="Log4netLog"/> object.
        /// </returns>
        public override Log GetLogger(string name)
        {
            return new Log4netLog(log4net.LogManager.GetLogger(name));
        }

        /// <summary>
        /// Creates a logger to write to the specified log.
        /// </summary>
        /// <param name="type">
        /// A <see cref="Type"/> object to create a type-specific logger.
        /// </param>
        /// <returns>
        /// A <see cref="Log4netLog"/> object.
        /// </returns>
        public override Log GetLogger(Type type)
        {
            return new Log4netLog(log4net.LogManager.GetLogger(type));
        }
    }
}
