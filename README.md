# ForumPost

This application is a command-line application, It allows users to add, view, and vote on posts in a simple, interactive menu-driven interface. 
The project demonstrates key object-oriented programming, principles, clean code practices, and fundamental design patterns.

Key Features
	-- Add new posts with titles and descriptions.
	-- View a list of posts with vote counts and creation dates.
	-- Upvote or downvote posts.
	-- Simple and intuitive command-line interface.

Techniques and Concepts:
	-- Object-Oriented Programming (OOP): The project leverages classes (Post, UserInteraction, MenuHandler) to encapsulate logic and data, ensuring modularity and reusability.
	-- Separation of Concerns (SoC): Responsibilities are divided among classes—Post handles post data, UserInteraction manages I/O, and MenuHandler oversees program flow.
	-- Input Validation: Ensures that user input, such as post titles and vote selections, is validated, improving the user experience and reliability.
	-- Collection Management: Uses List<Post> to store and manage posts, demonstrating collection handling and iteration.

Design Patterns:
	-- Single Responsibility Principle (SRP): Each class handles a distinct responsibility, improving code clarity and maintainability.
	-- Facade Pattern: MenuHandler provides a simplified interface for interacting with the system functions.
	-- Command Pattern (Variant): Methods like AddPost(), ViewPostDetails(), and VoteOnPost() encapsulate specific user commands, organizing the system's flow.

This project showcases basic software development principles in a small, manageable system, making it easy to extend or adapt for more complex features in the future.