namespace Methods
{
    public class UserInteraction
    {

        public (string title, string description) GetPostDetails()
        {
            string title = "";
            while (string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("Enter the title: ");
                title = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(title))
                {
                    Console.WriteLine("Title cannot be empty. Please try again.");
                }
            }

            string description = "";
            while (string.IsNullOrWhiteSpace(description))
            {

                Console.WriteLine("Enter the description");
                description = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(description))
                {
                    Console.WriteLine("Description cannot be empty. Please try again.");
                }
            }
            return (title, description);
        }

        public void DisplayPostList(List<Post> posts)
        {
            Console.WriteLine("=== Posts ===");
            for (int i = 0; i < posts.Count; i++)
            {
                Console.WriteLine($"{i}. {posts[i].GetTitle()}");
            }
        }

        public int AskForPostIndex(List<Post> posts)
        {
            Console.WriteLine("Enter the index of the post you want to view: ");
            int index = -1;

            while (index < 0 || index >= posts.Count)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out index) && index >= 0 && index < posts.Count)
                {
                    return index;
                }

                else
                {
                    Console.WriteLine("Invalid index. Please try again.");
                }
            }

            return index;
        }

        public bool AskForVote()
        {
            Console.WriteLine("Do you like this post? (Y/N)");
            string input = Console.ReadLine()?.ToLower();
            if (input == "y")
            {
                return true;
            }

            else if (input == "n")
            {
                return false;
            }

            else
            {
                Console.WriteLine("Invalid inout. Please enter Y or N");
                // handle recursive call to ensure valid input
                return AskForVote();
            }
        }

    }
}
