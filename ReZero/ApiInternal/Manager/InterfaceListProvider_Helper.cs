﻿using System;
using System.Collections.Generic;
using System.Text; 

namespace ReZero
{
    internal partial class InterfaceListProvider
    {
        /// <summary>
        /// 数据库管理
        /// </summary> 
        [TextCN("数据库管理")]
        [TextEN("Database management")]
        public const long Id1 = 1;
        /// <summary>
        /// 接口列表
        /// </summary> 
        [TextCN("接口列表")]
        [TextEN("Interface list")]
        public const long Id2 = 2;
        /// <summary>
        /// 接口分类
        /// </summary> 
        [TextCN("接口分类")]
        [TextEN("Interface classification")]
        public const long Id3 = 3;

        private static ZeroInterfaceList GetNewItem(Action<ZeroInterfaceList> action)
        {
            var result = new ZeroInterfaceList()
            {
                IsInitialized = true,
            };
            action(result);
            return result;
        }

        private static string GetUrl(ZeroInterfaceList zeroInterface, string actionName)
        {
            return $"{NamingConventionsConst.ApiReZeroRoute}/{zeroInterface.InterfaceCategoryId}/{actionName}";
        }
    }
}
