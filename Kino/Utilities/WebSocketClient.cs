using System;
using System.Threading;
using System.Windows.Forms;
using Kino.Models;
using PusherClient;

namespace Kino.Utilities
{
    public class WebSocketClient
    {
        private Pusher _pusher;
        private Channel _myChannel;
        private int _minId = int.MaxValue;
        private int _id = 0;
        private bool _foundCoordinator = false;
        public async void Connect()
        {
            _pusher = new Pusher("6f6586ea2b39f7d8e6e1", new PusherOptions(){
                Cluster = "eu"
            });
            _pusher.ConnectionStateChanged += pusher_ConnectionStateChanged;
            _pusher.Error += pusher_Error;

            await _pusher.ConnectAsync();
        }
        
        public async void Subscribe(int seanceId)
        {
            _myChannel = await _pusher.SubscribeAsync(seanceId.ToString());
            
            _myChannel.Bind("ping", data =>
            {
                Reset();
                if (data.data != Cache.User.Id)
                {
                    Cache.WsServer.Answer(seanceId);
                }
            });
            
            _myChannel.Bind("answer", data =>
            {
                var userId = ((Queue) data.data).UserId;
                _minId = Math.Min(_minId, userId);

                if (Cache.Queue == null)
                {
                    if (userId >= _id)
                    {
                        _id = userId + 1;
                    }
                    
                    Thread.Sleep(5000);
                    var queue = new Queue {UserId = _id, Coordinator = false};
                    Cache.Queue = queue;
                }
                if (((Queue) data.data).Coordinator)
                {
                    _foundCoordinator = true;
                }
                Thread.Sleep(1000);
                if (!_foundCoordinator)
                {
                    //elekcja
                    if (_minId == Cache.Queue.UserId)
                    {
                        Cache.Queue.Coordinator = true;
                    }
                }
            });
        }

        private static void pusher_Error(object sender, PusherException error)
        {
            MessageBox.Show(error.Message);
        }

        private static void pusher_ConnectionStateChanged(object sender, ConnectionState state)
        {
            MessageBox.Show(state.ToString());
        }

        private void Reset()
        {
            _minId = int.MaxValue;
            _id = 0;
        }
    }
}