using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DreamCrusher.Models
{
    public class ForgotPassword : Common
    {
        //public string LoginId { get; set; }
        public string MobileNumber { get; set; }

        public DataSet ValidateData()
        {
            SqlParameter[] para = { new SqlParameter("@LoginId", LoginId),
                                  new SqlParameter("@Mobile", MobileNumber)};
            DataSet ds = DBHelper.ExecuteQuery("ForgotPassword", para);
            return ds;
        }

    }
}