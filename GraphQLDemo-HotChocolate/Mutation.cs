using HotChocolate;
using GraphQLDemo_HotChocolate.Data;
using System.Threading.Tasks;

namespace GraphQLDemo_HotChocolate
{
    public class Mutation
    {
        public async Task<AddSpeakerPayload> AddSpeakerPayloadAsync(AddSpeakerInput input, [Service] ApplicationDbContext context)
        {
            var speaker = new Speaker
            {
                Name = input.Name,
                Bio = input.Bio,
                WebSite = input.WebSite
            };

            context.Speakers.Add(speaker);
            await context.SaveChangesAsync();

            return new AddSpeakerPayload(speaker);
        }
    }
}
