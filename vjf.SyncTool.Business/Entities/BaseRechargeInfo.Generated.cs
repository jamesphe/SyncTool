﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v7.0.1, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'BaseRechargeInfo.cs'.
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
    public partial class BaseRechargeInfo : ReadOnlyBase<BaseRechargeInfo>
    {
        #region Contructor(s)

        public BaseRechargeInfo()
        { /* Require use of factory methods */ }

        #endregion

        #region Properties

        public static readonly PropertyInfo<System.Int32> _identificationProperty = RegisterProperty<System.Int32>(p => p.Identification, "Identification");

        [System.ComponentModel.DataObjectField(true, true)]
        public System.Int32 Identification
        {
            get { return GetProperty(_identificationProperty); }
        }

        public static readonly PropertyInfo<System.String> _orderidProperty = RegisterProperty<System.String>(p => p.Orderid, "Orderid");

        public System.String Orderid
        {
            get { return GetProperty(_orderidProperty); }
        }

        public static readonly PropertyInfo<System.String> _phoneProperty = RegisterProperty<System.String>(p => p.Phone, "Phone", (System.String)null);

        public System.String Phone
        {
            get { return GetProperty(_phoneProperty); }
        }

        public static readonly PropertyInfo<System.String> _carnoProperty = RegisterProperty<System.String>(p => p.Carno, "Carno", (System.String)null);

        public System.String Carno
        {
            get { return GetProperty(_carnoProperty); }
        }

        public static readonly PropertyInfo<System.String> _provinceProperty = RegisterProperty<System.String>(p => p.Province, "Province", (System.String)null);

        public System.String Province
        {
            get { return GetProperty(_provinceProperty); }
        }

        public static readonly PropertyInfo<System.String> _cityProperty = RegisterProperty<System.String>(p => p.City, "City", (System.String)null);

        public System.String City
        {
            get { return GetProperty(_cityProperty); }
        }

        public static readonly PropertyInfo<System.String> _pidProperty = RegisterProperty<System.String>(p => p.Pid, "Pid", (System.String)null);

        public System.String Pid
        {
            get { return GetProperty(_pidProperty); }
        }

        public static readonly PropertyInfo<System.Int32?> _pnumProperty = RegisterProperty<System.Int32?>(p => p.Pnum, "Pnum", (System.Int32?)null);

        public System.Int32? Pnum
        {
            get { return GetProperty(_pnumProperty); }
        }

        public static readonly PropertyInfo<System.Single?> _amountProperty = RegisterProperty<System.Single?>(p => p.Amount, "Amount", (System.Single?)null);

        public System.Single? Amount
        {
            get { return GetProperty(_amountProperty); }
        }

        public static readonly PropertyInfo<System.Single?> _feeProperty = RegisterProperty<System.Single?>(p => p.Fee, "Fee", (System.Single?)null);

        public System.Single? Fee
        {
            get { return GetProperty(_feeProperty); }
        }

        public static readonly PropertyInfo<System.Int16> _statusProperty = RegisterProperty<System.Int16>(p => p.Status, "Status");

        public System.Int16 Status
        {
            get { return GetProperty(_statusProperty); }
        }

        public static readonly PropertyInfo<System.Int16?> _paytypeProperty = RegisterProperty<System.Int16?>(p => p.Paytype, "Paytype", (System.Int16?)null);

        public System.Int16? Paytype
        {
            get { return GetProperty(_paytypeProperty); }
        }

        public static readonly PropertyInfo<System.String> _serialnumProperty = RegisterProperty<System.String>(p => p.Serialnum, "Serialnum", (System.String)null);

        public System.String Serialnum
        {
            get { return GetProperty(_serialnumProperty); }
        }

        public static readonly PropertyInfo<System.Int32?> _activetimeProperty = RegisterProperty<System.Int32?>(p => p.Activetime, "Activetime", (System.Int32?)null);

        public System.Int32? Activetime
        {
            get { return GetProperty(_activetimeProperty); }
        }

        public static readonly PropertyInfo<System.Int16> _expdateProperty = RegisterProperty<System.Int16>(p => p.Expdate, "Expdate");

        public System.Int16 Expdate
        {
            get { return GetProperty(_expdateProperty); }
        }

        public static readonly PropertyInfo<System.String> _cardnoProperty = RegisterProperty<System.String>(p => p.Cardno, "Cardno", (System.String)null);

        public System.String Cardno
        {
            get { return GetProperty(_cardnoProperty); }
        }

        public static readonly PropertyInfo<System.String> _protypeProperty = RegisterProperty<System.String>(p => p.Protype, "Protype");

        public System.String Protype
        {
            get { return GetProperty(_protypeProperty); }
        }

        public static readonly PropertyInfo<System.String> _remarkProperty = RegisterProperty<System.String>(p => p.Remark, "Remark", (System.String)null);

        public System.String Remark
        {
            get { return GetProperty(_remarkProperty); }
        }

        public static readonly PropertyInfo<System.Int32?> _createdProperty = RegisterProperty<System.Int32?>(p => p.Created, "Created", (System.Int32?)null);

        public System.Int32? Created
        {
            get { return GetProperty(_createdProperty); }
        }

        public static readonly PropertyInfo<System.String> _createidProperty = RegisterProperty<System.String>(p => p.Createid, "Createid", (System.String)null);

        public System.String Createid
        {
            get { return GetProperty(_createidProperty); }
        }

        public static readonly PropertyInfo<System.Int16> _ispayProperty = RegisterProperty<System.Int16>(p => p.Ispay, "Ispay");

        public System.Int16 Ispay
        {
            get { return GetProperty(_ispayProperty); }
        }

        public static readonly PropertyInfo<System.Int32> _paytimeProperty = RegisterProperty<System.Int32>(p => p.Paytime, "Paytime");

        public System.Int32 Paytime
        {
            get { return GetProperty(_paytimeProperty); }
        }

        public static readonly PropertyInfo<System.String> _areaProperty = RegisterProperty<System.String>(p => p.Area, "Area");

        public System.String Area
        {
            get { return GetProperty(_areaProperty); }
        }


        #endregion

        #region Synchronous Factory Methods 

        internal static BaseRechargeInfo GetBaseRechargeInfo(SafeDataReader reader)
        {
            return DataPortal.FetchChild<BaseRechargeInfo>(reader);
        }

        /// <summary>
        /// Returns a <see cref="BaseRechargeInfo"/> object of the specified criteria. 
        /// </summary>
        /// <param name="identification">No additional detail available.</param>
        /// <returns>A <see cref="BaseRechargeInfo"/> object of the specified criteria.</returns>
        public static BaseRechargeInfo GetByIdentification(System.Int32 identification)
        {
            var criteria = new BaseRechargeCriteria {Identification = identification};
            
            
            return DataPortal.Fetch<BaseRechargeInfo>(criteria);
        }

        #endregion

        #region Asynchronous Factory Methods

        public static void GetByIdentificationAsync(System.Int32 identification, EventHandler<DataPortalResult<BaseRechargeInfo>> handler)
        {
            var criteria = new BaseRechargeCriteria{Identification = identification};
            
            
            var dp = new DataPortal<BaseRechargeInfo>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        #endregion

        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the <see cref="BaseRechargeInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseRechargeInfo"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the <see cref="BaseRechargeInfo"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BaseRechargeInfoCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(BaseRechargeCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseRechargeInfo"/> object has been fetched. 
        /// </summary>    
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="BaseRechargeInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);
 
        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="BaseRechargeInfo"/> object. 
        /// </summary>
        /// <param name="reader["></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseRechargeInfo"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the <see cref="BaseRechargeInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnInserting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseRechargeInfo"/> object has been inserted. 
        /// </summary>
        partial void OnInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="BaseRechargeInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseRechargeInfo"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the <see cref="BaseRechargeInfo"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseRechargeInfo"/> object has been deleted. 
        /// </summary>
        partial void OnSelfDeleted();

        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the <see cref="BaseRechargeInfo"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="BaseRechargeInfoCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(BaseRechargeCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="BaseRechargeInfo"/> object with the specified criteria has been deleted. 
        /// </summary>
        partial void OnDeleted();
        partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion

        #region Exists Command

        /// <summary>
        /// Determines if a record exists in the base_recharge table in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is an <see cref="BaseRechargeInfo"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static bool Exists(BaseRechargeCriteria criteria)
        {
            return vjf.SyncTool.Business.ExistsCommand.Execute(criteria);
        }

        /// <summary>
        /// Determines if a record exists in the base_recharge table in the database for the specified criteria. 
        /// </summary>
        public static void ExistsAsync(BaseRechargeCriteria criteria, EventHandler<DataPortalResult<ExistsCommand>> handler)
        {
            vjf.SyncTool.Business.ExistsCommand.ExecuteAsync(criteria, handler);
        }

        #endregion

    }
}