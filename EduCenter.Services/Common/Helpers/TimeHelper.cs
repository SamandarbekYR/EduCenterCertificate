using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCenter.Services.Common.Helpers;
public class TimeHelper
{
    public static DateTime GetDateTime()
    {
        var dtTime = DateTime.UtcNow;
        var TimeConstans = 5;
        dtTime.AddHours(TimeConstans);
        return dtTime;
    }
}