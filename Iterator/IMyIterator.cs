using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    interface IMyIterator
    {
        //第一个元素
        object Frist();
        //下一个
        object Next();
        //是否有下一个
        bool HasNext();
    }
}
