# APA-App
APA Application
  This application allows current members, division reps, and admins of the American Poolplayers Association, perform CRUD operations. The login page performs a query on the DivisionReps table and Players table to look for the matching email and password of the values in the login email and login password text boxes. If there is no match, the user is informed. If there is a match, the user is then presented with a different form, depending on their status. If the user knows they are not in the database, the user can click on a register link label and provide their information. Upon clicking the register button, the max player number is found in the Players table and then incremented by one and the user is given the status of "Player" and the user's team number and division number is set to zero, before changes are saved to the database. Classes have also been implemented to perform the majority of the queries that repeat.
  If the user logs in with admin credentials, the user is then able to view data from the Players table, Teams table, and DivisionReps table in a data grid view. The user is also able to select a cell in the data grid view and change the information and save those changes to the database when the user clicks on the update button. The user can select one row or many rows and click on the delete button to delete those rows from the data base before saving changes. The database is then reflected with these changes.
  If the user logs in with a "Player" status, the user is then presented with a personalized Player form that displays the user's personal information, payment information, league information and their team information. The user can edit any information in their personal information and their payment information. To ensure that the user cannot edit their league information and their team information, the properties have been set to be read only.
  If the user logs in with a "Captain" status, the user is then presented with a personalized Captain form. This form allows the user to click View on the menu to view their profile, which has their personal information and their payment information, that the user can update and save changes to the data base when the user clicks the update button. The user can also View their league information which the user cannot change. The user can also View their team information including a roster of players on the user's team, which the user cannot change. However, the user can select a row or multiple rows and remove those players from their roster when clicking the delete player. The players are not deleted from the database but rather the selected player's team number and division number is set to zero and the changes are saved to the database. The user can also View players without a team in the same state. From here, the user can select a player and click on the add player button to have the selected player's team number and division number to be changed to the same team number and division number as the user's.
  If the user's login email and login password matches an email and password in the DivisionReps table, the user is then presented with a personalized form. The user can View their personal information as well as update their personal information and save the updated changes to the database once they click on the update info button. The user can also View their division info, such as teams, players, and captains. When the user selects to View teams, they are then presented with a new tab that shows a data grid view of all of the teams in the user's division. The user can update team information and save changes by clicking the update team button. The user can also remove a team by selecting a team's row in the data grid view and clicking the delete team button to remove the team from the database. The user can view all players and captains in their division but currently do not have any options to update or delete players or captains.
  The Scoresheet feature, from the Captains form, is currently in the design and coding process.