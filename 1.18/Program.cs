using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._18
{
    class Program
    {
        static void Main(string[] args)
        {     //Lisa is cooking muffins. The recipe calls for 7 cups of sugar.  She has already put in 2 cups.  How many more cups does she need to put in?

            String bakerName = "Lisa";
            int cupsNeeded = 7;
            int cupsUsed = 2;
            int cupsPutIn = (cupsNeeded - cupsUsed);

            Console.WriteLine(bakerName + " needs to put in " + cupsPutIn + " more cups to finish the recipe.");

            //At a restaurant, Mike and his three friends decdied to divide the bill evenly.  If each person paid $13 then what was the total bill?

            String person = "Mike";
            int personBill = 13;
            int restGroup = 3;
            int totalBill = (personBill * restGroup);

            Console.WriteLine("If " + person + " pays " + personBill + "$ and the bill is spilt with " + restGroup + " other people, the total was " + totalBill + "$.");

            //How many packages of diapers can you buy with $40 if one package costs $8?

            int singleDiaperPack = 8;
            int totalMoney = 40;
            int canBuy = (totalMoney / singleDiaperPack);

            Console.WriteLine(totalMoney + "$ allows you to buy " + canBuy + " packs of diapers");

            //Last Friday Trevon had $29. Over the weekend he received some money for cleaning the attic. He now has $41.  How much  money did he  receive?

            string personPaid = "Trevon";
            int fridayMoney = 29;
            int moneyAfterPay = 41;
            int moneyReceived = (moneyAfterPay - fridayMoney);
            Console.WriteLine("If {0} initially has {1}$,but has {2}$ after getting paid, they were paid {3}$.", personPaid, fridayMoney, moneyAfterPay, moneyReceived);

            //Last week Julia ran 30 miles more than Pranav.  Julia ran 47 miles. How many miles did Pranav run?

            string furtherRunner = "Julia";
            string lesserRunner = "Pranav";
            int fRMiles = 47;
            int moreMiles = 30;
            int howManyMiles = (fRMiles - moreMiles);

            Console.WriteLine("If " + furtherRunner + " ran " + fRMiles + ", " + moreMiles + " miles more than " + lesserRunner + "; " + lesserRunner + " ran " +howManyMiles + " miles.");

            //How many boxes of envelopes can you buy with $12 if one box costs $3?

            int boxCost = 3;
            int haveMoney = 12;
            int buyBoxes = (haveMoney / boxCost);

            Console.WriteLine("If you have " + haveMoney + "$, you can buy " + buyBoxes + " boxes if they cost " + boxCost + "$.");
            
            //After paying $5.12 for a salad, Norchai has $27.10.  How much money did he have before buying the salad?

            string personEating = "Norchai";
            double saladCost = 5.12;
            double moneyRemaining = 27.10;
            double initialMoney = (saladCost + moneyRemaining);

            Console.WriteLine("If " + personEating + " has " + moneyRemaining + "$ after spending " + saladCost + "$ on a salad, they originally had " + initialMoney +"$.");

            






        } 
    }
}
