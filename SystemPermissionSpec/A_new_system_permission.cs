using FluentAssertions;
using NUnit.Framework;

namespace TDD.SystemPermissionSpec
{
    [TestFixture]
    public class A_new_system_permission
    {
        private SystemPermission systemPermission;

        [SetUp]
        public void Setup()
        {
            systemPermission = new SystemPermission();
        }

        [Test]
        public void Is_Requested()
        {
            systemPermission.Permission
                .Should().Be(Permission.Requested);
        }

        [Test]
        public void Is_not_granted()
        {
            systemPermission.Granted.Should().Be(false);
        }

        [Test]
        public void Does_not_allow_granting()
        {
            systemPermission.Grant();

            systemPermission.Permission
                .Should().Be(Permission.Requested);
        }

        [Test]
        public void Does_not_allow_denying()
        {
            systemPermission.Deny();

            systemPermission.Permission
                .Should().Be(Permission.Requested);
        }

        [Test]
        public void Allows_claiming()
        {
            systemPermission.Claim();

            systemPermission.Permission
                .Should().Be(Permission.Claimed);
        }
    }
}
