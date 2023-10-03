using System;

public class Answer
{
    public static bool CountTheType(object Arg, string TypeToCount)
    {
        // Return true if the type of the Arg is the same
        // as what the TypeToCount parameter says to count.

        Type type = Arg.GetType();

        if (type.ToString() == TypeToCount)
        {
            return true;
        }

        return false;
    }
}


