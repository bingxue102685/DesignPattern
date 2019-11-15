using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    //数据库的操作可抽象为
    //1. 连接数据库 2. 查询 3.操作 4.关闭连接
    //过程不变，实现不同
    abstract class DataObject
    {
        public abstract void Connect();

        public abstract void Select();

        public abstract void Process();

        public abstract void Close();

        public void Run()
        {
            //连接
            Connect();
            //查询
            Select();
            //操作
            Process();
            //关闭
            Close();
        }
    }
}
