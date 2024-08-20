// Specify the data source.
int[] scores = {97, 92, 81, 60, 100, 24, 3000, 1 };

// Define the query expression.
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80
    orderby score descending
    select score;

// Execute the query.
foreach (var i in scoreQuery)
{
    Console.Write(i + " ");
}

// Output: 97 92 81

var scoreQuery2 = scores.Where(s => s > 80).OrderByDescending(s => s);

foreach (var i in scoreQuery2)
{
    Console.Write(i + " ");
}