﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v7.0.1, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BaseVouchSessionInfo.cs'.
//
//     Template: ReadOnlyRoot.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
using System;

using Csla;
using Csla.Data;

namespace vjf.SyncTool.Business
{
    [Serializable]
    public partial class BaseVouchSessionInfo : ReadOnlyBase<BaseVouchSessionInfo>
    {
        #region Contructor(s)

        public BaseVouchSessionInfo()
        { /* Require use of factory methods */ }

        #endregion

        #region Properties

        public static readonly PropertyInfo<System.UInt32> _identificationProperty = RegisterProperty<System.UInt32>(p => p.Identification, "Identification");

        [System.ComponentModel.DataObjectField(true, true)]
        public System.UInt32 Identification
        {
            get { return GetProperty(_identificationProperty); }
        }

        public static readonly PropertyInfo<System.String> _vouchGroupIdProperty = RegisterProperty<System.String>(p => p.VouchGroupId, "Vouch Group Id");

        public System.String VouchGroupId
        {
            get { return GetProperty(_vouchGroupIdProperty); }
        }

        public static readonly PropertyInfo<System.String> _openIdProperty = RegisterProperty<System.String>(p => p.OpenId, "Open Id");

        public System.String OpenId
        {
            get { return GetProperty(_openIdProperty); }
        }

        public static readonly PropertyInfo<System.UInt32?> _vouchIdProperty = RegisterProperty<System.UInt32?>(p => p.VouchId, "Vouch Id", (System.UInt32?)null);

        public System.UInt32? VouchId
        {
            get { return GetProperty(_vouchIdProperty); }
        }

        public static readonly PropertyInfo<System.SByte?> _successProperty = RegisterProperty<System.SByte?>(p => p.Success, "Success", (System.SByte?)null);

        public System.SByte? Success
        {
            get { return GetProperty(_successProperty); }
        }


        #endregion

        #region Synchronous Factory Methods 

        internal static BaseVouchSessionInfo GetBaseVouchSessionInfo(SafeDataReader reader)
        {
            return DataPortal.FetchChild<BaseVouchSessionInfo>(reader);
        }

        /// <summary>
        /// Returns a <see cref="BaseVouchSessionInfo"/> object of the specified criteria. 
        /// </summary>
        /// <param name="identification">No additional detail available.</param>
        /// <returns>A <see cref="BaseVouchSessionInfo"/> object of the specified criteria.</returns>
        public static BaseVouchSessionInfo GetByIdentification(System.UInt32 identification)
        {
            var criteria = new BaseVouchSessionCriteria {Identification = identification};
            
            
            return DataPortal.Fetch<BaseVouchSessionInfo>(criteria);
        }

        /// <summary>
        /// Returns a <see cref="BaseVouchSessionInfo"/> object of the specified criteria. 
        /// </summary>
        /// <param name="vouchGroupId">No additional detail available.</param>
        /// <param name="openId">No additional detail available.</param>
        /// <returns>A <see cref="BaseVouchSessionInfo"/> object of the specified criteria.</returns>
        public static BaseVouchSessionInfo GetByVouchGroupIdOpenId(System.String vouchGroupId, System.String openId)
        {
            var criteria = new BaseVouchSessionCriteria {VouchGroupId = vouchGroupId, OpenId = openId};
            
            
            return DataPortal.Fetch<BaseVouchSessionInfo>(criteria);
        }

        #endregion

        #region Asynchronous Factory Methods

        public static void GetByIdentificationAsync(System.UInt32 identification, EventHandler<DataPortalResult<BaseVouchSessionInfo>> handler)
        {
            var criteria = new BaseVouchSessionCriteria{Identification = identification};
            
            
            var dp = new DataPortal<BaseVouchSessionInfo>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        public static void GetByVouchGroupIdOpenIdAsync(System.String vouchGroupId, System.String openId, EventHandler<DataPortalResult<BaseVouchSessionInfo>> handler)
        {
            var criteria = new BaseVouchSessionCriteria{VouchGroupId = vouchGroupId, OpenId = openId};
            
            
            var dp = new DataPortal<BaseVouchSessionInfo>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        #endregion

        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the <see cref="BaseVouchSessionInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchSessionInfo"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the <see cref="BaseVouchSessionInfo"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BaseVouchSessionInfoCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(BaseVouchSessionCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchSessionInfo"/> object has been fetched. 
        /// </summary>    
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="BaseVouchSessionInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);
 
        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="BaseVouchSessionInfo"/> object. 
        /// </summary>
        /// <param name="reader["></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchSessionInfo"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the <see cref="BaseVouchSessionInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnInserting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchSessionInfo"/> object has been inserted. 
        /// </summary>
        partial void OnInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="BaseVouchSessionInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchSessionInfo"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the <see cref="BaseVouchSessionInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchSessionInfo"/> object has been deleted. 
        /// </summary>
        partial void OnSelfDeleted();

        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the <see cref="BaseVouchSessionInfo"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BaseVouchSessionInfoCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(BaseVouchSessionCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchSessionInfo"/> object with the specified criteria has been deleted. 
        /// </summary>
        partial void OnDeleted();
        partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion

        #region Exists Command

        /// <summary>
        /// Determines if a record exists in the base_vouch_session table in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is an <see cref="BaseVouchSessionInfo"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static bool Exists(BaseVouchSessionCriteria criteria)
        {
            return vjf.SyncTool.Business.ExistsCommand.Execute(criteria);
        }

        /// <summary>
        /// Determines if a record exists in the base_vouch_session table in the database for the specified criteria. 
        /// </summary>
        public static void ExistsAsync(BaseVouchSessionCriteria criteria, EventHandler<DataPortalResult<ExistsCommand>> handler)
        {
            vjf.SyncTool.Business.ExistsCommand.ExecuteAsync(criteria, handler);
        }

        #endregion

    }
}