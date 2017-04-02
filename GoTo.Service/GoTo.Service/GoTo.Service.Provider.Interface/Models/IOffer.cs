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
        double Longitude { get; set; }
        double Latitude { get; set; }
        string AuthorID { get; set; }
        string Status { get; set; }
        string Type { get; set; }
        DateTime MeetDateTime { get; set; }
        DateTime CreatedDateTime { get; set; }
    }
}
