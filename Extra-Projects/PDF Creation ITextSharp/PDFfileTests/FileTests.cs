using NUnit.Framework;

namespace PDFfileTests
{
    [TestFixture]
    public class FileTests
    {
        public class UserTest
        {
            [Test]
            public void Should_CreateUser()
            {
                var user = UserBuilder.Create().Build();

                Assert.IsNotNull(user);
            }
        }
    }
}