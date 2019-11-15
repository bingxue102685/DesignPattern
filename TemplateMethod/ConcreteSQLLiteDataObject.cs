using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    class ConcreteSQLLiteDataObject : DataObject
    {
        public override void Close()
        {
            Console.WriteLine("SQLLite关闭！");
        }

        public override void Connect()
        {
            Console.WriteLine("SQLLite连接！");
        }

        public override void Process()
        {
            Console.WriteLine("SQLLite处理！");
        }

        public override void Select()
        {
            Console.WriteLine("SQLLite查询！");
        }
    }
}
