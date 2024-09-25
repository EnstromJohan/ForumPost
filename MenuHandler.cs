namespace Methods
{
    public class MenuHandler
    {
        private readonly UserInteraction _ui;
        private readonly List<Post> _posts;

        public MenuHandler(UserInteraction ui, List<Post> posts)
        {
            _ui = ui;
            _posts = posts;
        }

        public void ShowMenu()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("=== Menu ===");
                Console.WriteLine("1. Add a post");
                Console.WriteLine("2. View post details");
                Console.WriteLine("3. Vote on a post");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice (1-4)");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddPost();
                        break;
                    case "2":
                        ViewPostDetails();
                        break;
                    case "3":
                        VoteOnPost();
                        break;
                    case "4":
                        isRunning = false;
                        Console.WriteLine("Exiting the program.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1-5.\n");
                        break;
                }


            }
        }

        private void AddPost()
        {
            var (title, description) = _ui.GetPostDetails();
            Post post = new Post(title, description, DateTime.Now, 0);
            _posts.Add(post);
            Console.WriteLine("Post added successfully!\n");
        }

        private int SelectPost()
        {
            if (_posts.Count > 0)
            {
                _ui.DisplayPostList(_posts);
                return _ui.AskForPostIndex(_posts);
            }

            else
            {
                Console.WriteLine("No posts available.\n");
                return -1;
            }
        }

        private void ViewPostDetails()
        {
            int index = SelectPost();
            if (index >= 0)
            {
                _posts[index].DisplayPost();
            }
        }

        private void VoteOnPost()
        {
            int index = SelectPost();
            if (index >= 0)
            {
                bool isUpVote = _ui.AskForVote();
                _posts[index].VoteOnPost(isUpVote);
                Console.WriteLine($"Current vote count for post: {_posts[index].GetVoteCount()}\n");
            }
        }
    }
}
