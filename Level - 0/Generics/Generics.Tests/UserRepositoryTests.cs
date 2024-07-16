using FluentAssertions;
using Generics.Objects;
using Generics.Repository;
using NUnit.Framework;

namespace Generics.Tests
{
    [TestFixture]
    public class UserRepositoryTests
    {
        [Test]
        public void Add_ShouldReturnSuccess()
        {
            // Arrange
            var user = new User { Id = 1, Name = "John", Surname = "Testing" };
            var userRepository = CreateUserRepository();
            // Act
            userRepository.Add(user);

            // Assert
            var retrievedUser = userRepository.GetById(1);

            retrievedUser.Should().NotBeNull();
            retrievedUser.Id.Should().Be(1);
            retrievedUser.Name.Should().Be("John");
            retrievedUser.Surname.Should().Be("Testing");
        }

        [Test]
        public void Remove_ShouldReturnSuccess()
        {
            // Arrange
            var user = new User { Id = 1, Name = "John", Surname = "Testing" };
            var userRepository = CreateUserRepository();

            userRepository.Add(user);

            // Act
            userRepository.Remove(user);

            // Assert
            var retrievedUser = userRepository.GetById(1);
            retrievedUser.Should().BeNull();
        }

        [Test]
        public void GetById_ShouldReturnNotFound()
        {
            // Act
            var userRepository = CreateUserRepository();
            var retrievedUser = userRepository.GetById(1);

            // Assert
            retrievedUser.Should().BeNull();
        }

        public UserRepository CreateUserRepository()
        {
            return new UserRepository();
        }
    }
}
