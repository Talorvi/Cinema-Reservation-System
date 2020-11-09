using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kino.Models;
using Newtonsoft.Json;
using PusherClient;

namespace Kino.Utilities
{
    public class WebSocketClient
    {
        private Pusher _pusher;
        private Channel _myChannel;
        private List<int> _id = new List<int>();
        private bool _foundCoordinator = false;
        private bool _didAnswer = false;
        public Action Unlock { get; set; }
        public async void Connect()
        {
            _pusher = new Pusher("6f6586ea2b39f7d8e6e1", new PusherOptions(){
                Cluster = "eu"
            });
            _pusher.ConnectionStateChanged += pusher_ConnectionStateChanged;
            _pusher.Error += pusher_Error;
            await _pusher.ConnectAsync();
        }
        
        public async void Subscribe()
        {
            _myChannel = await _pusher.SubscribeAsync($"{Cache.Seance.Id}");
            Cache.WsServer.Ping();
            _myChannel.Bind("ping", data =>
            {
                Reset();
                if (data.data != Cache.User.Id)
                {
                    Cache.WsServer.Answer();
                }
                WaitForAnswer();
            });
            
            _myChannel.Bind("answer", data =>
            {
                _didAnswer = true;
                var _d = ((string)data.data).Trim('"').Replace("\\", "");
                var _que = JsonConvert.DeserializeObject<Queue>(_d);
                _id.Add(_que.UserId);
                if (_que.Coordinator)
                {
                    _foundCoordinator = true;
                }
            });
        }


        public void Unsubscribe()
        {
            Cache.Queue = null;
            Cache.WsServer.Ping();
            _myChannel.Unsubscribe();
        }
        public void Disconnect()
        {
            if (Cache.Queue != null)
            {
                Cache.Queue = null;
                Cache.WsServer.Ping();
            }
            _pusher.DisconnectAsync();
        }

        private static void pusher_Error(object sender, PusherException error)
        {
            Console.WriteLine(error.Message);
        }

        private static void pusher_ConnectionStateChanged(object sender, ConnectionState state)
        {
            Console.WriteLine(state.ToString());
        }

        private void Reset()
        {
            _id = new List<int>();
            _foundCoordinator = false;
            _didAnswer = false;
        }
        private async void WaitForAnswer()
        {
            await Task.Delay(1000);
            if (!_didAnswer)
            {
                Cache.Queue = new Queue() { Coordinator = true, UserId = 1 };
                Unlock();
            }
            else if (Cache.Queue == null)
            {
                Cache.Queue = new Queue { UserId = _id.Max() + 1, Coordinator = false };
            }
            else if (!_foundCoordinator)
            {
                if (_id.Min() == Cache.Queue.UserId)
                {
                    Cache.Queue.Coordinator = true;
                    Unlock();
                }
            }
        }
    }
}