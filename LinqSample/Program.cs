// See https://aka.ms/new-console-template for more information

// Datasource
List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Mixed syntax
int query = (from num in numbers
             where num > 5 && num < 10
             select num).Count();
//result: 4
Console.WriteLine("Simple query");
Console.WriteLine(query);

//Zip
LinqSample.Zip.Sample_Zip_Lambda();
//Concat
LinqSample.Concat.Sample_Concat_Lambda_Strings();

//OrderBy
LinqSample.Ordering.Sample_OrderBy_Lambda_Objects();

//Conversion
LinqSample.Conversion.Sample_AsEnumerable_Lambda();

//Cast
LinqSample.Conversion.Sample_Cast_Lambda();

//Element
LinqSample.Element.Sample_SingleOrDefault_Lambda();
