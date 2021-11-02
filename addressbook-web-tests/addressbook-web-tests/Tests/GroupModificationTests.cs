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
            int groupIndex = 0;
            app.Navigator.GoToGroupsPage();

            if (!app.Groups.AtLeastOneGroupCreated())
            {
                GroupData initialData = new GroupData("Initial_Group_Name");
                app.Groups.Create(initialData);
                app.Navigator.ReturnToGroupsPage();
                groupIndex = 0;
            }

            GroupData newData = new GroupData("Modified_Group_Name");
            List<GroupData> oldGroups = app.Groups.GetGroupsList();
            
            app.Groups.Modify(groupIndex, newData);
            List<GroupData> newGroups = app.Groups.GetGroupsList();
            
            oldGroups[groupIndex].Name = newData.Name;
            
            oldGroups.Sort();
            newGroups.Sort();
            
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
