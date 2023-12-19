﻿using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ReZero.SuperAPI
{
    /// <summary>
    /// Helper
    /// </summary>
    public partial class QueryCommon : IDataService
    {
        private QueryMethodInfo Select(DataModel dataModel, QueryMethodInfo queryObject)
        {
            if (IsAnySelect(dataModel))
            {

            }
            else if (IsAnyJoin(dataModel))
            {
                queryObject = queryObject.Select($"{PubConst.TableDefaultPreName}0.*");
            }
            return queryObject;
        }

    }
}
