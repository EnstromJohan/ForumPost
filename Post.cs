namespace Methods
{
    public class Post
    {
        private string? _title;
        private string? _description;
        private DateTime _created;
        private int _vote;
        public Post(string? title, string? description, DateTime created, int vote)
        {
            _title = title;
            _description = description;
            _created = created;
            _vote = vote;
        }


        bool isRunning = true;
        public void SetPostDetails(string title, string description)
        {
            _title = title;
            _description = description;
            //Reset creation date when the post is edited
            _created = DateTime.Now;
        }

        public void VoteOnPost(bool isUpVote)
        {
            _vote += isUpVote ? 1 : -1;
        }


        public int GetVoteCount()
        {
            return _vote;
        }

        public void DisplayPost()
        {
            Console.Clear();
            Console.WriteLine("=== Post details ===");
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Description: {_description}");
            Console.WriteLine($"Created: {_created}");
            Console.WriteLine($"Votes: {_vote}");

        }

        public string GetTitle()
        {
            return _title ?? "Untitled Post";
        }



    }
}
