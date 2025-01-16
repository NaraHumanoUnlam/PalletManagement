using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPallets.Domain.Dtos.Request
{
    public class LocationRequest
    {
        public string Column { get; set; }
        public string Row { get; set; }
    }
}
