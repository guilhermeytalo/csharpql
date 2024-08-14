namespace GraphQLDemo.API.Schema;

public class Query
{
    [GraphQLDeprecated("This query is depreciated")]
    public string Instructions => "Just a test!";
}