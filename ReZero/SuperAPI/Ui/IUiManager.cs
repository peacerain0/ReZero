﻿using System.Net.Http;
using System.Threading.Tasks;

namespace ReZero.SuperAPI
{
    /// <summary>
    /// 默认UI使用，如果是Vue前后分离不会使用该类
    /// </summary>
    public interface IUiManager
    {
        Task<string> GetHtmlAsync(string fileContent, string filePath, Microsoft.AspNetCore.Http.HttpContext content);
        bool IsMasterPage(string fileContent);
    }
}