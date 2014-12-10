using FluentAssertions;
using NUnit.Framework;

namespace TDD.SystemPermissionSpec
{
    [TestFixture]
    public class A_new_system_permission
    {
        private SystemPermission permission;

        [SetUp]
        public void Setup()
        {
            permission = new SystemPermission();
        }

        [Test]
        public void Is_Requested()
        {
            permission.GetPermission().Should().Be(SystemPermission.Permission.Requested);
        }

        [Test]
        public void Is_not_granted()
        {
            permission.IsGranted().Should().Be(false);
        }

        [Test]
        public void Does_not_allow_granting()
        {
            permission.Grant();

            permission.GetPermission().Should().Be(SystemPermission.Permission.Requested);
        }

        [Test]
        public void Does_not_allow_denying()
        {
            permission.Deny();

            permission.GetPermission().Should().Be(SystemPermission.Permission.Requested);
        }

        [Test]
        public void Allows_claiming()
        {
            permission.Claim();

            permission.GetPermission().Should().Be(SystemPermission.Permission.Claimed);
        }
    }
}
