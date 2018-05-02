using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Reviews {
    
    public static string GetReview (string demoName, int influenceChange)
    {
        if (influenceChange > 0)
        {
            return "We like this! -" + demoName;
        }
        else if (influenceChange < 0)
        {
            return "We hate this! -" + demoName;
        }
        else
        {
            return "Meh. -" + demoName;
        }
    }
}
