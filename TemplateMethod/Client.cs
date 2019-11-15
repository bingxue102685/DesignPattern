using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    class Client
    {
        static void Main(string[] args)
        {
            //数据库操作的流程是固定的：1. 连接数据库 2. 查询 3.操作 4.关闭连接
            //每个数据库又有不同的实现细节
            //父类抽象流程
            //子类实现细节
            DataObject dataObjectMySQL = new ConcreteMySQLDataObject();
            dataObjectMySQL.Run();

            DataObject dataObjectSQLLite = new ConcreteSQLLiteDataObject();
            dataObjectSQLLite.Run();

            Console.ReadKey();
        }
    }
}
