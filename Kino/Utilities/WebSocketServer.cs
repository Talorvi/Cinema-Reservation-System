using Kino.Models;
using Newtonsoft.Json;
using PusherServer;
using System;

namespace Kino.Utilities
{
    public class WebSocketServer
    {
        private Pusher _pusher;
        
        public WebSocketServer()
        {
            var options = new PusherOptions {Cluster = "eu"};

            _pusher = new Pusher("1104023", "6f6586ea2b39f7d8e6e1", "d1165e49f5ca5ce4f7be", options); 
        }

        public async void Test()
        {
            await _pusher.TriggerAsync("my-channel", "my-event", "test");
        }

        public async void Ping()
        {
            await _pusher.TriggerAsync($"{Cache.Seance.Id}", "ping", Cache.User.Id);
        }

        public async void Answer()
        {
            await _pusher.TriggerAsync($"{Cache.Seance.Id}", "answer", JsonConvert.SerializeObject(Cache.Queue));
        }
    }
}