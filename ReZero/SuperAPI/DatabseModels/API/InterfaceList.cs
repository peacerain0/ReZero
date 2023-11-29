﻿using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReZero.SuperAPI
{
    public class ZeroInterfaceList : DbBase
    {
        public string? Url { get; set; }
        public string? Name { get; set; } 
        public long InterfaceCategoryId { get; set; }
        public string? CustomResultName { get; set; } = "";
        [SugarColumn(IsNullable = true)]
        public string? Description { get; set; }
        public string? HttpMethod { get; set; }
        [SugarColumn(IsNullable = true,IsJson =true)]
        public List<ZeroInterfaceParameter>? Parameters { get; set; }
        [SugarColumn(IsJson = true)]
        public DataModel? DataModel { get; set; }
    }
}
