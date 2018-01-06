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
            MessageQueue messageQueue = new MessageQueue(".\\Private$\\myQueue");
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
