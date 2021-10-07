using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("Modified_Group_Name")
            {
                Header = "Modified Header Test",
                Footer = "Modified Footer Test"
            };
            app.Navigator.GoToGroupsPage();
            if (app.Groups.AtLeastOneGroupCreated())
            {
                app.Groups.Modify(1, newData);
                app.Navigator.ReturnToGroupsPage();
            }
            else
            {
                GroupData initialData = new GroupData("Initial_Group_Name")
                {
                    Header = "Initial Header Test",
                    Footer = "Initial Footer Test"
                };
                int index = 1;
                app.Groups.Create(initialData);
                app.Navigator.ReturnToGroupsPage();
                app.Groups.Modify(index, newData);
            }
        }
    }
}
