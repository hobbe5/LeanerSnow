using LeanerSnow.Common;
using LeanerSnow.DataAccess;
using LeanerSnow.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace LeanerSnow.UnitTests
{
    [TestClass]
    public class CommunityTests
    {
        Mock<ICommunityData> _dataAccess;
        CommunityManager _manager;

        [TestInitialize]
        public void TestInit()
        {
            _dataAccess = new Mock<ICommunityData>();
            _manager = new CommunityManager(_dataAccess.Object);
        }

        [TestMethod]
        public void Can_Get_Organization_By_Id()
        {
            //Arrange
            int organizationID = 1;
            CommunityOrganization expected = new CommunityOrganization() { OrganizationID = organizationID };
            _dataAccess.Setup(c => c.GetOrganizationByID(It.IsAny<int>())).Returns(expected);

            //Act
            var actual = _manager.GetOrganizationByID(organizationID);

            //Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(actual.OrganizationID, expected.OrganizationID);
            _dataAccess.Verify(c => c.GetOrganizationByID(It.IsAny<int>()), Times.Exactly(1));
        }
    }
}
