using System;
using System.Data;

namespace DVLD.Shared.Utile
{
    public class clsUtile
    {
        public static void TrimDataTableStrings(ref DataTable dt)
        {
            if (dt == null) return;

            foreach (DataColumn col in dt.Columns)
            {
                if (col.DataType == typeof(string))
                {
                    bool isReadOnly = col.ReadOnly;

                    if (isReadOnly)
                        col.ReadOnly = false;

                    foreach (DataRow row in dt.Rows)
                    {
                        if (row[col] != DBNull.Value)
                        {
                            row[col] = row[col].ToString().Trim();
                        }
                    }

                    if (isReadOnly)
                        col.ReadOnly = true; 
                }
            }
        }
    }
}
