using System;
namespace Task11
{
    public class SaintNicholas
    {
        private static SaintNicholas instance;
        private SaintNicholas()
        {
        }

        public static SaintNicholas GetInstance()
        {
            if (instance == null)
                instance = new SaintNicholas();
            return instance;
        }

        public IGift CreateGift(GiftBuilder giftBuilder)
        {
            giftBuilder.CreateGift();
            giftBuilder.SetToy();
            giftBuilder.SetEatingGift();
            giftBuilder.SetWish();
            return giftBuilder.Gift;
        }
    }

}
