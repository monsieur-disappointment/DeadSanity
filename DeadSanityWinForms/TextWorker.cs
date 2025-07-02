using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Web;

namespace lab1
{
    public class TextWorker
    {
        public static List<List<string>> ParseFile(RichTextBox tb)
        {
            List<List<string>> list = new List<List<string>>();
            List<string> idlist = new List<string>();
            List<string> datelist = new List<string>();
            List<string> actionlist = new List<string>();
            List<string> devicelist = new List<string>();
            string tmp = null;
            var regexIP = new Regex(@"(?<IP>(25[0-5]|2[0-4]\d|[01]?\d\d?)(\.(25[0-5]|2[0-4]\d|[01]?\d\d?)){3})");
            var regexDate = new Regex(@"(?<day>(0?[1-9]|[12]\d|30|31))/(?<month>(0?[1-9]|1[012]))/(?<year>(\d{4}|\d{2})):(?<time>(?:[01]\d|2[0-3]):(?:[0-5]\d):(?:[0-5]\d))");
            var regexAction = new Regex(@"{(?<act>(\w+))\s/(?<path>([\S]*\s))(?<prot>([\S]*))}");
            var regexDevice = new Regex(@"(""(.*)*"")");

            foreach (Match m in regexIP.Matches(tb.Text))
            {
                tmp = "Found IP in " + m.Groups["IP"].Index + " content: " + m.Groups["IP"].Value + "\n";
                idlist.Add(tmp);
                tmp = null;
            }

            foreach (Match d in regexDate.Matches(tb.Text))
            {
                tmp = "Found date in " + d.Groups["day"].Index + " content: " + d.Groups["day"].Value + "/" + d.Groups["month"].Value + "/" + d.Groups["year"].Value + " :" + d.Groups["time"].Value + "\n";
                datelist.Add(tmp);
                tmp = null;
            }

            foreach (Match c in regexAction.Matches(tb.Text))
            {
                tmp = "Found action in " + c.Groups["act"].Index + " content: " + c.Groups["act"].Value + " to " + c.Groups["path"].Value + " with " + c.Groups["prot"].Value + "\n";
                actionlist.Add(tmp);
                tmp = null;
            }

            foreach (Match a in regexDevice.Matches(tb.Text))
            {
                tmp = "Found device in " + a.Index + " content: " + a.Value + "\n";
                devicelist.Add(tmp);
                tmp = null;
            }

            list.Add(idlist);
            list.Add(datelist);
            list.Add(actionlist);
            list.Add(devicelist);
            return list;
        }

    }
}
