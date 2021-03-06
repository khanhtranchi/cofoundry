﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Cofoundry.Web.Admin
{
    public class PageTemplatesRouteLibrary : AngularModuleRouteLibrary
    {
        public const string RoutePrefix = "page-templates";

        #region constructor

        public PageTemplatesRouteLibrary()
            : base(RoutePrefix, RouteConstants.InternalModuleResourcePathPrefix)
        {
        }

        #endregion

        #region routes

        public string List()
        {
            return AngularRoute();
        }

        public string New()
        {
            return AngularRoute("new");
        }

        public string Details(int id)
        {
            return AngularRoute(id.ToString());
        }

        #endregion
    }
}