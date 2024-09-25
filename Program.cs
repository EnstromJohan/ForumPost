using Methods;

UserInteraction ui = new UserInteraction();
List<Post> posts = new List<Post>();
MenuHandler menuHandler = new MenuHandler(ui, posts);

menuHandler.ShowMenu();

