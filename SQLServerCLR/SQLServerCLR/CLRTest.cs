using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.SqlServer.Server;
using System.Data.SqlTypes;

public class CLRTest
{
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void HelloWorld()
    {
        SqlContext.Pipe.Send("Hello world!\n");
    }


}

