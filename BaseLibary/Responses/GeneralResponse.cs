using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibary.Responses
{
    public record GeneralResponse(bool Flag, string message = null!);
    
}
