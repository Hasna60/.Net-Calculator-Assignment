using FirstApp;

FirstApp.Math math = new FirstApp.Math();

Console.WriteLine("Welcome to Math opration word :)");

Console.WriteLine("Pleaes Enter your first number:");
math.setFirstName(Console.ReadLine());

Console.WriteLine("Pleaes Enter your second number:");
math.setSecondtName(Console.ReadLine());

Console.WriteLine("Please choose on of the Math opration: Add, Minus, Divide, Multiply");
Console.WriteLine(math.getMathOpreation(Console.ReadLine()));
