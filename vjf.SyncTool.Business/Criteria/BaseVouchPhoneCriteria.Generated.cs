﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v7.0.1, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BaseVouchPhone.cs'.
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
    public partial class BaseVouchPhoneCriteria : CriteriaBase<BaseVouchPhoneCriteria>, IGeneratedCriteria
    {
        private readonly Dictionary<string, object> _bag = new Dictionary<string, object>();
        
        #region Constructors

        public BaseVouchPhoneCriteria(){}

        public BaseVouchPhoneCriteria(System.String identification)
        {
            this.Identification = identification;
        }

        #endregion

        #region Public Properties

        #region Read-Write

        public System.String Identification
        {
            get { return GetValue<System.String>("id"); }
            set { _bag["id"] = value; }
        }

        public System.Int32? Vid
        {
            get { return GetValue<System.Int32?>("vid"); }
            set { _bag["vid"] = value; }
        }

        public System.String Guid
        {
            get { return GetValue<System.String>("guid"); }
            set { _bag["guid"] = value; }
        }

        public System.String Fid
        {
            get { return GetValue<System.String>("fid"); }
            set { _bag["fid"] = value; }
        }

        public System.String Phone
        {
            get { return GetValue<System.String>("phone"); }
            set { _bag["phone"] = value; }
        }

        public System.Single? Cost
        {
            get { return GetValue<System.Single?>("cost"); }
            set { _bag["cost"] = value; }
        }

        public System.Int16 Type
        {
            get { return GetValue<System.Int16>("type"); }
            set { _bag["type"] = value; }
        }

        public System.Int32? Created
        {
            get { return GetValue<System.Int32?>("created"); }
            set { _bag["created"] = value; }
        }

        public System.Int16? Status
        {
            get { return GetValue<System.Int16?>("status"); }
            set { _bag["status"] = value; }
        }

        public System.Int16? Isover
        {
            get { return GetValue<System.Int16?>("isover"); }
            set { _bag["isover"] = value; }
        }

        public System.String Retmsg
        {
            get { return GetValue<System.String>("retmsg"); }
            set { _bag["retmsg"] = value; }
        }

        public System.Int32 Begindate
        {
            get { return GetValue<System.Int32>("begindate"); }
            set { _bag["begindate"] = value; }
        }

        public System.Int32? Expdate
        {
            get { return GetValue<System.Int32?>("expdate"); }
            set { _bag["expdate"] = value; }
        }

        public System.Int32? Usedate
        {
            get { return GetValue<System.Int32?>("usedate"); }
            set { _bag["usedate"] = value; }
        }

        public System.String City
        {
            get { return GetValue<System.String>("city"); }
            set { _bag["city"] = value; }
        }

        public System.String Product
        {
            get { return GetValue<System.String>("product"); }
            set { _bag["product"] = value; }
        }

        public System.String Store
        {
            get { return GetValue<System.String>("store"); }
            set { _bag["store"] = value; }
        }

        public System.String Paytype
        {
            get { return GetValue<System.String>("paytype"); }
            set { _bag["paytype"] = value; }
        }

        public System.String Usecanal
        {
            get { return GetValue<System.String>("usecanal"); }
            set { _bag["usecanal"] = value; }
        }

        public System.Single Paycost
        {
            get { return GetValue<System.Single>("paycost"); }
            set { _bag["paycost"] = value; }
        }

        public System.Int16 Source
        {
            get { return GetValue<System.Int16>("source"); }
            set { _bag["source"] = value; }
        }

        public System.String Orderid
        {
            get { return GetValue<System.String>("orderid"); }
            set { _bag["orderid"] = value; }
        }

        public System.String Brandid
        {
            get { return GetValue<System.String>("brandid"); }
            set { _bag["brandid"] = value; }
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
                return "].base_vouch_phone]";
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
                result += String.Format("{0} = '{1}' AND ", key.Key, key.Value);
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