﻿namespace Ve.Metrics.StatsDClient
{
    public interface IStatsdConfig
    {
        string Host { get; }
        string Datacenter { get; }
        int Port { get; }
        string AppName { get; }
    }

    public class StatsdConfig : IStatsdConfig
    {
        private const string DefaultHost = "localhost";
        private const int DefaultPort = 8125;

        private int _port;
        private string _host;

        public string Host
        {
            get
            {
                return string.IsNullOrEmpty(_host) ? DefaultHost : _host ;
            }
            set
            {
                _host = value;
            }
        }

        public string Datacenter { get; set; }

        public int Port
        {
            get
            {
                return _port == 0 ? DefaultPort : _port;
            }
            set
            {
                _port = value;
            }
        }

        public string AppName { get; set; }
    }
}