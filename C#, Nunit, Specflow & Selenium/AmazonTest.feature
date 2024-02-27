Feature: Add TP-Link Router to Cart on Amazon

Scenario: Search for product, add to cart, and verify details

    Given I navigate to the Amazon homepage
    When I search for "TP-Link N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)"
    Then I verify the search results include the desired product
    When I select the first product matching the search term
    Then I am directed to the product details page
    And I verify the product title is "TP-Link N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)"
    And I verify the price is displayed as "$71.00" 
    When I click "See all buying options"
    Then I verify the "Add to Cart" button is available
    When I click "Add to Cart"
    Then I see a confirmation message indicating the product has been added to the cart
    When I navigate to the cart by clicking "View Cart"
    Then I verify the added item is "TP-Link N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)"
    And I verify the price is displayed as "$71.00"