using FluentAssertions;
using NUnit.Framework;

namespace TDD.SystemPermissionSpec
{
    [TestFixture]
    public class A_denied_system_permission
    {
        private static SystemPermission systemPermission;

        [SetUp]
        public static void Setup()
        {
            systemPermission = new SystemPermission();

            systemPermission.Claim();
            systemPermission.Deny();
        }

        [Test]
        public void Is_not_granted()
        {
            systemPermission.IsGranted().Should().BeFalse();
        }

        [Test]
        public void Ignores_denying()
        {
            systemPermission.Deny();

            systemPermission.GetPermission().Should().Be(SystemPermission.Denied);
        }

        [Test]
        public void Does_not_allow_claiming()
        {
            systemPermission.Claim();

            systemPermission.GetPermission().Should().Be(SystemPermission.Denied);
        }

        [Test]
        public void Does_not_allow_granting()
        {
            systemPermission.Grant();

            systemPermission.GetPermission().Should().Be(SystemPermission.Denied);
        }
    }
}