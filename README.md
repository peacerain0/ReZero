# 加群交流
qq群号：472534707

# 一、功能说明
1、是一款.NET中间件,让你无需写任何代码也能实现CRUD，可以发布成exe独立使用于非.NET用户<br>
2、界面创建接口 、界面建库、界面建表 、界面生成接口、界面设置授权、界面生成接口文档、界面调试接口、云端ORM 、超级API
3、支持授权无论是.NET用户还是非.NET都可以
4、.NET用户只要是.NET6+的API项目都可以一行代码集成到自已项目中
5、.NET用户也可以当成架手架来使用，支持模块化、IOC（支持属性注入）、ORM、工作单元、多租户等等
![输入图片说明](READMEIMG/image1.png)
查看创建后的接口
![输入图片说明](READMEIMG/image5.png)
 

# 二、数据库支持
Sqlite 、 MySql 、 SqlServer 、 PgSQL 、Oracle 、人大金仓（默认模式）、 达梦

 
# 三、非.NET用户教程
通过下载EXE运行
https://gitee.com/DotNetNext/ReZero/releases


# 四、.NET用户教程

## 4.1 Nuget安装
```cs
Rezero.Api 
``` 
## 4.2 一行代码配置
新建一个.NET6+ WEB API
只需要注入一行代码就能使用 Rezero API

```cs
/***对现有代码没有任何影响***/

//注册：注册超级API服务
builder.Services.AddReZeroServices(api =>
{
    //启用超级API
    api.EnableSuperApi();//默认载体为sqlite ，有重载可以配置数据库

});
//写在builder.Build前面就行只需要一行
var app = builder.Build();

```
## 4.3使用ReZero
启动项目直接访问地址就行了
http://localhost:5267/rezero 
![输入图片说明](READMEIMG/image8.png)

## 4.4 授权
打开appsettings.json配置jwt参数
![输入图片说明](READMEIMG/55.png)
界面完成登录
![输入图片说明](READMEIMG/56.png) 
 

## 4.5 集成到自已系统
只要在url加上model=small 就会隐藏头部菜单和左边的菜单<br>
如果跨域或者端口需要url加token这样可以让内部接口也支持jwt授权
![输入图片说明](READMEIMG/image12.png)

效果图如下
![输入图片说明](READMEIMG/image9.png)

## 4.6统一返回结果
如果不喜欢默认返回格式我们可以自定义返回格式

```cs
builder.Services.AddReZeroServices(api =>
{
   
    api.EnableSuperApi(new SuperAPIOptions()
    {
        InterfaceOptions = new InterfaceOptions()
        {
            //MergeDataToStandardDtoFunc 设置统一返回格式
            MergeDataToStandardDtoFunc = dto =>
            {

                if (dto is ErrorResponse error)
                {
                    return new { isSuccess = false, data = error.message };
                }
                else if (dto is bool b)
                {
                    return new { isSuccess = b, data = b };
                }
                //更多逻辑自已处理这儿只是一个示例
                return new { isSuccess = true, data = dto };
            }
        }
    });

});

``` 

# 五、功能预览
## 预览1：查询配置显示列
![输入图片说明](READMEIMG/21.png)
## 预览2：查询配置联表
![输入图片说明](READMEIMG/22.png) 
## 预览3：SQL直接生成接口
![输入图片说明](READMEIMG/23.png)
## 预览4：配置完显的接口列表
![输入图片说明](READMEIMG/24.png)
## 预览5: 创建实体
![输入图片说明](READMEIMG/25.png)
## 预览6: 更新表结构对比
![输入图片说明](READMEIMG/26.png)

# 六、打赏作者

首先感谢大家 ， 项目启动前就有人赞助开发了 

工作量很大 ，功能复杂 ，对标的是收费软件，相信未来将会成长的很好

![输入图片说明](READMEIMG/image6.png)
