﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v7.0.1, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BaseCouponCodeInfo.cs'.
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
    public partial class BaseCouponCodeInfo : ReadOnlyBase<BaseCouponCodeInfo>
    {
        #region Contructor(s)

        public BaseCouponCodeInfo()
        { /* Require use of factory methods */ }

        #endregion

        #region Properties

        public static readonly PropertyInfo<System.Int32> _identificationProperty = RegisterProperty<System.Int32>(p => p.Identification, "Identification");

        [System.ComponentModel.DataObjectField(true, true)]
        public System.Int32 Identification
        {
            get { return GetProperty(_identificationProperty); }
        }

        public static readonly PropertyInfo<System.String> _codeProperty = RegisterProperty<System.String>(p => p.Code, "Code", (System.String)null);

        public System.String Code
        {
            get { return GetProperty(_codeProperty); }
        }

        public static readonly PropertyInfo<System.Int16?> _statusProperty = RegisterProperty<System.Int16?>(p => p.Status, "Status", (System.Int16?)null);

        public System.Int16? Status
        {
            get { return GetProperty(_statusProperty); }
        }

        public static readonly PropertyInfo<System.Int32?> _createdProperty = RegisterProperty<System.Int32?>(p => p.Created, "Created", (System.Int32?)null);

        public System.Int32? Created
        {
            get { return GetProperty(_createdProperty); }
        }

        public static readonly PropertyInfo<System.Int32?> _lytimeProperty = RegisterProperty<System.Int32?>(p => p.Lytime, "Lytime", (System.Int32?)null);

        public System.Int32? Lytime
        {
            get { return GetProperty(_lytimeProperty); }
        }

        public static readonly PropertyInfo<System.String> _lyfidProperty = RegisterProperty<System.String>(p => p.Lyfid, "Lyfid", (System.String)null);

        public System.String Lyfid
        {
            get { return GetProperty(_lyfidProperty); }
        }

        public static readonly PropertyInfo<System.String> _batchnoProperty = RegisterProperty<System.String>(p => p.Batchno, "Batchno", (System.String)null);

        public System.String Batchno
        {
            get { return GetProperty(_batchnoProperty); }
        }


        #endregion

        #region Synchronous Factory Methods 

        internal static BaseCouponCodeInfo GetBaseCouponCodeInfo(SafeDataReader reader)
        {
            return DataPortal.FetchChild<BaseCouponCodeInfo>(reader);
        }

        /// <summary>
        /// Returns a <see cref="BaseCouponCodeInfo"/> object of the specified criteria. 
        /// </summary>
        /// <param name="identification">No additional detail available.</param>
        /// <returns>A <see cref="BaseCouponCodeInfo"/> object of the specified criteria.</returns>
        public static BaseCouponCodeInfo GetByIdentification(System.Int32 identification)
        {
            var criteria = new BaseCouponCodeCriteria {Identification = identification};
            
            
            return DataPortal.Fetch<BaseCouponCodeInfo>(criteria);
        }

        #endregion

        #region Asynchronous Factory Methods

        public static void GetByIdentificationAsync(System.Int32 identification, EventHandler<DataPortalResult<BaseCouponCodeInfo>> handler)
        {
            var criteria = new BaseCouponCodeCriteria{Identification = identification};
            
            
            var dp = new DataPortal<BaseCouponCodeInfo>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        #endregion

        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the <see cref="BaseCouponCodeInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseCouponCodeInfo"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the <see cref="BaseCouponCodeInfo"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BaseCouponCodeInfoCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(BaseCouponCodeCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseCouponCodeInfo"/> object has been fetched. 
        /// </summary>    
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="BaseCouponCodeInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);
 
        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="BaseCouponCodeInfo"/> object. 
        /// </summary>
        /// <param name="reader["></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseCouponCodeInfo"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the <see cref="BaseCouponCodeInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnInserting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseCouponCodeInfo"/> object has been inserted. 
        /// </summary>
        partial void OnInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="BaseCouponCodeInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseCouponCodeInfo"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the <see cref="BaseCouponCodeInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseCouponCodeInfo"/> object has been deleted. 
        /// </summary>
        partial void OnSelfDeleted();

        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the <see cref="BaseCouponCodeInfo"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BaseCouponCodeInfoCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(BaseCouponCodeCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseCouponCodeInfo"/> object with the specified criteria has been deleted. 
        /// </summary>
        partial void OnDeleted();
        partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion

        #region Exists Command

        /// <summary>
        /// Determines if a record exists in the base_coupon_code table in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is an <see cref="BaseCouponCodeInfo"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static bool Exists(BaseCouponCodeCriteria criteria)
        {
            return vjf.SyncTool.Business.ExistsCommand.Execute(criteria);
        }

        /// <summary>
        /// Determines if a record exists in the base_coupon_code table in the database for the specified criteria. 
        /// </summary>
        public static void ExistsAsync(BaseCouponCodeCriteria criteria, EventHandler<DataPortalResult<ExistsCommand>> handler)
        {
            vjf.SyncTool.Business.ExistsCommand.ExecuteAsync(criteria, handler);
        }

        #endregion

    }
}