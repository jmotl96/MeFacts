
using System.Collections.Generic;

namespace MeFacts
{
    public class MeFactsData
    {
        public MeFactsData()
        {
        }
        public static IEnumerable<MeFactsData> All { private set; get; }
        public string TheFact { get; set; }
        public string ShortFact { get; set; }
        static MeFactsData()
        {
            List<MeFactsData> all = new List<MeFactsData>();
            all.Add(new MeFactsData() { TheFact = "Cook is extreamly fun for me ", ShortFact = "I like to cook",});
            all.Add(new MeFactsData() { TheFact = "Gaming is what got me into IT in the first place", ShortFact = "Gaming" });
            all.Add(new MeFactsData() { TheFact = "I am on the sprecriom ", ShortFact = "autsiom" });
            all.Add(new MeFactsData() { TheFact = "My deam job is to be an astront", ShortFact = "Dream job" });
            all.Add(new MeFactsData() { TheFact = "I like Both", ShortFact = "Star Wars or star trek" });
            All = all;

        }
    }
}