using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Lists.Models
{
    internal class Logs
    {
        public int ErrorCode { get; set; }
        public string Message { get; set; }
        public DateTime timeOfEvent { get; set; }
    }
}
