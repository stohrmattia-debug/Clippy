using Clippy.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Clippy.Core.Services
{
    public sealed class OpenAIChatService : IChatService
    {
        private readonly string _apiKey;
        private readonly string _model;

        public OpenAIChatService(string apiKey, string model = "gpt-5.2")
        {
            _apiKey = apiKey;
            _model = model;
        }

        public Task<string> SendChatAsync(IEnumerable<IMessage> messages)
        {
            // TODO: chiama OpenAI Responses/Chat e ritorna testo completo
            throw new System.NotImplementedException();
        }

        public async IAsyncEnumerable<string> StreamChatAsync(
            IEnumerable<IMessage> messages,
            [System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            // TODO: chiama OpenAI in streaming e fai yield dei chunk di testo
            yield return "Implementazione streaming qui";
            await Task.CompletedTask;
        }
    }
}
