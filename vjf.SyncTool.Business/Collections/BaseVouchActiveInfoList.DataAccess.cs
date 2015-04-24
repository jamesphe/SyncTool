﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v7.0.1, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BaseVouchActiveInfoList.cs'.
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
    public partial class BaseVouchActiveInfoList
    {
        private void DataPortal_Fetch(BaseVouchActiveCriteria criteria)
        {
            IsReadOnly = false;

            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return;

            RaiseListChangedEvents = false;

            // Fetch Child objects.
            string commandText = String.Format("SELECT id,title,begindate,enddate,vouchid,vouchnum,usernum,lnum,status,created,updated FROM base_vouch_active {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
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
                                this.Add(vjf.SyncTool.Business.BaseVouchActiveInfo.GetBaseVouchActiveInfo(reader));
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
