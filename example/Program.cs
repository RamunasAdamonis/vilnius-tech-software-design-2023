// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// var test = new Test(number: 1);
// var test2 = new Test(number: 2);

// test.Fly();
// test2.Fly();

// var x = test.Number2;
// test.SetNumber(number: -1);


// var user = new User();

// // user.Name
// var admin = new Admin();


var user = new User();
var admin = new Admin();


var users = new List<User>
{
    user, admin
};

foreach (var person in users)
{
    person.Greet();
}



