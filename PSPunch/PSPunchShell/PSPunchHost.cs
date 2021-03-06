﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Globalization;
using System.Threading;
using PSPunch.PSPunchShell;

namespace PSPunch
{
    class PSPunchHost : PSHost
    {
        private PSPunchHostUserInterface PSPunchUI = new PSPunchHostUserInterface();
        private Guid gid = Guid.NewGuid();
        private System.Globalization.CultureInfo originalCultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
        private System.Globalization.CultureInfo originalUICultureInfo = System.Threading.Thread.CurrentThread.CurrentUICulture;

        public override System.Globalization.CultureInfo CurrentCulture
        {
            get { return originalCultureInfo; }
        }

        public override System.Globalization.CultureInfo CurrentUICulture
        {
            get { return originalUICultureInfo; }
        }

        public override Guid InstanceId
        {
            get
            {
                return gid;
            }
        }

        public override string Name
        {
            get
            {
                return "PS PUNCH!!!";
            }
        }

        public override PSHostUserInterface UI
        {
            get
            {
                return PSPunchUI;
            }
        }

        public override System.Version Version
        {
            // return the powershell version supported
            get { return new System.Version(3, 0, 0, 0); }
        }

        public override void EnterNestedPrompt()
        {
            Console.WriteLine("Entering Nested Prompt");
        }

        public override void ExitNestedPrompt()
        {
            Console.WriteLine("Exiting Nested Prompt");
        }

        public override void NotifyBeginApplication()
        {
            throw new NotImplementedException();
        }

        public override void NotifyEndApplication()
        {
            throw new NotImplementedException();
        }

        public override void SetShouldExit(int exitCode)
        {
        
        }
    }
}
