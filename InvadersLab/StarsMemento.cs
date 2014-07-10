using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvadersLab
{
    public class StarsMemento
    {

        List<Stars.Star> savedArray;
        internal void storeCollection(List<Stars.Star> allStars)
        {
            savedArray = new List<Stars.Star>(allStars);
        }

        public bool Equals(StarsMemento obj)
        {
            bool allSame = true;
            for (int i = 0; i < savedArray.Count; i++)
            {
                if (obj.savedArray[i].point != savedArray[i].point)
                {
                    allSame = false;
                }
            }
            return allSame;
        }
    }
}
