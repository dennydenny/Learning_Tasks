using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Daniel_Khaliulin_Architecture_task
{
    public abstract class Node
    {
        public String Name { get;  protected set; }
        public Folder Parent { get; protected set; }
    }
}
