using FluentAssertions;
using NUnit.Framework;

namespace TDD.SystemPermissionSpec
{
    [TestFixture]
    public class A_claimed_system_permission
    {
        private static SystemPermission systemPermission;

        [SetUp]
        public static void Setup()
        {
            systemPermission = new SystemPermission();

            systemPermission.Claim();
        }

        [Test]
        public void Is_not_granted()
        {
            systemPermission.IsGranted().Should().Be(false);
        }

        [Test]
        public void Ignores_claiming()
        {
            systemPermission.Claim();

            systemPermission.GetPermission().Should().Be(SystemPermission.Permission.Claimed);
        }

        [Test]
        public void Allows_granting()
        {
            systemPermission.Grant();

            systemPermission.GetPermission().Should().Be(SystemPermission.Permission.Granted);
        }

        [Test]
        public void Allows_denying()
        {
            systemPermission.Deny();

            systemPermission.GetPermission().Should().Be(SystemPermission.Permission.Denied);
        }
    }
}