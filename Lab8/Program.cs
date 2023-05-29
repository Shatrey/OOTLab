using Lab8;

var pizza = new Pizza();
var cheesePizza = new CheeseDecorator(pizza);

var foodAdapter = new FoodAdapter(cheesePizza);

var chief = new Chief();
chief.Prepare(foodAdapter);