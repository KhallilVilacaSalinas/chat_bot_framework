using Microsoft.Bot.Builder;
using System;
using Microsoft.Bot;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.Bot.Schema;
using System.Threading.Tasks;

namespace demo1.Bots
{
    public class SimpleBot : IBot
    {
        public async Task OnTurnAsync(ITurnContext turnContext, CancellationToken cancellationToken = default)
        {
            if (turnContext.Activity.Type is ActivityTypes.Message)
            {
                string input = turnContext.Activity.Text;
                string resposta = "";
                switch (input) 
                {
                    case "Olá Jarvis" :
                        resposta = "Eai seu gordo Bola, vai comer de novo é?";
                        break;
                    case "Sim, prq?" :
                        resposta = "Rolha gorda!";
                        break;
                }

                await turnContext.SendActivityAsync(resposta);
            }
        }
    }
}
