Abstract Factory stufy based on the following Scenario: A Café serves tea and coffee. Both beverages are made through different apparatus modeled as factories. Focusing only on hot serving.

IHotDrink: interface to implement the Consume method that both main objects will use.

Coffee/Tea Factory: are necessary to 'Prepare' each type of drink.

[Not implemented]MakeDrink: Would take the name of a drink and simply make it, witching into cases.

IHotDrinkFactory: But, they're made by different machnery, so it's modeled in this Abstract Factory interface. 

It's a factory with a specific interface, but it's an abstract type, even featuring as a function argument, it needs concrete implementations to actually make the drinks. 
