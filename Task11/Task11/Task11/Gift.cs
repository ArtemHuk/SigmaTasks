using System;
namespace Task11
{
    public class Gift:IGift
    {
        public Item Toy { get; set; }
        public Item EatingGift { get; set; }
        public Item Wish { get; set; }

        public override string ToString()
        {
            return Toy?.ToString()+"\n"+EatingGift?.ToString()+"\n"+Wish?.ToString()+"\n";
        }
    }
}
