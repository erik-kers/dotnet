string firstName;
// error CS0165: Use of unassigned local variable 'firstName'
// Console.WriteLine(firstName);

// error CS0131: The left-hand side of an assignment must be a variable, property or indexer
// string firstName;
// "Bob" = firstName;

// error CS0029: Cannot implicitly convert type 'string' to 'int'
// int lastName
// lastName = "Svensson"

firstName = "Bob";
Console.WriteLine(firstName);
firstName = "Liem";
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Yasmin";
Console.WriteLine(firstName);

