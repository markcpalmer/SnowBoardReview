# SnowBoardReview
A concise program using Visual Studio, SQL, and EF that allows the user to view detailed information on well known snowboard brands as well as Add, Edit, Delete user comments submitted in the form of a review.

# Build Process
The first step in the process was to setup a .Net Core Web Application from scratch.

The next step was to determine our story card priority for our sprints through the Grooming process in Agile.

The MVC model was added for Category (Snowboard) and product brands (Burton, K2, and Mark's).  Folders were added for Controllers, Models, and Views.

Context and an Interface were created to seed the database using SQL. It was critical to ensure that the relationship for the project was correct (One to Many for this instance).

HTML and CSS was added to style the Views shown.

CRUD application was then added so the User can Add, Edit and Delete a review while viewing a snowboard.

The final step included adding Tests to our project( Yes, this should have happened earlier!!) to enure our methods were correct (i.e. Is the program pulling the correct Snowboard ID for a User to add a review).

# End Result

The User can logically navigate through the following items:

* List of all Product reviews
* Details for a Product review
* List of all Product categories
* Details for a Product category, with a list of all Product reviews that fall under that category
* Ability to add a Product review
* Ability to edit a Product review
* Ability to delete a Product review




