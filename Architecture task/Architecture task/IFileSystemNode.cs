using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Architecture_task
{
    interface IFileSystemNode
    {
        String Name { get; set; }
        String ParentName { get; set; }
        String FullPath { get;  }
        String Type { get;  }
    }
}
