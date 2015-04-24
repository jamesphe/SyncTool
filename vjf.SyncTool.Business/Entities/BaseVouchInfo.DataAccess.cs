﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v7.0.1, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BaseVouchInfo.cs'.
//
//     Template: ReadOnlyRoot.DataAccess.ParameterizedSQL.cst
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
    public partial class BaseVouchInfo
    {
        private void DataPortal_Fetch(BaseVouchCriteria criteria)
        {
            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return;

            string commandText = String.Format("SELECT id, gid, vname, status, begintime, created, createid, city, product, store, paytype, usecanal, getcanal, node, nodeproduct, cost, paycost, type, expday, ischange, quotiety, brandid FROM base_vouch {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (var connection = new MySqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if (reader.Read())
                            Map(reader);
                        else
                            throw new System.Exception(String.Format("The record was not found in '.base_vouch' using the following criteria: {0}.", criteria));
                    }
                }
            }

            OnFetched();
        }

        #region Map

        private void Map(SafeDataReader reader)
        {
            bool cancel = false;
            OnMapping(reader, ref cancel);
            if (cancel) return;

            LoadProperty(_identificationProperty, reader["id"]);
            LoadProperty(_gidProperty, reader["gid"]);
            LoadProperty(_vnameProperty, reader["vname"]);
            LoadProperty(_statusProperty, reader["status"]);
            LoadProperty(_begintimeProperty, reader["begintime"]);
            LoadProperty(_createdProperty, reader["created"]);
            LoadProperty(_createidProperty, reader["createid"]);
            LoadProperty(_cityProperty, reader["city"]);
            LoadProperty(_productProperty, reader["product"]);
            LoadProperty(_storeProperty, reader["store"]);
            LoadProperty(_paytypeProperty, reader["paytype"]);
            LoadProperty(_usecanalProperty, reader["usecanal"]);
            LoadProperty(_getcanalProperty, reader["getcanal"]);
            LoadProperty(_nodeProperty, reader["node"]);
            LoadProperty(_nodeproductProperty, reader["nodeproduct"]);
            LoadProperty(_costProperty, reader["cost"]);
            LoadProperty(_paycostProperty, reader["paycost"]);
            LoadProperty(_typeProperty, reader["type"]);
            LoadProperty(_expdayProperty, reader["expday"]);
            LoadProperty(_ischangeProperty, reader["ischange"]);
            LoadProperty(_quotietyProperty, reader["quotiety"]);
            LoadProperty(_brandidProperty, reader["brandid"]);

            OnMapped();
        }

        private void Child_Fetch(SafeDataReader reader)
        {
            Map(reader);
        }

        #endregion
    }
}
