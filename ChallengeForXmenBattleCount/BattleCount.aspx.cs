using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class BattleCount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] xMen = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] count = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };
            
            int maxCount = count.Max();
            int minCount = count.Min();

            int maxIndex = count.ToList().IndexOf(maxCount);
            int minIndex = count.ToList().IndexOf(minCount);

            battleLabel.Text = String.Format("{0} has {1} battles.<br> {2} has {3} battles.",
                xMen[maxIndex], maxCount, xMen[minIndex], minCount);
        }
    }
}