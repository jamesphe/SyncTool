﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v7.0.1, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BaseCouponInfoList.cs'.
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
    public partial class BaseCouponInfoList : ReadOnlyListBase<BaseCouponInfoList, BaseCouponInfo>
    {
        #region Contructor(s)

        public BaseCouponInfoList()
        { /* Require use of factory methods */ }

        #endregion
    
        #region Synchronous Factory Methods

        /// <summary>
        /// Returns a <see cref="BaseCouponInfoList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="identification">No additional detail available.</param>
        /// <returns>A <see cref="BaseCouponInfoList"/> object of the specified criteria.</returns>

        public static BaseCouponInfoList GetByIdentification(System.Int32 identification)
        {
            var criteria = new BaseCouponCriteria{Identification = identification};
            
            
            return DataPortal.Fetch<BaseCouponInfoList>(criteria);
        }
        

        public static BaseCouponInfoList GetByCriteria(BaseCouponCriteria criteria)
        {
            return DataPortal.Fetch<BaseCouponInfoList>(criteria);
        }

        public static BaseCouponInfoList GetAll()
        {
            return DataPortal.Fetch<BaseCouponInfoList>(new BaseCouponCriteria());
        }

        #endregion

        #region Asynchronous Factory Methods

        public static void GetByIdentificationAsync(System.Int32 identification, EventHandler<DataPortalResult<BaseCouponInfoList>> handler)
        {
            var criteria = new BaseCouponCriteria{Identification = identification};
            
            
            var dp = new DataPortal<BaseCouponInfoList>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        public static void GetByCriteriaAsync(BaseCouponCriteria criteria, EventHandler<DataPortalResult<BaseCouponInfoList>> handler)
        {  
            var dp = new DataPortal<BaseCouponInfoList>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        public static void GetAllAsync(EventHandler<DataPortalResult<BaseCouponInfoList>> handler)
        {
            var dp = new DataPortal<BaseCouponInfoList>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(new BaseCouponCriteria());
        }

        #endregion

        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the child <see cref="BaseCouponInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BaseCouponInfo"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the child <see cref="BaseCouponInfo"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BaseCouponInfoCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(BaseCouponCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BaseCouponInfo"/> object has been fetched. 
        /// </summary>
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="BaseCouponInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the child <see cref="BaseCouponInfo"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="BaseCouponInfo"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="BaseCouponInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseCouponInfo"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();
        partial void OnAddNewCore(ref BaseCouponInfo item, ref bool cancel);

        #endregion

        #region Exists Command

        /// <summary>
        /// Determines if a record exists in the BaseCouponInfo in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is a <see cref="BaseCouponInfoList"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static bool Exists(BaseCouponCriteria criteria)
        {
            return vjf.SyncTool.Business.BaseCouponInfo.Exists(criteria);
        }
        /// <summary>
        /// Determines if a record exists in the BaseCouponInfo in the database for the specified criteria. 
        /// </summary>
        public static void ExistsAsync(BaseCouponCriteria criteria, EventHandler<DataPortalResult<ExistsCommand>> handler)
        {
            vjf.SyncTool.Business.BaseCouponInfo.ExistsAsync(criteria,handler);
        }

        #endregion
 
        #region Enhancements

        public BaseCouponInfo GetBaseCouponInfo(System.Int32 identification)
        {
            return this.FirstOrDefault(i => i.Identification == identification);
        }

        public bool Contains(System.Int32 identification)
        {
            return this.Count(i => i.Identification == identification) > 0;
        }

        #endregion
    }
}