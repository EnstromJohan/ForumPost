namespace Methods
{
    public class UserInteraction
    {

        public (string title, string description) GetPostDetails()
        {
            string title = "";
            string description = "";

            try
            {

                while (string.IsNullOrWhiteSpace(title))
                {
                    Console.WriteLine("Enter the title: ");
                    title = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(title))
                    {
                        Console.WriteLine("Title cannot be empty. Please try again.");
                    }
                }

                while (string.IsNullOrWhiteSpace(description))
                {

                    Console.WriteLine("Enter the description");
                    description = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(description))
                    {
                        Console.WriteLine("Description cannot be empty. Please try again.");
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while getting post details: {ex.Message}");
            }
            return (title, description);
        }

        public void DisplayPostList(List<Post> posts)
        {
            try
            {


                Console.WriteLine("=== Posts ===");
                for (int i = 0; i < posts.Count; i++)
                {
                    Console.WriteLine($"{i}. {posts[i].GetTitle()}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error displaying the post list: {ex.Message}");
            }
        }

        public int AskForPostIndex(List<Post> posts)
        {
            Console.WriteLine("Enter the index of the post you want to view: ");
            int index = -1;

            while (index < 0 || index >= posts.Count)
            {
                try
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

                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                }

            }

            return index;
        }

        public bool AskForVote()
        {
            while (true)
            {
                try
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

                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                }

            }
        }
    }
}