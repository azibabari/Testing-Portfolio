Feature: Book API Testing
  As a consumer of the book API
  I want to verify the response status code and its content

  Scenario: Verify API response
    Given I make a request to the book API
    Then the response status code should be 200
    And the response body should contain id, name, availability, and type of books