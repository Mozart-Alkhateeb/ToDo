using System.Collections.Generic;

namespace ToDo.API.Data
{
    public class Config
    {
        public static List<string> Statues = new List<string>
        {
            "Pending",
            "In Progress",
            "Done",
            "Cancelled"
        };
    }
}
