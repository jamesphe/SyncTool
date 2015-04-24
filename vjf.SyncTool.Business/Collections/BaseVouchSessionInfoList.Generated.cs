﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v7.0.1, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BaseVouchSessionInfoList.cs'.
//
//     Template: ReadOnlyList.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;

using Csla;
using Csla.Data;

namespace vjf.SyncTool.Business
{
    [Serializable]
    public partial class BaseVouchSessionInfoList : ReadOnlyListBase<BaseVouchSessionInfoList, BaseVouchSessionInfo>
    {
        #region Contructor(s)

        public BaseVouchSessionInfoList()
        { /* Require use of factory methods */ }

        #endregion
    
        #region Synchronous Factory Methods

        /// <summary>
        /// Returns a <see cref="BaseVouchSessionInfoList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="identification">No additional detail available.</param>
        /// <returns>A <see cref="BaseVouchSessionInfoList"/> object of the specified criteria.</returns>

        public static BaseVouchSessionInfoList GetByIdentification(System.UInt32 identification)
        {
            var criteria = new BaseVouchSessionCriteria{Identification = identification};
            
            
            return DataPortal.Fetch<BaseVouchSessionInfoList>(criteria);
        }
        

        /// <summary>
        /// Returns a <see cref="BaseVouchSessionInfoList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="vouchGroupId">No additional detail available.</param>
        /// <param name="openId">No additional detail available.</param>
        /// <returns>A <see cref="BaseVouchSessionInfoList"/> object of the specified criteria.</returns>

        public static BaseVouchSessionInfoList GetByVouchGroupIdOpenId(System.String vouchGroupId, System.String openId)
        {
            var criteria = new BaseVouchSessionCriteria{VouchGroupId = vouchGroupId, OpenId = openId};
            
            
            return DataPortal.Fetch<BaseVouchSessionInfoList>(criteria);
        }
        

        public static BaseVouchSessionInfoList GetByCriteria(BaseVouchSessionCriteria criteria)
        {
            return DataPortal.Fetch<BaseVouchSessionInfoList>(criteria);
        }

        public static BaseVouchSessionInfoList GetAll()
        {
            return DataPortal.Fetch<BaseVouchSessionInfoList>(new BaseVouchSessionCriteria());
        }

        #endregion

        #region Asynchronous Factory Methods

        public static void GetByIdentificationAsync(System.UInt32 identification, EventHandler<DataPortalResult<BaseVouchSessionInfoList>> handler)
        {
            var criteria = new BaseVouchSessionCriteria{Identification = identification};
            
            
            var dp = new DataPortal<BaseVouchSessionInfoList>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        public static void GetByVouchGroupIdOpenIdAsync(System.String vouchGroupId, System.String openId, EventHandler<DataPortalResult<BaseVouchSessionInfoList>> handler)
        {
            var criteria = new BaseVouchSessionCriteria{VouchGroupId = vouchGroupId, OpenId = openId};
            
            
            var dp = new DataPortal<BaseVouchSessionInfoList>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        public static void GetByCriteriaAsync(BaseVouchSessionCriteria criteria, EventHandler<DataPortalResult<BaseVouchSessionInfoList>> handler)
        {  
            var dp = new DataPortal<BaseVouchSessionInfoList>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        public static void GetAllAsync(EventHandler<DataPortalResult<BaseVouchSessionInfoList>> handler)
        {
            var dp = new DataPortal<BaseVouchSessionInfoList>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(new BaseVouchSessionCriteria());
        }

        #endregion

        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the child <see cref="BaseVouchSessionInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BaseVouchSessionInfo"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the child <see cref="BaseVouchSessionInfo"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BaseVouchSessionInfoCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(BaseVouchSessionCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BaseVouchSessionInfo"/> object has been fetched. 
        /// </summary>
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="BaseVouchSessionInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="BaseVouchSessionInfo"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BaseVouchSessionInfo"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="BaseVouchSessionInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchSessionInfo"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();
        partial void OnAddNewCore(ref BaseVouchSessionInfo item, ref bool cancel);

        #endregion

        #region Exists Command

        /// <summary>
        /// Determines if a record exists in the BaseVouchSessionInfo in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is a <see cref="BaseVouchSessionInfoList"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static bool Exists(BaseVouchSessionCriteria criteria)
        {
            return vjf.SyncTool.Business.BaseVouchSessionInfo.Exists(criteria);
        }
        /// <summary>
        /// Determines if a record exists in the BaseVouchSessionInfo in the database for the specified criteria. 
        /// </summary>
        public static void ExistsAsync(BaseVouchSessionCriteria criteria, EventHandler<DataPortalResult<ExistsCommand>> handler)
        {
            vjf.SyncTool.Business.BaseVouchSessionInfo.ExistsAsync(criteria,handler);
        }

        #endregion
 
        #region Enhancements

        public BaseVouchSessionInfo GetBaseVouchSessionInfo(System.UInt32 identification)
        {
            return this.FirstOrDefault(i => i.Identification == identification);
        }

        public bool Contains(System.UInt32 identification)
        {
            return this.Count(i => i.Identification == identification) > 0;
        }

        #endregion
    }
}