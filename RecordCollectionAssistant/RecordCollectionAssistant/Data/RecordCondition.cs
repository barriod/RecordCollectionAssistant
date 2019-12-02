using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Holds the condition enum and a toString method to ouput what the condition is
/// </summary>
namespace RecordCollectionAssistant.Data
{
    /// <summary>
    /// Holds the condition enums for the Records and Record Sleeves
    /// </summary>
    public enum RecordCondition
    {
        Mint,
        NearMint,
        VeryGoodPlus,
        VeryGood,
        GoodPlus,
        Good,
        Fair,
        Poor
    }

    public static class ConditionMethods
    {
        /// <summary>
        /// Converts the enum into a string that can be displayed
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static string ToFriendlyString(this RecordCondition condition)
        {
            switch (condition)
            {
                case RecordCondition.Mint:
                    return "Mint";
                case RecordCondition.NearMint:
                    return "Near Mint";
                case RecordCondition.VeryGoodPlus:
                    return "Very Good Plus";
                case RecordCondition.GoodPlus:
                    return "Good Plus";
                case RecordCondition.Good:
                    return "Good";
                case RecordCondition.Fair:
                    return "Fair";
                case RecordCondition.Poor:
                    return "Poor";
                default:
                    return "";
            }

        }
}
}