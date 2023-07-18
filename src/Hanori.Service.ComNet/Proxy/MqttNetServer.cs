using MQTTnet.Server;
using MQTTnet;
using System.Text;
using MQTTnet.Client;
using MQTTnet.Adapter;

namespace Hanori.Service.ComNet.Proxy
{
    public class MqttNetServer
    {
        private static CancellationTokenSource MqttCTS;

        public static async Task Start()
        {
            MqttCTS = new CancellationTokenSource();
            await StartMqttNetServerTask(MqttCTS.Token);
        }

        public static async Task StartMqttNetServerTask(CancellationToken cancellationToken)
        {
            var mqttServerOptions = new MqttServerOptionsBuilder()
                .WithDefaultEndpoint()
                .WithDefaultEndpointPort(1883)
                .Build();

            //IMqttServerAdapter mqttServer = new MqttFactory().CreateMqttServer();

            //mqttServer.ApplicationMessageReceived += MqttServer_ApplicationMessageReceived;

            //await mqttServer.StartAsync(mqttServerOptions, cancellationToken);
            //Console.WriteLine("MqttNetServer started.");

            //await mqttServer.WaitForStopAsync(cancellationToken);
        }

        private static void MqttServer_ApplicationMessageReceived(object sender, MqttApplicationMessageReceivedEventArgs e)
        {
            Console.WriteLine($"Received message on topic: {e.ApplicationMessage.Topic}. Message: {Encoding.UTF8.GetString(e.ApplicationMessage.Payload)}");
        }
    }
}
