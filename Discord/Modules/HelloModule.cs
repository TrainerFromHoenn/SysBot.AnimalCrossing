using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace SysBot.AnimalCrossing 
{
    public class HelloModule : ModuleBase<SocketCommandContext> 
    {
        [Command("hi")]
        [Summary("The bot says hi.")]
        public async Task PingAsync()
        {
            var msg = string.Format ("Oh, che bello vederti {0}, br-br-brr!", Context.User.Mention);
            await ReplyAsync(msg).ConfigureAwait(false);
        }
    }
}