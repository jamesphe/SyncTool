﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v7.0.1, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BaseVouchSessionInfoList.cs'.
//
//     Template: ReadOnlyList.DataAccess.ParameterizedSQL.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using MySql.Data.MySqlClient;

using Csla;
using Csla.Data;

namespace vjf.SyncTool.Business
{
    public partial class BaseVouchSessionInfoList
    {
        private void DataPortal_Fetch(BaseVouchSessionCriteria criteria)
        {
            IsReadOnly = false;

            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return;

            RaiseListChangedEvents = false;

            // Fetch Child objects.
            string commandText = String.Format("SELECT id,vouch_group_id,open_id,vouch_id,success,create_time FROM base_vouch_session {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (var connection = new MySqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));

                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                        {
                            do
                            {
                                this.Add(vjf.SyncTool.Business.BaseVouchSessionInfo.GetBaseVouchSessionInfo(reader));
                            } while(reader.Read());
                        }
                    }
                }
            }

            RaiseListChangedEvents = true;

            OnFetched();

            IsReadOnly = true;
        }
    }
}
