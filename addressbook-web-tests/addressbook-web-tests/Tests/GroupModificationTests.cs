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
            int groupIndex = 1;
            app.Navigator.GoToGroupsPage();

            if (!app.Groups.AtLeastOneGroupCreated())
            {
                GroupData initialData = new GroupData("Initial_Group_Name")
                {
                    Header = "Initial Header Test",
                    Footer = "Initial Footer Test"
                };
                app.Groups.Create(initialData);
                app.Navigator.ReturnToGroupsPage();
                groupIndex = 1;
            }
            
            GroupData newData = new GroupData("Modified_Group_Name")
            {
                Header = "Modified Header Test",
                Footer = "Modified Footer Test"
            };

            app.Groups.Modify(groupIndex, newData);
            app.Navigator.ReturnToGroupsPage();
        }
    }
}
