using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class SystemPermission
    {
        public enum Permission
        {
            Claimed,
            Granted,
            Denied,
            Requested
        }
        private bool granted;

        private Permission permission;

        public SystemPermission()
        {
            granted = false;
            SetPermission(Permission.Requested);
        }


        private void SetPermission(Permission newPermission)
        {
            this.permission = newPermission;
        }

        public Permission GetPermission()
        {
            return this.permission;
        }

        public void Claim()
        {
            if (GetPermission().Equals(Permission.Requested))
            {
                SetPermission(Permission.Claimed);
            }
        }

        public bool IsGranted()
        {
            return this.granted;
        }

        public void Grant()
        {
            if (GetPermission().Equals(Permission.Claimed))
            {
                SetPermission(Permission.Granted);
                this.granted = true;
            }
        }

        public void Deny()
        {
            if (GetPermission().Equals(Permission.Claimed))
            {
                SetPermission(Permission.Denied);
            }
        }
    }
}
