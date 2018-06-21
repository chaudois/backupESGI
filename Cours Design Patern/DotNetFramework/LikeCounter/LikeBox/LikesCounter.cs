using System;

namespace LikeCounter.LikeBox
{
    public class LikesCounter : ILikeCounter
    {
        private readonly ILikeNumberProvider likeNumberProvider;

        public LikesCounter(ILikeNumberProvider likeNumberProvider)
        {
            this.likeNumberProvider = likeNumberProvider;
        }



        public void Update(int likesNumber)
        {
            Console.WriteLine(likesNumber);
        }
    }
}
