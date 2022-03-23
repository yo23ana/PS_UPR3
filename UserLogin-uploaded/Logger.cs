using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
        static class Logger
        {
            private static List<string> currentSessionActivities = new List<string>();

            public static void LogActivity(string activity)
            {
                string activityLine = DateTime.Now + ";" + LoginValidation.CurrentUsername + ";" +
                                      LoginValidation.CurrentUserRole + ";" + activity;

                if (File.Exists("test.txt") == true)
                {
                    File.AppendAllText("test.txt", activityLine);
                }

            currentSessionActivities.Add(activityLine);
        }


        static public IEnumerable<string> GetCurrentSessionActivities(string filter)
        {
            return (from activity in currentSessionActivities where activity.Contains(filter) select activity);
        }
        public static IEnumerable<string> ReadActivityLog()
        {
            using (StreamReader sr = File.OpenText("test.txt"))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }
    }
}

