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

        public static readonly string Requested = "Requested";
        public static readonly string Claimed = "Claimed";
        public static readonly string Denied = "Denied";
        public static readonly string Granted = "Granted";
        private string permission;

        public SystemPermission()
        {
            granted = false;
            SetPermission(Requested);
        }

        private void SetPermission(string newPermission)
        {
            this.permission = newPermission;
        }

        public string GetPermission()
        {
            return this.permission;
        }

        public void Claim()
        {
            if (this.permission == SystemPermission.Requested)
                this.permission = SystemPermission.Claimed;
        }

        public bool IsGranted()
        {
            return this.granted;
        }

        public void Grant()
        {
            if (this.permission == SystemPermission.Claimed)
            {
                this.permission = SystemPermission.Granted;
                this.granted = true;
            }
        }

        public void Deny()
        {
            if (this.permission == SystemPermission.Claimed)
                this.permission = SystemPermission.Denied;
        }
    }
}
