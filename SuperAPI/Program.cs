using Microsoft.AspNetCore.Components.Forms; 
using ReZero;
using ReZero.SuperAPI;

var builder = WebApplication.CreateBuilder(args) ;
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Register: Register the super API service
//ע�᣺ע�ᳬ��API����
builder.Services.AddReZeroServices(api => 
{
    //���ó���API
    api.EnableSuperApi(new SuperAPIOptions() { 
       DatabaseOptions=new DatabaseOptions() {
        ConnectionConfig = new SuperAPIConnectionConfig()
        {
            ConnectionString = "server=sh-cdb-c8h30rhm.sql.tencentcdb.com;port=63539;database=SuperApi;user=root;password=lnx118558",
            DbType = SqlSugar.DbType.MySql, 
        },
       }
    });
   
}); 

var app = builder.Build(); 
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
