// See https://aka.ms/new-console-template for more information
using LambdaExpressionDay24;

Console.WriteLine("Hello, World!");

List<Person> listPersonInCity = new List<Person>();
LambdaExpression.AddRecords(listPersonInCity);
//Retrieving_TopTwoRecord_ForAgels_LessThanSixty(listPersonInCity);
LambdaExpression.CheckingForTeenagerPerson(listPersonInCity);
LambdaExpression.AllPersonsAverageAge(listPersonInCity);
LambdaExpression.CheckNameExistOrNot(listPersonInCity);
LambdaExpression.CheckNameforRemove(listPersonInCity);
LambdaExpression.Skiping_AllRecord_ForAgels_LessThanSixty(listPersonInCity);
Console.ReadKey();