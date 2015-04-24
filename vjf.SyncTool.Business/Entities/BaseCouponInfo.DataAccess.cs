﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v7.0.1, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BaseCouponInfo.cs'.
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
    public partial class BaseCouponInfo
    {
        private void DataPortal_Fetch(BaseCouponCriteria criteria)
        {
            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return;

            string commandText = String.Format("SELECT id, batchno, qdid, hzmid, cardnum, cardlength, pid, vid, pnum, begintime, endtime, point, feepoint, status, created, createid, cardrule, remark, province, city, area, expdate, expday FROM base_coupon {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
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
                            throw new System.Exception(String.Format("The record was not found in '.base_coupon' using the following criteria: {0}.", criteria));
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
            LoadProperty(_batchnoProperty, reader["batchno"]);
            LoadProperty(_qdidProperty, reader["qdid"]);
            LoadProperty(_hzmidProperty, reader["hzmid"]);
            LoadProperty(_cardnumProperty, reader["cardnum"]);
            LoadProperty(_cardlengthProperty, reader["cardlength"]);
            LoadProperty(_pidProperty, reader["pid"]);
            LoadProperty(_vidProperty, reader["vid"]);
            LoadProperty(_pnumProperty, reader["pnum"]);
            LoadProperty(_begintimeProperty, reader["begintime"]);
            LoadProperty(_endtimeProperty, reader["endtime"]);
            LoadProperty(_pointProperty, reader["point"]);
            LoadProperty(_feepointProperty, reader["feepoint"]);
            LoadProperty(_statusProperty, reader["status"]);
            LoadProperty(_createdProperty, reader["created"]);
            LoadProperty(_createidProperty, reader["createid"]);
            LoadProperty(_cardruleProperty, reader["cardrule"]);
            LoadProperty(_remarkProperty, reader["remark"]);
            LoadProperty(_provinceProperty, reader["province"]);
            LoadProperty(_cityProperty, reader["city"]);
            LoadProperty(_areaProperty, reader["area"]);
            LoadProperty(_expdateProperty, reader["expdate"]);
            LoadProperty(_expdayProperty, reader["expday"]);

            OnMapped();
        }

        private void Child_Fetch(SafeDataReader reader)
        {
            Map(reader);
        }

        #endregion
    }
}
