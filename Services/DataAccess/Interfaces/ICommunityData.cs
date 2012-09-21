using LeanerSnow.Common;

namespace LeanerSnow.DataAccess
{
    public interface ICommunityData
    {
        CommunityOrganization GetOrganizationByID(int organizationID);
    }
}
