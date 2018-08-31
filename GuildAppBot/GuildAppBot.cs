using DSharpPlus;
using System;
using System.Threading.Tasks;

namespace GuildAppBot
{
    class GuildAppBot
    {
        static DiscordClient discord;

        static void Main(string[] args)
        {
            MainAsync(args).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        static async Task MainAsync(string[] args)
        {
            discord = new DiscordClient(new DiscordConfiguration
            {
                Token = "NDg1MTUwOTg4NDU0NTkyNTEz.DmsavA.l-2NXqeELBF3RzBxEHNnDMs2Oc0",
                TokenType = TokenType.Bot
            });
            discord.MessageCreated += async e =>
            {
                if (e.Message.Content.ToLower().StartsWith("ping"))
                    await e.Message.RespondAsync("pong!");
            };

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}
