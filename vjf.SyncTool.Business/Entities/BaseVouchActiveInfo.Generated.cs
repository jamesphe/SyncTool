﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v7.0.1, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BaseVouchActiveInfo.cs'.
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
    public partial class BaseVouchActiveInfo : ReadOnlyBase<BaseVouchActiveInfo>
    {
        #region Contructor(s)

        public BaseVouchActiveInfo()
        { /* Require use of factory methods */ }

        #endregion

        #region Properties

        public static readonly PropertyInfo<System.String> _identificationProperty = RegisterProperty<System.String>(p => p.Identification, "Identification");

        [System.ComponentModel.DataObjectField(true, false)]
        public System.String Identification
        {
            get { return GetProperty(_identificationProperty); }
        }

        public static readonly PropertyInfo<System.String> _titleProperty = RegisterProperty<System.String>(p => p.Title, "Title", (System.String)null);

        public System.String Title
        {
            get { return GetProperty(_titleProperty); }
        }

        public static readonly PropertyInfo<System.Int32?> _begindateProperty = RegisterProperty<System.Int32?>(p => p.Begindate, "Begindate", (System.Int32?)null);

        public System.Int32? Begindate
        {
            get { return GetProperty(_begindateProperty); }
        }

        public static readonly PropertyInfo<System.Int32?> _enddateProperty = RegisterProperty<System.Int32?>(p => p.Enddate, "Enddate", (System.Int32?)null);

        public System.Int32? Enddate
        {
            get { return GetProperty(_enddateProperty); }
        }

        public static readonly PropertyInfo<System.String> _vouchidProperty = RegisterProperty<System.String>(p => p.Vouchid, "Vouchid", (System.String)null);

        public System.String Vouchid
        {
            get { return GetProperty(_vouchidProperty); }
        }

        public static readonly PropertyInfo<System.Int32?> _vouchnumProperty = RegisterProperty<System.Int32?>(p => p.Vouchnum, "Vouchnum", (System.Int32?)null);

        public System.Int32? Vouchnum
        {
            get { return GetProperty(_vouchnumProperty); }
        }

        public static readonly PropertyInfo<System.Int32?> _usernumProperty = RegisterProperty<System.Int32?>(p => p.Usernum, "Usernum", (System.Int32?)null);

        public System.Int32? Usernum
        {
            get { return GetProperty(_usernumProperty); }
        }

        public static readonly PropertyInfo<System.Int32?> _lnumProperty = RegisterProperty<System.Int32?>(p => p.Lnum, "Lnum", (System.Int32?)null);

        public System.Int32? Lnum
        {
            get { return GetProperty(_lnumProperty); }
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

        public static readonly PropertyInfo<System.Int32?> _updatedProperty = RegisterProperty<System.Int32?>(p => p.Updated, "Updated", (System.Int32?)null);

        public System.Int32? Updated
        {
            get { return GetProperty(_updatedProperty); }
        }


        #endregion

        #region Synchronous Factory Methods 

        internal static BaseVouchActiveInfo GetBaseVouchActiveInfo(SafeDataReader reader)
        {
            return DataPortal.FetchChild<BaseVouchActiveInfo>(reader);
        }

        /// <summary>
        /// Returns a <see cref="BaseVouchActiveInfo"/> object of the specified criteria. 
        /// </summary>
        /// <param name="identification">No additional detail available.</param>
        /// <returns>A <see cref="BaseVouchActiveInfo"/> object of the specified criteria.</returns>
        public static BaseVouchActiveInfo GetByIdentification(System.String identification)
        {
            var criteria = new BaseVouchActiveCriteria {Identification = identification};
            
            
            return DataPortal.Fetch<BaseVouchActiveInfo>(criteria);
        }

        #endregion

        #region Asynchronous Factory Methods

        public static void GetByIdentificationAsync(System.String identification, EventHandler<DataPortalResult<BaseVouchActiveInfo>> handler)
        {
            var criteria = new BaseVouchActiveCriteria{Identification = identification};
            
            
            var dp = new DataPortal<BaseVouchActiveInfo>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        #endregion

        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the <see cref="BaseVouchActiveInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchActiveInfo"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the <see cref="BaseVouchActiveInfo"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BaseVouchActiveInfoCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(BaseVouchActiveCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchActiveInfo"/> object has been fetched. 
        /// </summary>    
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="BaseVouchActiveInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);
 
        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="BaseVouchActiveInfo"/> object. 
        /// </summary>
        /// <param name="reader["></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchActiveInfo"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the <see cref="BaseVouchActiveInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnInserting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchActiveInfo"/> object has been inserted. 
        /// </summary>
        partial void OnInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="BaseVouchActiveInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchActiveInfo"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the <see cref="BaseVouchActiveInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchActiveInfo"/> object has been deleted. 
        /// </summary>
        partial void OnSelfDeleted();

        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the <see cref="BaseVouchActiveInfo"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BaseVouchActiveInfoCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(BaseVouchActiveCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchActiveInfo"/> object with the specified criteria has been deleted. 
        /// </summary>
        partial void OnDeleted();
        partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion

        #region Exists Command

        /// <summary>
        /// Determines if a record exists in the base_vouch_active table in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is an <see cref="BaseVouchActiveInfo"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static bool Exists(BaseVouchActiveCriteria criteria)
        {
            return vjf.SyncTool.Business.ExistsCommand.Execute(criteria);
        }

        /// <summary>
        /// Determines if a record exists in the base_vouch_active table in the database for the specified criteria. 
        /// </summary>
        public static void ExistsAsync(BaseVouchActiveCriteria criteria, EventHandler<DataPortalResult<ExistsCommand>> handler)
        {
            vjf.SyncTool.Business.ExistsCommand.ExecuteAsync(criteria, handler);
        }

        #endregion

    }
}