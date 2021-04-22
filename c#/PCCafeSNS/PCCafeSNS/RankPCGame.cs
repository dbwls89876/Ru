using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Web;
using System.Xml.XPath;
using System.Xml;
using System.Xml.Xsl;
using System.Net;
using System.IO;

namespace PCCafeSNS
{
    class RankPCGame
    {
        WebBrowser webBrowser1 = new WebBrowser();
        bool complete=false;
        private List<string[]> list = new List<string[]>();
        int ListCount=0;
        public List<string[]> getList()
        {
            return list;
        }

        public bool isComplete()
        {
            return complete;
        }

        public RankPCGame()
        {
            webBrowser1.Navigate("http://www.gametrics.com/rank/Rank02.aspx");
            webBrowser1.DocumentCompleted += delegate (object sender, WebBrowserDocumentCompletedEventArgs e)
              {
                  completeDetect();
                  if(ListCount==10)
                  {
                      complete = true;
                  }
              };
        }

        public void completeDetect()
        {
            HtmlDocument doc = webBrowser1.Document;
            //*[@id="rp_rank_ctl00_tr_item"]/td[4]/a   
            for (int i=0;i<10;i++)
            {//*[@id="rp_rank_ctl00_tr_item"]/td[4]/a
                //
                HtmlElement cm = doc.GetElementById("rp_rank_ctl0" + Convert.ToString(i) + "_tr_item");
                if (cm == null)
                {
                    return;
                }
                string[] value = new string[3];
                HtmlElementCollection tds = cm.GetElementsByTagName("td");
                HtmlElementCollection gameName = tds[3].GetElementsByTagName("a");
                gameName[0].Focus();
                value[0] = gameName[0].OuterText;
                tds[4].Focus();
                value[1] = tds[4].OuterText;
                tds[5].Focus();
                value[2] = tds[5].OuterText;
                list.Add(value);
                ListCount=list.Count;
            }
            
        }
        
    }
}