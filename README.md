# SnowBoardReview
A concise program using Visual Studio, SQL, and EF that allows the user to view detailed information on well known snowboard brands as well as Add, Edit, Delete user comments submitted in the form of a review.

# Build Process
The first step in the process was to setup a .Net Core Web Application from scratch.

The next step was to determine our story card priority for our sprints through the Grooming process in Agile.

We then added the MVC model for our Category (Snowboard) and our product brands (Burton, K2, and Mark's).  This included adding the Controllers, Models, and Views for our project.

Context and Interface were created to seed our database thru SQL. It was critical to ensure that our relationship for our project was correct (One to Many)

Models, Controllers, and Views were done correctly and we added HTML and CSS to style our Views.

CRUD application was then added so the User can Add, Edit and Delete a review while viewing a snowboard.

The final step was to add Tests ( Yes, this should have happened earlier!!) to enure our methods were correct (i.e. Is the program pulling the correct Snowboard ID for a User to add a review).

# End Result

The User can logically navigate through the following items:

* List of all Product reviews
* Details for a Product review
* List of all Product categories
* Details for a Product category, with a list of all Product reviews that fall under that category
* Ability to add a Product review
* Ability to edit a Product review
* Ability to delete a Product review




