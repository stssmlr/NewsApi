using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.Entities
{
    public class Statistics
    {
        public int Id { get; set; }
        public string UserIp { get; set; } = string.Empty;
        public string UserSource { get; set; } = string.Empty;
        public string UserRegion { get; set; } = string.Empty;

        public int NewsId { get; set; }
        public virtual News News { get; set; }
    }
}
