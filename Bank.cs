namespace heistV2
{
    public class Bank
    {
        public int CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }

        public bool IsSecure { get; set; }

        //A computed boolean property called IsSecure. If all the scores are less than or equal to 0, this should be false. If any of the scores are above 0, this should be true
        public void TestSecure()
        {
            if (CashOnHand + AlarmScore + VaultScore + SecurityGuardScore <= 0)
            {
                IsSecure = false;
            }
            else if (CashOnHand > 0 || AlarmScore > 0 || VaultScore > 0 || SecurityGuardScore > 0)
            {
                IsSecure = true;
            }

        }
    }
}