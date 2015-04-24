﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v7.0.1, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BaseVouchActive.cs'.
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
    public partial class BaseVouchActiveCriteria : CriteriaBase<BaseVouchActiveCriteria>, IGeneratedCriteria
    {
        private readonly Dictionary<string, object> _bag = new Dictionary<string, object>();
        
        #region Constructors

        public BaseVouchActiveCriteria(){}

        public BaseVouchActiveCriteria(System.String identification)
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

        public System.String Title
        {
            get { return GetValue<System.String>("title"); }
            set { _bag["title"] = value; }
        }

        public System.Int32? Begindate
        {
            get { return GetValue<System.Int32?>("begindate"); }
            set { _bag["begindate"] = value; }
        }

        public System.Int32? Enddate
        {
            get { return GetValue<System.Int32?>("enddate"); }
            set { _bag["enddate"] = value; }
        }

        public System.String Vouchid
        {
            get { return GetValue<System.String>("vouchid"); }
            set { _bag["vouchid"] = value; }
        }

        public System.Int32? Vouchnum
        {
            get { return GetValue<System.Int32?>("vouchnum"); }
            set { _bag["vouchnum"] = value; }
        }

        public System.Int32? Usernum
        {
            get { return GetValue<System.Int32?>("usernum"); }
            set { _bag["usernum"] = value; }
        }

        public System.Int32? Lnum
        {
            get { return GetValue<System.Int32?>("lnum"); }
            set { _bag["lnum"] = value; }
        }

        public System.Int16? Status
        {
            get { return GetValue<System.Int16?>("status"); }
            set { _bag["status"] = value; }
        }

        public System.Int32? Created
        {
            get { return GetValue<System.Int32?>("created"); }
            set { _bag["created"] = value; }
        }

        public System.Int32? Updated
        {
            get { return GetValue<System.Int32?>("updated"); }
            set { _bag["updated"] = value; }
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
                return "[].[base_vouch_active]";
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