using System;
using System.Collections.Generic;

namespace Task11
{
    public delegate GiftBuilder ChooseGiftBuilderDelegate(ISaintNicholasRequest request,ChoosingGiftProgram program);
    public class ChoosingGiftProgram
    {
        public event ChooseGiftBuilderDelegate ChooseGiftBuilder;
        public ItemStorage BoyToyStorage { get; private set; }
        public ItemStorage GirlToyStorage { get; private set; }
        public ItemStorage WishStorage { get;private set; }
        public ItemStorage EatingGiftStorage { get; private set; }
        public  RequestList Requests { get; private set; }
        public SaintNicholas SaintNicholas { get; private set; }

        ChoosingGiftProgram()
        {
            BoyToyStorage = new ToyStorage();
            GirlToyStorage = new ToyStorage();
            WishStorage = new WishStorage();
            EatingGiftStorage = new EatingGiftStorage();
            Requests = new RequestList();
            SaintNicholas = SaintNicholas.GetInstance();
        }
        

        
        public List<IGift> GetGifts()
        {
            List<IGift> list = new List<IGift>();
            foreach (var request in Requests)
            {
                list.Add(SaintNicholas?.CreateGift(ChooseGiftBuilder(request,this)));
            }
            return list;
        }


        static void Main(string[] args)
        {
            ChoosingGiftProgram program = new ChoosingGiftProgram();
            IFileReader reader = new FileReader();
            program.Requests.ParseList(reader.ReadFromFile(@"/Users/artemhuk/Desktop/Requests.txt"));
            program.BoyToyStorage.ParseStorage(reader.ReadFromFile(@"/Users/artemhuk/Desktop/Items/BoyToy.txt"));
            program.GirlToyStorage.ParseStorage(reader.ReadFromFile(@"/Users/artemhuk/Desktop/Items/GirlToy.txt"));
            program.WishStorage.ParseStorage(reader.ReadFromFile(@"/Users/artemhuk/Desktop/Items/Wishes.txt"));
            program.EatingGiftStorage.ParseStorage(reader.ReadFromFile(@"/Users/artemhuk/Desktop/Items/Food.txt"));
            program.ChooseGiftBuilder = GiftBuilderChooser.RandomChooseGiftBuilder;
            var list = program.GetGifts();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            program.ChooseGiftBuilder = GiftBuilderChooser.ChooseGiftBuilder;
            list = program.GetGifts();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
