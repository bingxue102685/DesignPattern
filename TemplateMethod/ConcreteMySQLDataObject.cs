using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    class ConcreteMySQLDataObject : DataObject
    {
        public override void Close()
        {
            Console.WriteLine("MySQL关闭！");
        }

        public override void Connect()
        {
            Console.WriteLine("MySQL连接！");
        }

        public override void Process()
        {
            Console.WriteLine("MySQL处理！");
        }

        public override void Select()
        {
            Console.WriteLine("MySQL查询！");
        }
    }
}
