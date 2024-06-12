using Classes;
using FluentAssertions;
using NUnit.Framework;
using System.Text.Json;

namespace TestClasses
{
    [TestFixture]
    public class TestPerson
    {
        [Test]
        public void ToJson_ShouldReturnCorrectJsonString()
        {
            // Arrange
            var person = new Person { Name = "Tris Testing", Age = 30, Email = "tris@test.com" };
            var expectedJson = JsonSerializer.Serialize(person);

            // Act
            var json = person.ToJson();

            // Assert
            json.Should().Be(expectedJson);
        }

        [Test]
        public void FromJson_ShouldReturnCorrectPersonObject()
        {
            // Arrange
            var json = "{\"Name\":\"Tris Test\",\"Age\":30,\"Email\":\"tris@test.com\"}";
            var expectedPerson = new Person { Name = "Tris Test", Age = 30, Email = "tris@test.com" };

            // Act
            var person = Person.FromJson(json);

            // Assert
            person.Name.Should().Be(expectedPerson.Name);
            person.Age.Should().Be(expectedPerson.Age);
            person.Email.Should().Be(expectedPerson.Email);
        }

        [Test]
        public void DisplayInfo_ShouldDisplayCorrectInfo()
        {
            // Arrange
            var person = new Person { Name = "Tris Testing", Age = 30, Email = "tris@test.com" };
            var expectedOutput = $"Name: Tris Testing, Age: 30, Email: tris@test.com{Environment.NewLine}";

            using var sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            person.DisplayInfo();

            // Assert
            sw.ToString().Should().Be(expectedOutput);
        }
    }
}
