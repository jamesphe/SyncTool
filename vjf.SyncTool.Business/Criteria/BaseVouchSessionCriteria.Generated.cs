﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v7.0.1, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BaseVouchSession.cs'.
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
    public partial class BaseVouchSessionCriteria : CriteriaBase<BaseVouchSessionCriteria>, IGeneratedCriteria
    {
        private readonly Dictionary<string, object> _bag = new Dictionary<string, object>();
        
        #region Constructors

        public BaseVouchSessionCriteria(){}

        public BaseVouchSessionCriteria(System.UInt32 identification)
        {
            this.Identification = identification;
        }

        #endregion

        #region Public Properties

        #region Read-Write

        public System.UInt32 Identification
        {
            get { return GetValue<System.UInt32>("id"); }
            set { _bag["id"] = value; }
        }

        public System.String VouchGroupId
        {
            get { return GetValue<System.String>("vouch_group_id"); }
            set { _bag["vouch_group_id"] = value; }
        }

        public System.String OpenId
        {
            get { return GetValue<System.String>("open_id"); }
            set { _bag["open_id"] = value; }
        }

        public System.UInt32? VouchId
        {
            get { return GetValue<System.UInt32?>("vouch_id"); }
            set { _bag["vouch_id"] = value; }
        }

        public System.SByte? Success
        {
            get { return GetValue<System.SByte?>("success"); }
            set { _bag["success"] = value; }
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
                return "[].[base_vouch_session]";
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