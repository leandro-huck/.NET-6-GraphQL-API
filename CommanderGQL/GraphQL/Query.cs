using CommanderGQL.Data;
using CommanderGQL.Models;

namespace CommanderGQL.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        public IQueryable<Platform> GetPlatforms([ScopedService] AppDbContext context)
        {
            return context.Platforms;
        }
    }
}