using System;

namespace Exercise2
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateTimeCreated { get; set; }
        private int _voteScore;

        public Post()
        {
            Title = "Untitled";
            Description = "No description.";
            DateTimeCreated = DateTime.Now;
            _voteScore = 0;
        }

        public void Upvote()
        {
            _voteScore++;
        }

        public void Downvote()
        {
            _voteScore--;
        }

        public int GetVoteScore()
        {
            return _voteScore;
        }
    }
}
