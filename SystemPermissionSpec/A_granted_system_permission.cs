using FluentAssertions;
using NUnit.Framework;

namespace TDD.SystemPermissionSpec
{
    [TestFixture]
    public class A_granted_system_permission
    {
        private static SystemPermission systemPermission;

        [SetUp]
        public static void Setup()
        {
            systemPermission = new SystemPermission();

            systemPermission.Claim();
            systemPermission.Grant();
        }

        [Test]
        public void Is_granted()
        {
            systemPermission.Granted
                .Should().BeTrue();
        }

        [Test]
        public void Ignores_granting()
        {
            systemPermission.Grant();

            systemPermission.Permission
                .Should().Be(Permission.Granted);
        }

        [Test]
        public void Does_not_allow_claiming()
        {
            systemPermission.Claim();

            systemPermission.Permission
                .Should().Be(Permission.Granted);
        }

        [Test]
        public void Does_not_allow_denying()
        {
            systemPermission.Deny();

            systemPermission.Permission
                .Should().Be(Permission.Granted);
        }
    }
}