using System;
namespace Task11
{
    public abstract class GiftBuilder
    {
        public IGift Gift { get; private set; }
        protected ChoosingGiftProgram program;
        public GiftBuilder(ChoosingGiftProgram program)
        {
            this.program = program;
        }

        public void CreateGift()
        {
            Gift = new Gift();
        }

        public abstract void SetToy();
        public abstract void SetEatingGift();
        public abstract void SetWish();
        
    }

    public class BoyRandomGiftBuilder : GiftBuilder
    {
        public BoyRandomGiftBuilder(ChoosingGiftProgram program) : base(program)
        {

        }

        public override void SetEatingGift()
        {
            Gift.EatingGift = (EatingGift)program.EatingGiftStorage.GetRandomItem();
        }
        public override void SetToy()
        {
            Gift.Toy = (Toy)program.BoyToyStorage.GetRandomItem();
        }

        public override void SetWish()
        {
            Gift.Wish = (Wish)program.WishStorage.GetRandomItem();
        }
    }
    public class GirlRandomGiftBuilder : GiftBuilder
    {
        public GirlRandomGiftBuilder(ChoosingGiftProgram program) : base(program)
        {

        }
        public override void SetEatingGift()
        {
            Gift.EatingGift = (EatingGift)program.EatingGiftStorage.GetRandomItem();
        }

        public override void SetToy()
        {
            Gift.Toy = (Toy)program.GirlToyStorage.GetRandomItem();
        }

        public override void SetWish()
        {
            Gift.Wish = (Wish)program.WishStorage.GetRandomItem();
        }
    }

    public class BadKidGiftBuilder : GiftBuilder
    {
        public BadKidGiftBuilder(ChoosingGiftProgram program): base(program)
        {

        }

        public override void SetEatingGift()
        {
            Gift.EatingGift = null;
        }

        public override void SetToy()
        {
            Gift.Toy = new Toy("Willow");
        }

        public override void SetWish()
        {
            Gift.Wish = new Wish("Be more polite");
        }
    }
    public class GirlGiftBuilder : GiftBuilder
    {
        public GirlGiftBuilder(ChoosingGiftProgram program) : base(program)
        {

        }
        public override void SetEatingGift()
        {
            Gift.EatingGift = (EatingGift)program.EatingGiftStorage.GetNextItem();
        }

        public override void SetToy()
        {
            Gift.Toy = (Toy)program.GirlToyStorage.GetNextItem();
        }

        public override void SetWish()
        {
            Gift.Wish = (Wish)program.WishStorage.GetNextItem();
        }
    }
    public class BoyGiftBuilder : GiftBuilder
    {
        public BoyGiftBuilder(ChoosingGiftProgram program) : base(program)
        {

        }

        public override void SetEatingGift()
        {
            Gift.EatingGift = (EatingGift)program.EatingGiftStorage.GetNextItem();
        }
        public override void SetToy()
        {
            Gift.Toy = (Toy)program.BoyToyStorage.GetNextItem();
        }

        public override void SetWish()
        {
            Gift.Wish = (Wish)program.WishStorage.GetNextItem();
        }
    }
}
