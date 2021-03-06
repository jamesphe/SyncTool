﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v7.0.1, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BaseVouchPhoneInfo.cs'.
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
    public partial class BaseVouchPhoneInfo : ReadOnlyBase<BaseVouchPhoneInfo>
    {
        #region Contructor(s)

        public BaseVouchPhoneInfo()
        { /* Require use of factory methods */ }

        #endregion

        #region Properties

        public static readonly PropertyInfo<System.String> _identificationProperty = RegisterProperty<System.String>(p => p.Identification, "Identification");

        [System.ComponentModel.DataObjectField(true, false)]
        public System.String Identification
        {
            get { return GetProperty(_identificationProperty); }
        }

        public static readonly PropertyInfo<System.Int32?> _vidProperty = RegisterProperty<System.Int32?>(p => p.Vid, "Vid", (System.Int32?)null);

        public System.Int32? Vid
        {
            get { return GetProperty(_vidProperty); }
        }

        public static readonly PropertyInfo<System.String> _guidProperty = RegisterProperty<System.String>(p => p.Guid, "Guid");

        public System.String Guid
        {
            get { return GetProperty(_guidProperty); }
        }

        public static readonly PropertyInfo<System.String> _fidProperty = RegisterProperty<System.String>(p => p.Fid, "Fid", (System.String)null);

        public System.String Fid
        {
            get { return GetProperty(_fidProperty); }
        }

        public static readonly PropertyInfo<System.String> _phoneProperty = RegisterProperty<System.String>(p => p.Phone, "Phone", (System.String)null);

        public System.String Phone
        {
            get { return GetProperty(_phoneProperty); }
        }

        public static readonly PropertyInfo<System.Single?> _costProperty = RegisterProperty<System.Single?>(p => p.Cost, "Cost", (System.Single?)null);

        public System.Single? Cost
        {
            get { return GetProperty(_costProperty); }
        }

        public static readonly PropertyInfo<System.Int16> _typeProperty = RegisterProperty<System.Int16>(p => p.Type, "Type");

        public System.Int16 Type
        {
            get { return GetProperty(_typeProperty); }
        }

        public static readonly PropertyInfo<System.Int32?> _createdProperty = RegisterProperty<System.Int32?>(p => p.Created, "Created", (System.Int32?)null);

        public System.Int32? Created
        {
            get { return GetProperty(_createdProperty); }
        }

        public static readonly PropertyInfo<System.Int16?> _statusProperty = RegisterProperty<System.Int16?>(p => p.Status, "Status", (System.Int16?)null);

        public System.Int16? Status
        {
            get { return GetProperty(_statusProperty); }
        }

        public static readonly PropertyInfo<System.Int16?> _isoverProperty = RegisterProperty<System.Int16?>(p => p.Isover, "Isover", (System.Int16?)null);

        public System.Int16? Isover
        {
            get { return GetProperty(_isoverProperty); }
        }

        public static readonly PropertyInfo<System.String> _retmsgProperty = RegisterProperty<System.String>(p => p.Retmsg, "Retmsg", (System.String)null);

        public System.String Retmsg
        {
            get { return GetProperty(_retmsgProperty); }
        }

        public static readonly PropertyInfo<System.Int32> _begindateProperty = RegisterProperty<System.Int32>(p => p.Begindate, "Begindate");

        public System.Int32 Begindate
        {
            get { return GetProperty(_begindateProperty); }
        }

        public static readonly PropertyInfo<System.Int32?> _expdateProperty = RegisterProperty<System.Int32?>(p => p.Expdate, "Expdate", (System.Int32?)null);

        public System.Int32? Expdate
        {
            get { return GetProperty(_expdateProperty); }
        }

        public static readonly PropertyInfo<System.Int32?> _usedateProperty = RegisterProperty<System.Int32?>(p => p.Usedate, "Usedate", (System.Int32?)null);

        public System.Int32? Usedate
        {
            get { return GetProperty(_usedateProperty); }
        }

        public static readonly PropertyInfo<System.String> _cityProperty = RegisterProperty<System.String>(p => p.City, "City");

        public System.String City
        {
            get { return GetProperty(_cityProperty); }
        }

        public static readonly PropertyInfo<System.String> _productProperty = RegisterProperty<System.String>(p => p.Product, "Product");

        public System.String Product
        {
            get { return GetProperty(_productProperty); }
        }

        public static readonly PropertyInfo<System.String> _storeProperty = RegisterProperty<System.String>(p => p.Store, "Store");

        public System.String Store
        {
            get { return GetProperty(_storeProperty); }
        }

        public static readonly PropertyInfo<System.String> _paytypeProperty = RegisterProperty<System.String>(p => p.Paytype, "Paytype");

        public System.String Paytype
        {
            get { return GetProperty(_paytypeProperty); }
        }

        public static readonly PropertyInfo<System.String> _usecanalProperty = RegisterProperty<System.String>(p => p.Usecanal, "Usecanal");

        public System.String Usecanal
        {
            get { return GetProperty(_usecanalProperty); }
        }

        public static readonly PropertyInfo<System.Single> _paycostProperty = RegisterProperty<System.Single>(p => p.Paycost, "Paycost");

        public System.Single Paycost
        {
            get { return GetProperty(_paycostProperty); }
        }

        public static readonly PropertyInfo<System.Int16> _sourceProperty = RegisterProperty<System.Int16>(p => p.Source, "Source");

        public System.Int16 Source
        {
            get { return GetProperty(_sourceProperty); }
        }

        public static readonly PropertyInfo<System.String> _orderidProperty = RegisterProperty<System.String>(p => p.Orderid, "Orderid");

        public System.String Orderid
        {
            get { return GetProperty(_orderidProperty); }
        }

        public static readonly PropertyInfo<System.String> _brandidProperty = RegisterProperty<System.String>(p => p.Brandid, "Brandid");

        public System.String Brandid
        {
            get { return GetProperty(_brandidProperty); }
        }


        #endregion

        #region Synchronous Factory Methods 

        internal static BaseVouchPhoneInfo GetBaseVouchPhoneInfo(SafeDataReader reader)
        {
            return DataPortal.FetchChild<BaseVouchPhoneInfo>(reader);
        }

        /// <summary>
        /// Returns a <see cref="BaseVouchPhoneInfo"/> object of the specified criteria. 
        /// </summary>
        /// <param name="identification">No additional detail available.</param>
        /// <returns>A <see cref="BaseVouchPhoneInfo"/> object of the specified criteria.</returns>
        public static BaseVouchPhoneInfo GetByIdentification(System.String identification)
        {
            var criteria = new BaseVouchPhoneCriteria {Identification = identification};
            
            
            return DataPortal.Fetch<BaseVouchPhoneInfo>(criteria);
        }

        /// <summary>
        /// Returns a <see cref="BaseVouchPhoneInfo"/> object of the specified criteria. 
        /// </summary>
        /// <param name="phone">No additional detail available.</param>
        /// <returns>A <see cref="BaseVouchPhoneInfo"/> object of the specified criteria.</returns>
        public static BaseVouchPhoneInfo GetByPhone(System.String phone)
        {
            var criteria = new BaseVouchPhoneCriteria {Phone = phone};
            
            
            return DataPortal.Fetch<BaseVouchPhoneInfo>(criteria);
        }

        #endregion

        #region Asynchronous Factory Methods

        public static void GetByIdentificationAsync(System.String identification, EventHandler<DataPortalResult<BaseVouchPhoneInfo>> handler)
        {
            var criteria = new BaseVouchPhoneCriteria{Identification = identification};
            
            
            var dp = new DataPortal<BaseVouchPhoneInfo>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        public static void GetByPhoneAsync(System.String phone, EventHandler<DataPortalResult<BaseVouchPhoneInfo>> handler)
        {
            var criteria = new BaseVouchPhoneCriteria{Phone = phone};
            
            
            var dp = new DataPortal<BaseVouchPhoneInfo>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        #endregion

        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the <see cref="BaseVouchPhoneInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchPhoneInfo"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the <see cref="BaseVouchPhoneInfo"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BaseVouchPhoneInfoCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(BaseVouchPhoneCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchPhoneInfo"/> object has been fetched. 
        /// </summary>    
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="BaseVouchPhoneInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);
 
        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="BaseVouchPhoneInfo"/> object. 
        /// </summary>
        /// <param name="reader["></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchPhoneInfo"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the <see cref="BaseVouchPhoneInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnInserting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchPhoneInfo"/> object has been inserted. 
        /// </summary>
        partial void OnInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="BaseVouchPhoneInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchPhoneInfo"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the <see cref="BaseVouchPhoneInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchPhoneInfo"/> object has been deleted. 
        /// </summary>
        partial void OnSelfDeleted();

        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the <see cref="BaseVouchPhoneInfo"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BaseVouchPhoneInfoCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(BaseVouchPhoneCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseVouchPhoneInfo"/> object with the specified criteria has been deleted. 
        /// </summary>
        partial void OnDeleted();
        partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion

        #region Exists Command

        /// <summary>
        /// Determines if a record exists in the base_vouch_phone table in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is an <see cref="BaseVouchPhoneInfo"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static bool Exists(BaseVouchPhoneCriteria criteria)
        {
            return vjf.SyncTool.Business.ExistsCommand.Execute(criteria);
        }

        /// <summary>
        /// Determines if a record exists in the base_vouch_phone table in the database for the specified criteria. 
        /// </summary>
        public static void ExistsAsync(BaseVouchPhoneCriteria criteria, EventHandler<DataPortalResult<ExistsCommand>> handler)
        {
            vjf.SyncTool.Business.ExistsCommand.ExecuteAsync(criteria, handler);
        }

        #endregion

    }
}