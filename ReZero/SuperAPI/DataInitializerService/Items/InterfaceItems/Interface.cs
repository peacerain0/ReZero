﻿using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReZero.SuperAPI
{
    internal partial class InterfaceListInitializerProvider
    {
        public void AddInit_ZeroInterfaceList()
        {
            Intenal();

            Dynamic();

            GetDynamicGroupNameList();

        }

        private void GetDynamicGroupNameList()
        {

            ZeroInterfaceList data2 = GetNewItem(it =>
            {
                it.HttpMethod = HttpRequestMethod.GET.ToString();
                it.Id = IntCateGroupNameListId;
                it.GroupName = nameof(ZeroInterfaceList);
                it.InterfaceCategoryId = InterfaceCategoryInitializerProvider.Id100004;
                it.Name = TextHandler.GetInterfaceListText(IntCateGroupNameListId);
                it.Url = GetUrl(it, "GetDynamicGroupNameList");
                it.DataModel = new DataModel()
                {
                    Columns = new List<DataColumnParameter>()
                    {

                        new DataColumnParameter(){
                            PropertyName= nameof(ZeroInterfaceCategory.Name) ,
                            Description=TextHandler.GetCommonText("名称", "GroupName")
                        }
                    },
                    SelectParameters = new List<DataModelSelectParameters>()
                    {
                        new DataModelSelectParameters()
                        {
                          Name=nameof(ZeroInterfaceList.GroupName),
                          AsName=nameof(ZeroInterfaceList.GroupName)
                        }
                    },
                    TableId = EntityInfoInitializerProvider.Id_ZeroInterfaceList,
                    ActionType = ActionType.QueryCommon,
                    GroupParemters = new List<DataModelGroupParameter>()
                    {
                        new DataModelGroupParameter()
                        {
                            FieldName="GroupName",
                        }
                    },
                    DefaultParameters = new List<DataModelDefaultParameter>() {
                             new DataModelDefaultParameter() { Name = nameof(ZeroInterfaceCategory.IsDeleted),   FieldOperator=FieldOperatorType.Equal,  ValueType = typeof(bool).Name,Value="false",ValueIsReadOnly=true, Description = TextHandler.GetCommonText("IsDeleted", "IsDeleted") },
                             new DataModelDefaultParameter() { Name = nameof(ZeroInterfaceCategory.IsInitialized),   FieldOperator=FieldOperatorType.Equal,  ValueType = typeof(bool).Name,Value="false",ValueIsReadOnly=true, Description = TextHandler.GetCommonText("IsInitialized", "IsInitialized") },
                    }
                };
            });
            zeroInterfaceList.Add(data2);
        }
        private void Dynamic()
        { 
            ////动态测试接口
            //ZeroInterfaceList data3 = GetNewItem(it =>
            //{
            //    it.HttpMethod = HttpRequestMethod.GET.ToString();
            //    it.Id = TestId;
            //    it.GroupName = nameof(ZeroInterfaceList);
            //    it.InterfaceCategoryId = InterfaceCategoryInitializerProvider.Id200100;
            //    it.Name = TextHandler.GetInterfaceListText(TestId);
            //    it.Url = "/MyTest/API";
            //    it.DataModel = new DataModel()
            //    {
            //        TableId = EntityInfoInitializerProvider.Id_ZeroInterfaceList,
            //        ActionType = ActionType.QueryByPrimaryKey,
            //        DefaultParameters = new List<DataModelDefaultParameter>() {
            //                new DataModelDefaultParameter(){
            //                      Name="Id",
            //                      ParameterValidate=new ParameterValidate{
            //                      IsRequired=true
            //                    },
            //                    FieldOperator=FieldOperatorType.Equal,
            //                    ValueType=typeof(long).Name,
            //                    Description=TextHandler.GetCommonText("根据主键获取接口","Get interface detail") },
            //             }
            //    };
            //    it.IsInitialized = false;
            //});
            //zeroInterfaceList.Add(data3);


            //获取动态接口加分页
            ZeroInterfaceList data = GetNewItem(it =>
            {
                it.HttpMethod = HttpRequestMethod.GET.ToString();
                it.Id = DynamicIntPageListId;
                it.CustomResultModel = new ResultModel() { ResultType = ResultType.Grid };
                it.GroupName = nameof(ZeroInterfaceList);
                it.InterfaceCategoryId = InterfaceCategoryInitializerProvider.Id100003;
                it.Name = TextHandler.GetInterfaceListText(DynamicIntPageListId);
                it.Url = GetUrl(it, "GetDynamicInterfacePageList");
                it.DataModel = new DataModel()
                {
                    JoinParameters = new List<DataModelJoinParameters>() {
                      new DataModelJoinParameters(){
                       JoinTableId=EntityInfoInitializerProvider.Id_ZeroInterfaceCategory,
                       JoinType=JoinType.Left,
                        OnList=new List<JoinParameter>()
                        {
                            new JoinParameter(){
                                 LeftIndex=0,
                                 LeftPropertyName=nameof(ZeroInterfaceList.InterfaceCategoryId),
                                 RightIndex=1,
                                 RightPropertyName=nameof(ZeroInterfaceCategory.Id),
                                 FieldOperator=FieldOperatorType.Equal
                            }
                        }
                      }
                    },
                    CommonPage = new DataModelPageParameter()
                    {
                        PageNumber = 1,
                        PageSize = 20
                    },
                    OrderByFixedParemters=new List<DataModelOrderParemter>() 
                    {
                         new DataModelOrderParemter(){
                          FieldName="ID",
                          OrderByType=OrderByType.Desc
                         }
                    },
                    SelectParameters = new List<DataModelSelectParameters>()
                    {
                          new DataModelSelectParameters()
                          {
                              TableIndex=0,
                              IsTableAll=true
                          },
                          new DataModelSelectParameters()
                          {
                              TableIndex=1,
                              Name=nameof(ZeroInterfaceCategory.Name),
                              AsName=PubConst.Orm_InterfaceCategroyNameDTO,

                          }
                    },
                    Columns = new List<DataColumnParameter>()
                    {

                        new DataColumnParameter(){
                            PropertyName= nameof(ZeroInterfaceList.Id) ,
                            Description=TextHandler.GetCommonText("ID", "Primary key")
                        },
                        new DataColumnParameter(){
                            PropertyName= nameof(ZeroInterfaceList.Name) ,
                            Description=TextHandler.GetCommonText("名称", "Name")
                        },
                        new DataColumnParameter(){
                            PropertyName= nameof(ZeroInterfaceList.GroupName) ,
                            Description=TextHandler.GetCommonText("分组", "Group")
                        },
                      new DataColumnParameter(){
                            PropertyName=PubConst.Orm_InterfaceCategroyNameDTO ,
                            Description=TextHandler.GetCommonText("分类", "Interface categroy")
                        },
                        new DataColumnParameter(){
                            PropertyName= nameof(ZeroInterfaceList.Url) ,
                            Description=TextHandler.GetCommonText("接口地址", "Url")
                        } 
                    },
                    TableId = EntityInfoInitializerProvider.Id_ZeroInterfaceList,
                    ActionType = ActionType.QueryCommon,
                    DefaultParameters = new List<DataModelDefaultParameter>() {
                            new DataModelDefaultParameter(){ Name="InterfaceCategoryId",FieldOperator=FieldOperatorType.In,  ValueType=typeof(long).Name, Description=TextHandler.GetCommonText("接口分类Id","Interface Category Id") },
                            new DataModelDefaultParameter(){ Name="Name", FieldOperator=FieldOperatorType.Like, ValueType=typeof(string).Name, Description=TextHandler.GetCommonText("接口名称","Interface Name") },
                            new DataModelDefaultParameter(){ Name="GroupName", FieldOperator=FieldOperatorType.Like, ValueType=typeof(string).Name, Description=TextHandler.GetCommonText("接口分组","Group Name") },
                            new DataModelDefaultParameter() { Name = "IsInitialized",Value=false,ValueIsReadOnly=true,FieldOperator=FieldOperatorType.Equal,  ValueType = typeof(bool).Name, Description = TextHandler.GetCommonText("是否内置数据", "Is initialized") },
                            new DataModelDefaultParameter() { Name = "IsDeleted",Value=false,ValueIsReadOnly=true,FieldOperator=FieldOperatorType.Equal,  ValueType = typeof(bool).Name, Description = TextHandler.GetCommonText("是否删除", "Is deleted") },
                            new DataModelDefaultParameter() { Name = nameof(ZeroInterfaceList.IsAttributeMethod),Value=false,ValueIsReadOnly=true,FieldOperator=FieldOperatorType.Equal,  ValueType = typeof(bool).Name, Description = TextHandler.GetCommonText("是否是特性方法", "Is attribute method") },
                            new DataModelDefaultParameter(){ Name="Url",MergeForName="Name",ValueIsReadOnly=true, FieldOperator=FieldOperatorType.Like, ValueType=typeof(string).Name, Description=TextHandler.GetCommonText("Url","Url") },
                            new DataModelDefaultParameter(){ Name="DatabaseId", FieldOperator=FieldOperatorType.Equal, ValueType=typeof(long).Name, Description=TextHandler.GetCommonText("数据库Id","Database id") },
                            new DataModelDefaultParameter() { Name=nameof(DataModelPageParameter.PageNumber) ,Value=1,FieldOperator=FieldOperatorType.Equal,  ValueType = typeof(long).Name, Description = TextHandler.GetCommonText("第几页", "Page number") },
                            new DataModelDefaultParameter() { Name=nameof(DataModelPageParameter.PageSize) ,Value=20,FieldOperator=FieldOperatorType.Equal,  ValueType = typeof(long).Name, Description = TextHandler.GetCommonText("每页几条", "Pageize") }
                    }
                };
            });
            zeroInterfaceList.Add(data);


            //动态接口分类删除
            ZeroInterfaceList data2 = GetNewItem(it =>
            {
                it.HttpMethod = HttpRequestMethod.GET.ToString();
                it.Id = DeleteDynamicIntId;
                it.GroupName = nameof(ZeroInterfaceList);
                it.InterfaceCategoryId = InterfaceCategoryInitializerProvider.Id100003;
                it.Name = TextHandler.GetInterfaceListText(DeleteDynamicIntId);
                it.Url = GetUrl(it, "DeleteDynamicInterface");
                it.DataModel = new DataModel()
                {
                    TableId = EntityInfoInitializerProvider.Id_ZeroInterfaceList,
                    ActionType = ActionType.BizDeleteObject,
                    DefaultParameters = new List<DataModelDefaultParameter>() {
                             new DataModelDefaultParameter() { Name = nameof(ZeroInterfaceCategory.Id),   FieldOperator=FieldOperatorType.Equal,  ValueType = typeof(long).Name,Value=0, Description = TextHandler.GetCommonText("主键", "Id") },
                              new DataModelDefaultParameter() { Name = nameof(ZeroInterfaceCategory.IsDeleted),   FieldOperator=FieldOperatorType.Equal,  ValueType = typeof(bool).Name,Value="true", Description = TextHandler.GetCommonText("是否删除", "IsDeleted") }
                         }
                };
            });
            zeroInterfaceList.Add(data2);
        }

        private void Intenal()
        {
            //内部接口列表
            ZeroInterfaceList data = GetNewItem(it =>
            {
                it.HttpMethod = HttpRequestMethod.GET.ToString();
                it.Id = IntIntListId;
                it.CustomResultModel = new ResultModel() { ResultType = ResultType.Group, GroupName = nameof(ZeroInterfaceList.GroupName) };
                it.GroupName = nameof(ZeroInterfaceList);
                it.InterfaceCategoryId = InterfaceCategoryInitializerProvider.Id100003;
                it.Name = TextHandler.GetInterfaceListText(IntIntListId);
                it.Url = GetUrl(it, "GetInternalInterfaceList");
                it.DataModel = new DataModel()
                {
                    TableId = EntityInfoInitializerProvider.Id_ZeroInterfaceList,
                    ActionType = ActionType.QueryCommon,
                    DefaultParameters = new List<DataModelDefaultParameter>() {
                            new DataModelDefaultParameter(){ Name="InterfaceCategoryId",FieldOperator=FieldOperatorType.In,  ValueType=typeof(long).Name, Description=TextHandler.GetCommonText("接口分类Id","Interface Category Id") },
                            new DataModelDefaultParameter(){ Name="DatabaseId",FieldOperator=FieldOperatorType.Equal,  ValueType=typeof(long).Name, Description=TextHandler.GetCommonText("数据库Id","Database id") },
                            new DataModelDefaultParameter(){ Name="Name", FieldOperator=FieldOperatorType.Like, ValueType=typeof(string).Name, Description=TextHandler.GetCommonText("接口名称","Interface Name") },
                            new DataModelDefaultParameter() { Name = "IsInitialized",FieldOperator=FieldOperatorType.Equal,  ValueType = typeof(bool).Name, Description = TextHandler.GetCommonText("是否内置数据", "Is initialized") },
                            new DataModelDefaultParameter() { Name = "IsDeleted",Value=false,ValueIsReadOnly=true,FieldOperator=FieldOperatorType.Equal,  ValueType = typeof(bool).Name, Description = TextHandler.GetCommonText("是否删除", "Is deleted") },
                            new DataModelDefaultParameter(){ Name="Url",MergeForName="Name",ValueIsReadOnly=true, FieldOperator=FieldOperatorType.Like, ValueType=typeof(string).Name, Description=TextHandler.GetCommonText("Url","Url") },
                    }
                };
            });
            zeroInterfaceList.Add(data);

            //内部接口列表详情
            ZeroInterfaceList data2 = GetNewItem(it =>
            {
                it.HttpMethod = HttpRequestMethod.GET.ToString();
                it.Id = IntDetId;
                it.GroupName = nameof(ZeroInterfaceList);
                it.InterfaceCategoryId = InterfaceCategoryInitializerProvider.Id100003;
                it.Name = TextHandler.GetInterfaceListText(IntDetId);
                it.Url = GetUrl(it, "GetInternalDetail");
                it.DataModel = new DataModel()
                {
                    TableId = EntityInfoInitializerProvider.Id_ZeroInterfaceList,
                    ActionType = ActionType.QueryByPrimaryKey,
                    DefaultParameters = new List<DataModelDefaultParameter>() {
                            new DataModelDefaultParameter(){ Name="Id", ParameterValidate=new ParameterValidate{
                             IsRequired=true
                            },FieldOperator=FieldOperatorType.Equal,  ValueType=typeof(long).Name, Description=TextHandler.GetCommonText("根据主键获取接口","Get interface detail") },
                         }
                };
            });
            zeroInterfaceList.Add(data2);
        }
    }
}
