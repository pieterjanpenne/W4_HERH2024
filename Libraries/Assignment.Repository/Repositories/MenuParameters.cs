using Assignment.Core.Helpers;

namespace Assignment.Repository.Repositories;

public class MenuParameters : QueryStringParameters
{
    public MenuParameters()
    {
        OrderBy = "Price";
    }
}
