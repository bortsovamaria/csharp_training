﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests.tests
{
    [TestFixture]
    public class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("zzz");
            newData.Header = null;
            newData.Footer = null;

            app.Groups.Modify(1, newData);
        }
    }
}