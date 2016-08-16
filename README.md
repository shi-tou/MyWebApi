# MyWebApi

使用nuget控制台
PM> install-package Swashbuckle
安装Swashbuckle，会自动引用Swashbuckle程序集并在App_Start文件夹下添加SwaggerConfig.cs文件

找到c.IncludeXmlComments方法并修改为 c.IncludeXmlComments(GetXmlCommentsPath(thisAssembly.GetName().Name));

添加方法：
private static string GetXmlCommentsPath(string name)
{
  return string.Format(@"{0}\bin\{1}.XML", AppDomain.CurrentDomain.BaseDirectory, name);
}

设置输出xml文档文件：
项目属性->生成-输出->勾上XML文档文件

浏览器访问：http://yourhostname.com/swagger/ui/index
