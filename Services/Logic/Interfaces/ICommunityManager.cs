using LeanerSnow.Common;

namespace LeanerSnow.Logic
{
    public interface ICommunityManager
    {
        CommunityOrganization GetOrganizationByID(int organizationID);
    }
}
