namespace PullYourLuck.Services
{
    public class ChanceWorker
    {
        public bool RollChances(int SuccessChance, int BustChance)
        {
            if (SuccessChance > BustChance)
            {
                return true;
            }

            return false;
        }

        public int ModifySuccess(int SuccessChance, int Interval) 
        { 
            int NewSuccess = SuccessChance - Interval;
            return NewSuccess;
        }

        public int ModifyBust(int BustChance, int Interval)
        {
            int NewBust = BustChance + Interval;
            return NewBust;
        }
    }
}
