using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class SystemPermission
    {
        private bool granted;

        private Permission permission;

        public SystemPermission()
        {
            granted = false;
            SetPermission(Permission.Requested);
        }

        public bool Granted
        {
            get { return granted; }
        }

        public Permission Permission
        {
            get { return permission; }
        }


        private void SetPermission(Permission newPermission)
        {
            this.permission = newPermission;
        }

        public void Claim()
        {
            if (this.Permission.Equals(Permission.Requested))
            {
                SetPermission(Permission.Claimed);
            }
        }

        public void Grant()
        {
            if (this.Permission.Equals(Permission.Claimed))
            {
                SetPermission(Permission.Granted);
                this.granted = true;
            }
        }

        public void Deny()
        {
            if (this.Permission.Equals(Permission.Claimed))
            {
                SetPermission(Permission.Denied);
            }
        }
    }
}
