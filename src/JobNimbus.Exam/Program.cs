using JobNimbus.Exam;

Console.Write("Please enter input with angle brackets: ");
var input = Console.ReadLine();

if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("Input is required.");
    return;
}

var angleBracketValidator = new AngleBracketValidator();
var isValid = angleBracketValidator.Validate(input);

Console.WriteLine("input is {0}", isValid ? "Valid": "Not Valid");  
 