using System;
namespace Task11
{
    public static class GiftBuilderChooser
    {
       
        public static GiftBuilder RandomChooseGiftBuilder(ISaintNicholasRequest request, ChoosingGiftProgram program)
        {
            GiftBuilder builder;
            if (request.GoodDeeds - request.BadDeeds > 0)
            {
                switch (request.Sex)
                {
                    case Sex.Male:
                        builder = new BoyRandomGiftBuilder(program);
                        break;
                    default:
                        builder = new GirlRandomGiftBuilder(program);
                        break;
                }
            }
            else
            {
                builder = new BadKidGiftBuilder(program);
            }
           
            switch (request.Sex)
            {
                case Sex.Male:
                    builder = new BoyGiftBuilder(program);
                    break;
                default:
                    builder = new GirlGiftBuilder(program);
                    break;
            }
            
            return builder;
        }
        public static GiftBuilder ChooseGiftBuilder(ISaintNicholasRequest request, ChoosingGiftProgram program)
        {
            GiftBuilder builder;
            switch (request.Sex)
            {
                case Sex.Male:
                    builder = new BoyGiftBuilder(program);
                    break;
                default:
                    builder = new GirlGiftBuilder(program);
                    break;
            }

            return builder;
        }
    }
    
}

