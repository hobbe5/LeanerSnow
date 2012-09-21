using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeanerSnow.Common;
using LeanerSnow.DataAccess;

namespace LeanerSnow.Logic
{
    public class CommunityManager : ICommunityManager
    {
        #region Constructor

        ICommunityData _dataAccess;
        ICommunityData dataAccess
        {
            get
            {
                if (_dataAccess == null)
                    _dataAccess = new CommunitySQL();

                return _dataAccess;
            }
            set
            {
                _dataAccess = value;
            }
        }

        public CommunityManager()
        {
        }

        public CommunityManager(ICommunityData dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        #endregion        

        public CommunityOrganization GetOrganizationByID(int organizationID)
        {
            return dataAccess.GetOrganizationByID(organizationID);
        }
    }
}
