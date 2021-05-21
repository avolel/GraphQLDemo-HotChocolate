using System;
using System.Collections.Generic;
using System.Linq;
using GraphQLDemo_HotChocolate.Data;
using System.Threading.Tasks;
using HotChocolate;

namespace GraphQLDemo_HotChocolate
{
    public class Query
    {
        public IQueryable<Speaker> GetSpeakers([Service] ApplicationDbContext context) => context.Speakers;
    } 
}
