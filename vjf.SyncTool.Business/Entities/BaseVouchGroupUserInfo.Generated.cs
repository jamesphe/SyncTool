﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v7.0.1, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BaseVouchGroupUserInfo.cs'.
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
    public partial class BaseVouchGroupUserInfo : ReadOnlyBase<BaseVouchGroupUserInfo>
    {
        #region Contructor(s)

        public BaseVouchGroupUserInfo()
        { /* Require use of factory methods */ }

        #endregion

        #region Properties

        public static readonly PropertyInfo<System.String> _identificationProperty = RegisterProperty<System.String>(p => p.Identification, "Identification");

        [System.ComponentModel.DataObjectField(true, false)]
        public System.String Identification
        {
            get { return GetProperty(_identificationProperty); }
        }

        public static readonly PropertyInfo<System.String> _fidProperty = RegisterProperty<System.String>(p => p.Fid, "Fid", (System.String)null);

        public System.String Fid
        {
            get { return GetProperty(_fidProperty); }
        }

        public static readonly PropertyInfo<System.String> _vouchGidProperty = RegisterProperty<System.String>(p => p.VouchGid, "Vouch Gid", (System.String)null);

        public System.String VouchGid
        {
            get { return GetProperty(_vouchGidProperty); }
        }

        public static readonly PropertyInfo<System.String> _orderIdProperty = RegisterProperty<System.String>(p => p.OrderId, "Order Id", (System.String)null);

        public System.String OrderId
        {
            get { return GetProperty(_orderIdProperty); }
        }

        public static readonly PropertyInfo<System.Int32?> _vouchNumProperty = RegisterProperty<System.Int32?>(p => p.VouchNum, "Vouch Num", (System.Int32?)null);

        public System.Int32? VouchNum
        {
            get { return GetProperty(_vouchNumProperty); }
        }

        public static readonly PropertyInfo<System.Int32?> _lnumProperty = RegisterProperty<System.Int32?>(p => p.Lnum, "Lnum", (System.Int32?)null);

        public System.Int32? Lnum
        {
            get { return GetProperty(_lnumProperty); }
        }

        public static readonly PropertyInfo<System.Int32?> _createdProperty = RegisterProperty<System.Int32?>(p => p.Created, "Created", (System.Int32?)null);

        public System.Int32? Created
        {
            get { return GetProperty(_createdProperty); }
        }

        public static readonly PropertyInfo<System.Int32?> _updatedProperty = RegisterProperty<System.Int32?>(p => p.Updated, "Updated", (System.Int32?)null);

        public System.Int32? Updated
        {
            get { return GetProperty(_updatedProperty); }
        }


        #endregion

        #region Synchronous Factory Methods 

        internal static BaseVouchGroupUserInfo GetBaseVouchGroupUserInfo(SafeDataReader reader)
        {
            return DataPortal.FetchChild<BaseVouchGroupUserInfo>(reader);
        }

        /// <summary>
        /// Returns a <see cref="BaseVouchGroupUserInfo"/> object of the specified criteria. 
        /// </summary>
        /// <param name="identification">No additional detail available.</param>
        /// <returns>A <see cref="BaseVouchGroupUserInfo"/> object of the specified criteria.</returns>
        public static BaseVouchGroupUserInfo GetByIdentification(System.String identification)
        {
            var criteria = new BaseVouchGroupUserCriteria {Identification = identification};
            
            
            return DataPortal.Fetch<BaseVouchGroupUserInfo>(criteria);
        }

        /// <summary>
        /// Returns a <see cref="BaseVouchGroupUserInfo"/> object of the specified criteria. 
        /// </summary>
        /// <param name="fid">No additional detail available.</param>
        /// <returns>A <see cref="BaseVouchGroupUserInfo"/> object of the specified criteria.</returns>
        public static BaseVouchGroupUserInfo GetByFid(System.String fid)
        {
            var criteria = new BaseVouchGroupUserCriteria {Fid = fid};
            
            
            return DataPortal.Fetch<BaseVouchGroupUserInfo>(criteria);
        }

        /// <summary>
        /// Returns a <see cref="BaseVouchGroupUserInfo"/> object of the specified criteria. 
        /// </summary>
        /// <param name="orderId">No additional detail available.</param>
        /// <returns>A <see cref="BaseVouchGroupUserInfo"/> object of the specified criteria.</returns>
        public static BaseVouchGroupUserInfo GetByOrderId(System.String orderId)
        {
            var criteria = new BaseVouchGroupUserCriteria {OrderId = orderId};
            
            
            return DataPortal.Fetch<BaseVouchGroupUserInfo>(criteria);
        }

        /// <summary>
        /// Returns a <see cref="BaseVouchGroupUserInfo"/> object of the specified criteria. 
        /// </summary>
        /// <param name="vouchGid">No additional detail available.</param>
        /// <returns>A <see cref="BaseVouchGroupUserInfo"/> object of the specified criteria.</returns>
        public static BaseVouchGroupUserInfo GetByVouchGid(System.String vouchGid)
        {
            var criteria = new BaseVouchGroupUserCriteria {VouchGid = vouchGid};
            
            
            return DataPortal.Fetch<BaseVouchGroupUserInfo>(criteria);
        }

        #endregion

        #region Asynchronous Factory Methods

        public static void GetByIdentificationAsync(System.String identification, EventHandler<DataPortalResult<BaseVouchGroupUserInfo>> handler)
        {
            var criteria = new BaseVouchGroupUserCriteria{Identification = identification};
            
            
            var dp = new DataPortal<BaseVouchGroupUserInfo>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        public static void GetByFidAsync(System.String fid, EventHandler<DataPortalResult<BaseVouchGroupUserInfo>> handler)
        {
            var criteria = new BaseVouchGroupUserCriteria{Fid = fid};
            
            
            var dp = new DataPortal<BaseVouchGroupUserInfo>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        public static void GetByOrderIdAsync(System.String orderId, EventHandler<DataPortalResult<BaseVouchGroupUserInfo>> handler)
        {
            var criteria = new BaseVouchGroupUserCriteria{OrderId = orderId};
            
            
            var dp = new DataPortal<BaseVouchGroupUserInfo>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        public static void GetByVouchGidAsync(System.String vouchGid, EventHandler<DataPortalResult<BaseVouchGroupUserInfo>> handler)
        {
            var criteria = new BaseVouchGroupUserCriteria{VouchGid = vouchGid};
            
            
            var dp = new DataPortal<BaseVouchGroupUserInfo>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        #endregion

        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the <see cref="BaseVouchGroupUserInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchGroupUserInfo"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the <see cref="BaseVouchGroupUserInfo"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BaseVouchGroupUserInfoCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(BaseVouchGroupUserCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchGroupUserInfo"/> object has been fetched. 
        /// </summary>    
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="BaseVouchGroupUserInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);
 
        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="BaseVouchGroupUserInfo"/> object. 
        /// </summary>
        /// <param name="reader["></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchGroupUserInfo"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the <see cref="BaseVouchGroupUserInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnInserting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchGroupUserInfo"/> object has been inserted. 
        /// </summary>
        partial void OnInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="BaseVouchGroupUserInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchGroupUserInfo"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the <see cref="BaseVouchGroupUserInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchGroupUserInfo"/> object has been deleted. 
        /// </summary>
        partial void OnSelfDeleted();

        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the <see cref="BaseVouchGroupUserInfo"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BaseVouchGroupUserInfoCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(BaseVouchGroupUserCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchGroupUserInfo"/> object with the specified criteria has been deleted. 
        /// </summary>
        partial void OnDeleted();
        partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion

        #region Exists Command

        /// <summary>
        /// Determines if a record exists in the base_vouch_group_user table in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is an <see cref="BaseVouchGroupUserInfo"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static bool Exists(BaseVouchGroupUserCriteria criteria)
        {
            return vjf.SyncTool.Business.ExistsCommand.Execute(criteria);
        }

        /// <summary>
        /// Determines if a record exists in the base_vouch_group_user table in the database for the specified criteria. 
        /// </summary>
        public static void ExistsAsync(BaseVouchGroupUserCriteria criteria, EventHandler<DataPortalResult<ExistsCommand>> handler)
        {
            vjf.SyncTool.Business.ExistsCommand.ExecuteAsync(criteria, handler);
        }

        #endregion

    }
}