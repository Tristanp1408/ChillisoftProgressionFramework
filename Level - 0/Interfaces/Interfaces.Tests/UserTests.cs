using Interfaces.Interfaces;
using Interfaces.Notification;
using NSubstitute;
using NUnit.Framework;

namespace Interfaces.Tests
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void Notify_ShouldSendNotificationToAllNotifiers()
        {
            var emailNotifier = Substitute.For<INotifier>();
            var smsNotifier = Substitute.For<INotifier>();
            var user = new User("Alice", [emailNotifier, smsNotifier]);
            var message = "You have a new message!";

            user.Notify(message);

            emailNotifier.Received(1).SendNotification("Alice, You have a new message!");
            smsNotifier.Received(1).SendNotification("Alice, You have a new message!");
        }

        [Test]
        public void NotifyWithPriority_ShouldSendNotificationToHighestPriorityNotifier()
        {
            // Arrange
            var emailNotifier = Substitute.For<INotifier>();
            emailNotifier.Priority.Returns(1);
            var smsNotifier = Substitute.For<INotifier>();
            smsNotifier.Priority.Returns(2);
            var user = new User("Alice", [smsNotifier, emailNotifier]);
            var message = "You have a new message!";

            // Act
            user.NotifyWithPriority(message);

            // Assert
            emailNotifier.Received(1).SendNotification("Alice, You have a new message!");
            smsNotifier.DidNotReceive().SendNotification(Arg.Any<string>());
        }

        [Test]
        public void NotifyWithPriority_ShouldSendNotificationToNextPriorityIfHigherPriorityNotAvailable()
        {
            // Arrange
            var smsNotifier = Substitute.For<INotifier>();
            smsNotifier.Priority.Returns(2);
            var whatsApp = Substitute.For<INotifier>();
            whatsApp.Priority.Returns(3);
            var user = new User("Bob", [whatsApp, smsNotifier]);
            var message = "You have a new message!";

            // Act
            user.NotifyWithPriority(message);

            // Assert
            smsNotifier.Received(1).SendNotification("Bob, You have a new message!");
            whatsApp.DidNotReceive().SendNotification(Arg.Any<string>());
        }

        [Test]
        public void NotifyWithPriority_ShouldSendNotificationToLowestPriorityIfNoHigherPriorityAvailable()
        {
            // Arrange
            var whatsApp = Substitute.For<INotifier>();
            whatsApp.Priority.Returns(3);
            var user = new User("Bob", [whatsApp]);
            var message = "You have a new message!";

            // Act
            user.NotifyWithPriority(message);

            // Assert
            whatsApp.Received(1).SendNotification("Bob, You have a new message!");
        }
    }
}
