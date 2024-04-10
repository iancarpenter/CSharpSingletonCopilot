using SingletonCoPilot;

namespace SingletonCoPilotTests
{
    public class SingletonCoPilotTests
    {
        [Test]
        public void GetInstance_ReturnsSameInstance()
        {
            // Arrange & Act
            SingletonCoPilot2 instance1 = SingletonCoPilot2.GetInstance();
            SingletonCoPilot2 instance2 = SingletonCoPilot2.GetInstance();
                    
            // Assert
            Assert.That(instance2, Is.SameAs(instance1));
        }

        [Test]
        public void GetInstance_ReturnsNonNullInstance()
        {
            // Arrange & Act
            SingletonCoPilot2 instance = SingletonCoPilot2.GetInstance();

            // Assert
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void PrintMessage_PrintsExpectedMessage()
        {
            // Arrange
            SingletonCoPilot2 instance = SingletonCoPilot2.GetInstance();
            string message = "Test message";
            using var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            instance.PrintMessage(message);

            // Assert
            Assert.That(consoleOutput.ToString(), Is.EqualTo(message + Environment.NewLine));
        }
    }
}