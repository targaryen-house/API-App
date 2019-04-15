# API-App

# --------UNDER DEVELOPMENT-------- #

## Switchback ##

**"slogan here"**

## Developers ##

- Andrew *"Roketsu"* Roska (https://github.com/Roketsu86)

- Christopher *"Secret Squirrel"* Morton (https://github.com/cmorto02)

- Ian *"Hype Man"* Gifford (https://github.com/IanGifford261)

- Michael *"The Wizard"* Kelly (https://github.com/Michael-S-Kelly)

- Tanner *"SKNY-TannMann"* Percival (https://github.com/Tanner253)

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

- [] ---------UNDER DEVELOPMENT-------

- [] --------UNDER DEVELOPMENT--------

- [] --------UNDER DEVELOPMENT--------

- [] --------UNDER DEVELOPMENT--------

- API's
- [] --------UNDER DEVELOPMENT--------

- [] --------UNDER DEVELOPMENT--------

### How to set up locally ###

- Clone the repository onto your machine
   - Once Repo is cloned and set up within ```VS Community``` --------UNDER DEVELOPMENT--------

  --------UNDER DEVELOPMENT--------

### MVC User Stories ###

- As a User, I want to be able to navigate through different trails that I have searched for, so that I can find my best and safest route while having an enjoyable experience.
   - Features
      - Web App form that allows multiple types of input
      - Web App query the APIs for returned data and displays on results view.

   - Acceptance
      - Ensure search parameters are able to be pulled with valid keywords
      - Ensure the query returns valid data


- As a User, I would like to know the weather conditions where I am going to chose my trail.
   - Features
      - Details view to query weather API with location for weather
      - Details view will show weather for trail

   - Acceptance
      - Ensure API key from weather API is valid and returns needed data
      - Ensure that data is rendered properly to be shown on view 

- As a User, I would like to share my feedback and rating of the trails I have visited, so that other users are well informed of actual current trail conditions.
   - Features
      - Add user comments
      - Add user Ratings
      - View both

   - Acceptance
      - Ensure that a particular user can comment and verify that it is added to the trail
      - Ensure that the relevant number of user comments (chronologically) are displayed on the site.

- As a Developer, I want to be able to get and push trail information between the MVC web application and the API.
   - Features
      - Query Trails on the API
      - Update trail information on API
      - Add trails to the API
      - Add user ratings

   - Acceptance
      - Populate a particular trail with key search words
      - Ensure that when an update is entered, it is found on that entry
      - Ensure that added trail entries/user ratings are added to the API as well (communication between API and MVC)


- As a User, I want a streamlined site that is easy to understand and obvious to navigate through without prompts.
   - Features
      - Large easy to read thumbnails, in results view
      - Simplified, useful Navigation bar

   - Acceptance
      - Ensure site buttons and features are all running through manual usage
      - Ensure every route is valid, and every page renders all data as request and returned. 


### API APP user stories ###

- As an API User, I would like to utilize an API that pulls relevant trail information.
   - Features
      - Set search query item and sent all relevant data in JSON format

   - Acceptance
      - Ensure that the API is able to receive a query from the website
      - Ensure that the API is able to send appropriate data in JSON format
      - Ensure that the queried site is able to receive the JSON information 

- As an API User, I would like to store a rating about particular trails that users apply a rating too.
   - Features
      - Accept web app posts to aggregate rating table
      - Send info back to view for update

   - Acceptance
      - Ensure that the API is able to receive rating from querying site
      - Ensure that the average rating is adjusted appropriately

- As an API User, I would like to be able to average the ratings about specific trails, that allows the users an easy comparison.
   - Features
      - Return query Lat/Long to querying website for trail entrance
      - Return query Lat/Long to querying website for trail endpoint
   
   - Acceptance
      - Ensure queried beginning Lat matches expected beginning Lat
      - Ensure queried beginning Long matches expected beginning Long
      - Ensure queried ending Lat matches expected ending Lat
      - Ensure queried ending Long matches expected ending Long


- As an API user,  I would like to POST new trails to the API database.
   - Features
      - Allow post to API with minimum required data for new trail

   - Acceptance
      - Ensure API recieves the data passed to it for a new trail
      - Ensure received data is posted to API database


- As an API User, I want to be able to update trail conditions in the API Database.
   - Features
      - Allow post to API database with trailID and condition field 

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

![Database ERD Diagram](https://github.com/targaryen-house/API-App/tree/master/assets/API_ERD.png)

### API Endpoints and Call/Response Sample ###

- Example call:

# --------UNDER DEVELOPMENT-------- #
