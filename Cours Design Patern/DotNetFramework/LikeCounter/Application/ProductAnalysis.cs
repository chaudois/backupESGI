using System.Collections.Generic;

namespace LikeCounter
{
    public class ProductAnalysis : ILikeNumberProvider
    {
        private int likesNumber = 0;
        private List<ILikeCounter> counters=new List<ILikeCounter>();

        public void Add(ILikeCounter likeCounter)
        {
            counters.Add(likeCounter);
        }
 
        public void LikeProduct()
        {
            likesNumber++;
            foreach (var item in counters)
            {
                item.Update(likesNumber);
            }
        }

        public int GetNumberLikes()
        {
            return likesNumber;
        }
    }
}
