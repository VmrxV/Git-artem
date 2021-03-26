using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace days2
{
    public partial class Service
    {
        public string titleService
        {
            get
            {
                return Title +" "+ Cost +"nрублей за"+ DurationInSeconds/60 +
                    " минут *скидка"+ Description +"%";
            }
        }
    }
}
