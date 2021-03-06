﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v7.0.1, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BaseCoupon.cs'.
//
//     Template: Criteria.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

using Csla;

namespace vjf.SyncTool.Business
{
    [Serializable]
    public partial class BaseCouponCriteria : CriteriaBase<BaseCouponCriteria>, IGeneratedCriteria
    {
        private readonly Dictionary<string, object> _bag = new Dictionary<string, object>();
        
        #region Constructors

        public BaseCouponCriteria(){}

        public BaseCouponCriteria(System.Int32 identification)
        {
            this.Identification = identification;
        }

        #endregion

        #region Public Properties

        #region Read-Write

        public System.Int32 Identification
        {
            get { return GetValue<System.Int32>("id"); }
            set { _bag["id"] = value; }
        }

        public System.String Batchno
        {
            get { return GetValue<System.String>("batchno"); }
            set { _bag["batchno"] = value; }
        }

        public System.String Qdid
        {
            get { return GetValue<System.String>("qdid"); }
            set { _bag["qdid"] = value; }
        }

        public System.String Hzmid
        {
            get { return GetValue<System.String>("hzmid"); }
            set { _bag["hzmid"] = value; }
        }

        public System.Int32? Cardnum
        {
            get { return GetValue<System.Int32?>("cardnum"); }
            set { _bag["cardnum"] = value; }
        }

        public System.Int32? Cardlength
        {
            get { return GetValue<System.Int32?>("cardlength"); }
            set { _bag["cardlength"] = value; }
        }

        public System.Int16? Pid
        {
            get { return GetValue<System.Int16?>("pid"); }
            set { _bag["pid"] = value; }
        }

        public System.Int32? Vid
        {
            get { return GetValue<System.Int32?>("vid"); }
            set { _bag["vid"] = value; }
        }

        public System.Int32? Pnum
        {
            get { return GetValue<System.Int32?>("pnum"); }
            set { _bag["pnum"] = value; }
        }

        public System.Int32? Begintime
        {
            get { return GetValue<System.Int32?>("begintime"); }
            set { _bag["begintime"] = value; }
        }

        public System.Int32? Endtime
        {
            get { return GetValue<System.Int32?>("endtime"); }
            set { _bag["endtime"] = value; }
        }

        public System.Single? Point
        {
            get { return GetValue<System.Single?>("point"); }
            set { _bag["point"] = value; }
        }

        public System.Single? Feepoint
        {
            get { return GetValue<System.Single?>("feepoint"); }
            set { _bag["feepoint"] = value; }
        }

        public System.Int32? Status
        {
            get { return GetValue<System.Int32?>("status"); }
            set { _bag["status"] = value; }
        }

        public System.Int32? Created
        {
            get { return GetValue<System.Int32?>("created"); }
            set { _bag["created"] = value; }
        }

        public System.String Createid
        {
            get { return GetValue<System.String>("createid"); }
            set { _bag["createid"] = value; }
        }

        public System.Int16? Cardrule
        {
            get { return GetValue<System.Int16?>("cardrule"); }
            set { _bag["cardrule"] = value; }
        }

        public System.String Remark
        {
            get { return GetValue<System.String>("remark"); }
            set { _bag["remark"] = value; }
        }

        public System.String Province
        {
            get { return GetValue<System.String>("province"); }
            set { _bag["province"] = value; }
        }

        public System.String City
        {
            get { return GetValue<System.String>("city"); }
            set { _bag["city"] = value; }
        }

        public System.String Area
        {
            get { return GetValue<System.String>("area"); }
            set { _bag["area"] = value; }
        }

        public System.Int32 Expdate
        {
            get { return GetValue<System.Int32>("expdate"); }
            set { _bag["expdate"] = value; }
        }

        public System.Int32 Expday
        {
            get { return GetValue<System.Int32>("expday"); }
            set { _bag["expday"] = value; }
        }

        #endregion
        
        #region Read-Only

        /// <summary>
        /// Returns a list of all the modified properties and values.
        /// </summary>
        public Dictionary<string, object> StateBag
        {
            get
            {
                return _bag;
            }
        }

        /// <summary>
        /// Returns a list of all the modified properties and values.
        /// </summary>
        public string TableFullName
        {
            get
            {
                return "[].[base_coupon]";
            }
        }

        #endregion

        #endregion

        #region Overrides
        
        public override string ToString()
        {
            var result = String.Empty;
            var cancel = false;
            
            OnToString(ref result, ref cancel);
            if(cancel && !String.IsNullOrEmpty(result))
                return result;
            
            if (_bag.Count == 0)
                return "No criterion was specified.";

            foreach (KeyValuePair<string, object> key in _bag)
            {
                result += String.Format("[{0}] = '{1}' AND ", key.Key, key.Value);
            }

            return result.Remove(result.Length - 5, 5);
        }

        #endregion

        #region Private Methods
        private T GetValue<T>(string name)
        {
            object value;
            if (_bag.TryGetValue(name, out value))
                return (T) value;
        
            return default(T);
        }
        
        #endregion
        
        #region Partial Methods
        
        partial void OnToString(ref string result, ref bool cancel);
        
        #endregion
        
    }
}