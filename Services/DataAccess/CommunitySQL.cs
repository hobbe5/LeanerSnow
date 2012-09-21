using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using LeanerSnow.Common;

namespace LeanerSnow.DataAccess
{
    public class CommunitySQL : ICommunityData
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["IntakeExpress"].ConnectionString;

        #region Public Methods

        #region Community Methods

        public CommunityOrganization GetOrganizationByID(int organizationID)
        {
            CommunityOrganization org = null; 
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("comm_GetOrganizationByID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", organizationID);

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.Read())
                    {
                        org = PopulateOrganization(rdr);
                    }
                }
            }

            return org;
        }

        #endregion
        //#region Comments

        //public IEnumerable<Comment> GetCommentsByProject(int projID)
        //{
        //    List<Comment> comments = new List<Comment>();
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        conn.Open();

        //        SqlCommand cmd = new SqlCommand("comments_GetByProject", conn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@projID", projID);

        //        using (SqlDataReader rdr = cmd.ExecuteReader())
        //        {
        //            while (rdr.Read())
        //            {
        //                comments.Add(PopulateProjectComment(rdr));
        //            }
        //        }
        //    }

        //    return comments;
        //}

        //public bool AddProjectComment(int projID, Comment comment)
        //{
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        conn.Open();

        //        SqlCommand cmd = new SqlCommand("comments_Insert", conn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@Comment", comment.Content);
        //        cmd.Parameters.AddWithValue("@CreatedDate", comment.CreatedDate);
        //        cmd.Parameters.AddWithValue("@CreatedBy", comment.CreatedBy);
        //        cmd.Parameters.AddWithValue("@ProjectID", projID);
        //        cmd.Parameters.AddWithValue("@CommentID", comment.CommentID);
        //        cmd.Parameters.AddWithValue("@Email", comment.Email);
        //        return cmd.ExecuteNonQuery() > 0;
        //    }
        //}

        //#endregion

        #endregion

        #region Private Methods

        private CommunityOrganization PopulateOrganization(IDataRecord dataRecord)
        {
            CommunityOrganization org = new CommunityOrganization();
            org.OrganizationID = Convert.ToInt32(dataRecord["IDCO"]);
            if (dataRecord.HasColumn("Organization"))
                org.Name = dataRecord["Organization"].ToString();
            if (dataRecord.HasColumn("Address"))
                org.Address = dataRecord["Address"].ToString();
            if (dataRecord.HasColumn("city"))
                org.City = dataRecord["city"].ToString();
            if (dataRecord.HasColumn("state"))
                org.State = dataRecord["state"].ToString();
            if (dataRecord.HasColumn("zip"))
                org.ZipCode = dataRecord["zip"].ToString();
            if (dataRecord.HasColumn("tel"))
                org.Phone = dataRecord["tel"].ToString();
            if (dataRecord.HasColumn("fax"))
                org.Fax = dataRecord["fax"].ToString();
            if (dataRecord.HasColumn("website"))
                org.Website = dataRecord["website"].ToString();
            if (dataRecord.HasColumn("masteremail"))
                org.Email = dataRecord["masteremail"].ToString();
            
            return org;
        }

        #endregion
    }
}
