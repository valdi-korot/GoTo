using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTo.Service.Provider.Interface.Models
{
    public interface IOffer
    {
        string Title { get; }
        string Description { get; set; }
    }
}
