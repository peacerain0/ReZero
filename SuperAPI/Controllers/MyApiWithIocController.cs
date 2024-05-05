﻿using ReZero.DependencyInjection;
using ReZero.SuperAPI;
namespace SuperAPITest.Controllers
{
    [Api(200100)]
    public class MyApiWithIocController
    {
        MyService MyService;
        public MyApiWithIocController(MyService myService)
        {
            this.MyService = myService;
        }

        [ApiMethod("我是A方法")]
        public int A(int num, int num2)
        {
            return this.MyService.CalculateSum(num, num2);
        }
    }
    public class MyService : IScopeContract
    {
        public int CalculateSum(int num, int num2)
        {
            return num2 + num;
        }
    }
}
