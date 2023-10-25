using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DreamCrusher.Models
{
    public class Website
    {
        public string AddedBy { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

        public DataSet Savecontactus()
        {
            SqlParameter[] para = {
                new SqlParameter("@Name", Name),
                new SqlParameter("@Email", Email),
                new SqlParameter("@Mobile", Phonenumber),
                new SqlParameter("@Subject", Subject),
                new SqlParameter("@Message", Message),
                 new SqlParameter("@AddedBy", AddedBy)
            };
            DataSet ds = DBHelper.ExecuteQuery("SaveContactUs", para);
            return ds;
        }
    }
}