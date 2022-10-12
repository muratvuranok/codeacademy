using RabbitMQ.Client;
using System.Text;
using System.Text.Json;

const string queue_name = "code-queue";

var factory = new ConnectionFactory
{
    HostName = "localhost",
    Uri = new Uri("amqp://guest:guest@localhost:5672")
};

using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();


channel.QueueDeclare(queue_name, durable: true, exclusive: false, autoDelete: false, arguments: null);

int i = 0;


while (true)
{
    var message = new { Name = "Producer", Message = $"Console Message -> Code Academy ", MessageId = i };

    i++;
    var body 
        = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(message));
    channel.BasicPublish("", queue_name, null, body);
    Console.WriteLine("Message Sended");
}
