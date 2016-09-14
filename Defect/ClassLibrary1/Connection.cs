using System;
using System.Collections.Generic;
using System.Text;
using WebService1;
using System.Data.SqlClient;
using DataAccess.Properties;
using System.Data;

namespace DataAccess
{
    public class Connection
    {

        string _connectionString = Settings.Default.defaultConnectionString;

        public string ConnectionString { get { return _connectionString; } set { _connectionString = value; } }


        public Defect GetDefect(int Id)
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            SqlDataReader DefReader = null;
            try
            {
                SqlCommand getDefComm = new SqlCommand("DefectGet", conn);
                getDefComm.CommandType = System.Data.CommandType.StoredProcedure;
                getDefComm.Parameters.Add("@Id", System.Data.SqlDbType.Int, 4).Value = Id;
                conn.Open();
                DefReader = getDefComm.ExecuteReader();
                DefReader.Read();
                Defect result = FillUpDefect(DefReader);
                return result;
            }
            finally
            {
                if (null != DefReader) DefReader.Close();
                if (null != conn) conn.Close();
            }
        }

        private Defect FillUpDefect(SqlDataReader DefReader)
        {
            if (DefReader.HasRows)
            {
                    Defect result = new Defect();
                    result.Id = Convert.ToInt32(DefReader["Id"].ToString());
                    result.Title = DefReader["Title"].ToString();
                    result.Description = DefReader["Description"].ToString();
                    // TODO: result.AttachedFile = (byte[])DefReader["AttachedFile"];
                    result.CreatedBy = DefReader["CreatedBy"].ToString();
                    result.State = (DefectState)Enum.Parse(typeof(DefectState), DefReader["State"].ToString());
                    result.CreatedDate = Convert.ToDateTime(DefReader["CreateDate"].ToString());
                    result.AssignedTo = DefReader["AssignedTo"].ToString();

                    if (DefReader["AssignedDate"].ToString() == "")
                    {
                        result.AssignedDate = null;
                    }
                    else
                    {
                        result.AssignedDate = Convert.ToDateTime(DefReader["AssignedDate"].ToString());
                    }


                    if (DefReader["ClosedDate"].ToString() == "")
                    {
                        result.ClosedDate = null;
                    }
                    else
                    {
                        result.ClosedDate = Convert.ToDateTime(DefReader["ClosedDate"].ToString());
                    }

                    return result;
            }
            return null;
        }

        public int Insert(Defect d)
        {
            int resultId;

            SqlConnection conn = new SqlConnection(_connectionString);
            SqlDataReader DefReader = null;
            try
            {
                SqlCommand insertDefComm = new SqlCommand("DefectInsert", conn);
                insertDefComm.CommandType = System.Data.CommandType.StoredProcedure;
                insertDefComm.Parameters.Add("@Title", System.Data.SqlDbType.VarChar, 200).Value = (object)d.Title ?? DBNull.Value;
                insertDefComm.Parameters.Add("@Description", System.Data.SqlDbType.VarChar, 2000).Value = (object)d.Description ?? DBNull.Value;
                insertDefComm.Parameters.Add("@AttachedFile", System.Data.SqlDbType.Image).Value = (object)d.AttachedFile ?? DBNull.Value;
                insertDefComm.Parameters.Add("@CreatedBy", System.Data.SqlDbType.VarChar, 100).Value = d.CreatedBy;
                insertDefComm.Parameters.Add("@CreateDate", System.Data.SqlDbType.DateTime).Value = d.CreatedDate;

                SqlParameter Id = new SqlParameter("@Id", System.Data.SqlDbType.Int);
                Id.Direction = ParameterDirection.Output;

                insertDefComm.Parameters.Add(Id);

                conn.Open();

                DefReader = insertDefComm.ExecuteReader();
                DefReader.Read();

                resultId = (int)Id.Value;
            }
            finally
            {
                if (null != DefReader) DefReader.Close();
                if (null != conn) conn.Close();
            }

            return resultId;

        }

        public void Update(Defect d)
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            SqlDataReader DefReader = null;
            try
            {
                SqlCommand updateDefComm = new SqlCommand("DefectUpdate", conn);
                updateDefComm.CommandType = System.Data.CommandType.StoredProcedure;
                updateDefComm.Parameters.Add("@Id", System.Data.SqlDbType.Int, 4).Value = d.Id;
                updateDefComm.Parameters.Add("@Title", System.Data.SqlDbType.VarChar, 200).Value = (object)d.Title ?? DBNull.Value;
                updateDefComm.Parameters.Add("@Description", System.Data.SqlDbType.VarChar, 2000).Value = (object)d.Description ?? DBNull.Value;
                updateDefComm.Parameters.Add("@AttachedFile", System.Data.SqlDbType.Image).Value = (object)d.AttachedFile ?? DBNull.Value;
                updateDefComm.Parameters.Add("@State", System.Data.SqlDbType.VarChar, 100).Value = d.State;
                updateDefComm.Parameters.Add("@CreatedBy", System.Data.SqlDbType.VarChar, 100).Value = (object)d.CreatedBy ?? DBNull.Value;
                updateDefComm.Parameters.Add("@CreateDate", System.Data.SqlDbType.DateTime).Value = (object)d.CreatedDate ?? DBNull.Value;
                updateDefComm.Parameters.Add("@AssignedTo", System.Data.SqlDbType.VarChar, 100).Value = (object)d.AssignedTo ?? DBNull.Value;
                updateDefComm.Parameters.Add("@AssignedDate", System.Data.SqlDbType.DateTime).Value = (object)d.AssignedDate ?? DBNull.Value;
                updateDefComm.Parameters.Add("@ClosedDate", System.Data.SqlDbType.DateTime).Value = (object)d.ClosedDate ?? DBNull.Value;

                conn.Open();

                DefReader = updateDefComm.ExecuteReader();
            }
            finally
            {
                if (null != DefReader) DefReader.Close();
                if (null != conn) conn.Close();
            }

        }

        public List<Defect> GetCreatedDefects(string user)
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            SqlDataReader DefReader = null;
            try
            {
                SqlCommand getDefComm = new SqlCommand("DefectListCreated", conn);
                getDefComm.CommandType = System.Data.CommandType.StoredProcedure;
                getDefComm.Parameters.Add("@CreatedBy", System.Data.SqlDbType.VarChar, 200).Value = user;
                conn.Open();
                DefReader = getDefComm.ExecuteReader();
                List<Defect> resultList = new List<Defect>();
                while (DefReader.Read())
                {
                    Defect result = FillUpDefect(DefReader);
                    resultList.Add(result);
                }
                return resultList;
            }
            finally
            {
                if (null != DefReader) DefReader.Close();
                if (null != conn) conn.Close();
            }
        }

        public List<Defect> GetAssignedDefects()
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            SqlDataReader DefReader = null;
            try
            {
                SqlCommand getDefComm = new SqlCommand("DefectListAssigned", conn);
                getDefComm.CommandType = System.Data.CommandType.StoredProcedure;
                conn.Open();
                DefReader = getDefComm.ExecuteReader();
                List<Defect> resultList = new List<Defect>();
                while (DefReader.Read())
                {
                    Defect result = FillUpDefect(DefReader);
                    resultList.Add(result);
                }
                return resultList;
            }
            finally
            {
                if (null != DefReader) DefReader.Close();
                if (null != conn) conn.Close();
            }
        }
    }
}
