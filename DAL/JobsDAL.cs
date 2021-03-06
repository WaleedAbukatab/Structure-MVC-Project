﻿using DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class JobsDAL
    {
        #region Retrieve Data
        public static DataTable GetAllJobs(string name = null)
        {
            try
            {
                using (IDBHelper dBHelper = DBTypeSelector.GetDBInstant("dbo.GetAllJobs"))
                {
                    dBHelper.AddParameter("@Name", name);
                    return dBHelper.FillDataTable();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}
