# API-App

# --------UNDER DEVELOPMENT-------- #

# Switchback #

## **["Venture Into The Known"](https://switchback.azurewebsites.net/)**

## Developers ##

- [Andrew *"Roketsu"* Roska](https://github.com/Roketsu86)

- [Christopher *"Secret Squirrel"* Morton](https://github.com/cmorto02)

- [Ian *"Hype Man"* Gifford](https://github.com/IanGifford261)

- [Michael *"The Wizard"* Kelly](https://github.com/Michael-S-Kelly)

- [Tanner *"SKNY-TannMann"* Percival](https://github.com/Tanner253)

## About Switchback ##
### Version 1.0 ###

--------UNDER DEVELOPMENT--------

### Problem Domain ###

--------UNDER DEVELOPMENT--------

## Libraries/API's/Dev environments-Dev Tools
- Libraries
- [X] VS Community

- [X] Azure/DevOps

- [X] MVC Framework

   - [] --------UNDER DEVELOPMENT--------

- API's
- [X] [Switchback API](https://github.com/targaryen-house/API-App)

- [X] [OpenWeather](https://openweathermap.org/api)

### How to set up locally ###

- Clone the repository onto your machine
   - Once Repo is cloned and set up within ```VS Community``` --------UNDER DEVELOPMENT--------

  --------UNDER DEVELOPMENT--------


### API APP user stories ###

- As an API User I would like the API to return all hikes relevant to my search query.
   - Features
      - Accept and parse incoming search query
      - Convert search query into lat-long
      - Query hikingdb API for all hikes in range of lat-long
      - Compare response to current DB
      - Return results to Web app

   - Acceptance
      - Ensure that the API is able to receive a query from the website
      - Ensure that the queried site sends correct JSON information back
      - Ensure that the API is able to send appropriate data to web app in JSON format

- As an API Developer I would like to store ratings about each trail that is supplied by users.
   - Features
      - Accept and parse incoming rating for the trail by ID
      - Add the rating to the ratings table attached by FK to the appropriate trail ID
      - Add ratings via FK to all trail queries

   - Acceptance
      - Ensure that the API is able to receive rating from querying site
      - Ensure that the rating data is correctly included in trail details

- As an API Developer I would like to be able to average the ratings about specific trails so that users can retrieve the average rating.
   - Features
      - Retrieve all unique ratings for each trail by ID
      - Average all unique ratings and update the table accordingly
      - Add average rating via FK to all trail queries 
      - Return updated average rating for indicated trail ID
   
   - Acceptance
      - Ensure table is updated with current average rating at all times
      - Ensure correct average rating is returned to users

- As an API user I would like to POST new trails to the API database so that future API users can find my added trails.
   - Features
      - Accept incoming POST route and parse data
      - Check DB for duplicate entry
      - Add the data to DB
      - Return newly added trail data details

   - Acceptance
      - Ensure API recieves the data passed to it for a new trail
      - Ensure received data is posted to API database

- As an API User I want to be able to update trail conditions in the API Database so that future users of the API can see the most recent trail conditions when DB is queried.
   - Features
      - Accept incoming POST route to the ID of the trail in question and parse data
      - Update the correct row in the table for the condition reported
      - Return updated trail data

   - Acceptance
      - Ensure that given a trail ID the API can receive updates to the conditions field
      - Ensure that the conditions data is posted to the API database

### Database Entity Relationship Diagram(ERD)

Our API will connect to a SQL database with two tables.  The first table will store locally cached data for all hiking trails in our system, including:
- Trail Name
- Trail Head Latitude and Longitude
- Trail Tail Latitude and Longitude (If present)
- GeoMap URL
- Trail Difficulty
- Trail Details
- Trail Conditions

The second table will store User Ratings.  Each user will be be able to rate a trail on a scale of 1 - 5, and the API will store all individual ratings as well as one aggregate score for each trail.

![Database ERD Diagram](https://github.com/targaryen-house/API-App/blob/dev-branch/assets/API_ERD.png)

### API Endpoints and Call/Response Sample ###

- Example call:

# --------UNDER DEVELOPMENT-------- #
