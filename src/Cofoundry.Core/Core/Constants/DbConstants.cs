﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofoundry.Core
{
    public static class DbConstants
    {
        /// <summary>
        /// The schema for Cofoundry tables 'Cofoundry'
        /// </summary>
        public static string CofoundrySchema = "Cofoundry";

        /// <summary>
        /// The default/suggested schema for a cofoundry implementation's tables 'app'
        /// </summary>
        public static string DefaultAppSchema = "app";

        /// <summary>
        /// The connection string name for the db connection 'Cofoundry' which
        /// you can re-use for other connections to the Cofoundry database.
        /// </summary>
        public static string ConnectionStringName = "Cofoundry";
    }
}