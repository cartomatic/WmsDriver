﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartomatic.Wms
{
    public partial class Wms2WmtsProxy
    {
        /// <summary>
        /// Wmts capabilities object
        /// </summary>
        protected internal Cartomatic.OgcSchemas.Wmts.Wmts_101.Capabilities WmtsCaps { get; set; }
    }
}
