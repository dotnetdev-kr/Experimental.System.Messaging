using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Experimental.System.Messaging.Test
{
    [TestClass]
    public class QueueClientTest
    {
        [TestMethod]
        public void SendMessage()
        {
            Order sentOrder = new Order
            {
                OrderId = 3,
                OrderTime = DateTime.Now
            };

            MessageQueue myQueue = new MessageQueue(".\\Private$\\myQueue");
            myQueue.Send(sentOrder);
        }

        [TestMethod]
        public void ReceiveMessage()
        {
            string path = ".\\Private$\\myQueue";
            // Ensure the queue exists to make test independent
            if (!MessageQueue.Exists(path))
            {
                MessageQueue.Create(path);
            }

            MessageQueue messageQueue = new MessageQueue(path);
            messageQueue.Formatter = new XmlMessageFormatter(new Type[1]
            {
                typeof(Order)
            });

            MessageQueue myQueue = messageQueue;
            Message myMessage = myQueue.Receive();
            Order myOrder = (Order)myMessage.Body;
            Console.WriteLine("Order ID: " + myOrder.OrderId.ToString());
            Console.WriteLine("Sent: " + myOrder.OrderTime.ToString());
        }
    }
}
