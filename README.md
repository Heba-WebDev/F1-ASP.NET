# Formula One API

This ASP.NET Core API allows you to manage Formula One teams using SQLite as the database. It provides endpoints for retrieving, creating, updating, and deleting team information.

## Technologies

ASP .NET Core - Entity Framework - Sqlite

## Endpoints

### Get all teams

#### URL: /api/teams

Method: GET

- Description: Retrieves a list of all Formula One teams.
- Response: Returns an array of team objects.
- Get a specific team

#### URL: /api/teams/{id}

Method: GET

- Description: Retrieves details for a specific team based on its ID.
- Parameters: {id}: The unique identifier for the team.
- Response: Returns the team object if found, or a “Team not found” message if not.
- Create a new team

#### URL: /api/teams

Method: POST

- Description: Creates a new Formula One team.
- Request Body: Provide a JSON object with team details (e.g., name, country).
- Response: Returns the newly created team object.

#### URL: /api/teams

Method: PATCH

- Description: Updates the country of an existing team.
- Parameters:
  // id: The unique identifier for the team.
  // country: The new country value.
- Response: Returns a success message or a “Team not found” message if the team doesn’t exist.

#### URL: /api/teams

Method: DELETE

- Description: Deletes an existing Formula One team.
- Parameters:
  // id: The unique identifier for the team.
- Response: Returns a success message or a “Team not found” message if the team doesn’t exist.
