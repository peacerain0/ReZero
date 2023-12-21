﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReZero.SuperAPI 
{
    /// <summary>
    /// Validate
    /// </summary>
    public partial class QueryCommon : IDataService
    { 
        private static bool IsDefault(DataModel dataModel)
        {
            return dataModel.CommonPage == null;
        } 
        private static bool IsAnyJoin(DataModel dataModel)
        {
            return dataModel.JoinParameters?.Any() == true;
        } 
        private static bool IsAnySelect(DataModel dataModel)
        {
            return dataModel.SelectParameters?.Any() == true;
        }
    }
}
