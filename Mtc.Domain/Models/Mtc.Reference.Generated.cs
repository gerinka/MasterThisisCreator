﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Entity Framework EntityObject template.
// Code is generated on: 5/11/2016 4:41:59 PM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;

namespace MtcModel
{

    /// <summary>
    /// There are no comments for MtcModel.Reference in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="MtcModel", Name="Reference")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Reference : EntityObject    {
        #region Factory Method

        /// <summary>
        /// Create a new Reference object.
        /// </summary>
        /// <param name="id">Initial value of Id.</param>
        /// <param name="documentId">Initial value of DocumentId.</param>
        public static Reference CreateReference(int id, int documentId)
        {
            Reference reference = new Reference();
            reference.Id = id;
            reference.DocumentId = documentId;
            return reference;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for Id in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public int Id
        {
            get
            {
                int value = _Id;
                OnGetId(ref value);
                return value;
            }
            set
            {
                if (_Id != value)
                {
                  OnIdChanging(ref value);
                  ReportPropertyChanging("Id");
                  _Id = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("Id");
                  OnIdChanged();
              }
            }
        }
        private int _Id;
        partial void OnGetId(ref int value);
        partial void OnIdChanging(ref int value);
        partial void OnIdChanged();
    
        /// <summary>
        /// There are no comments for ReferenceTypeId in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> ReferenceTypeId
        {
            get
            {
                global::System.Nullable<int> value = _ReferenceTypeId;
                OnGetReferenceTypeId(ref value);
                return value;
            }
            set
            {
                if (_ReferenceTypeId != value)
                {
                  OnReferenceTypeIdChanging(ref value);
                  ReportPropertyChanging("ReferenceTypeId");
                  _ReferenceTypeId = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("ReferenceTypeId");
                  OnReferenceTypeIdChanged();
              }
            }
        }
        private global::System.Nullable<int> _ReferenceTypeId;
        partial void OnGetReferenceTypeId(ref global::System.Nullable<int> value);
        partial void OnReferenceTypeIdChanging(ref global::System.Nullable<int> value);
        partial void OnReferenceTypeIdChanged();
    
        /// <summary>
        /// There are no comments for Name in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public string Name
        {
            get
            {
                string value = _Name;
                OnGetName(ref value);
                return value;
            }
            set
            {
                if (_Name != value)
                {
                  OnNameChanging(ref value);
                  ReportPropertyChanging("Name");
                  _Name = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Name");
                  OnNameChanged();
              }
            }
        }
        private string _Name;
        partial void OnGetName(ref string value);
        partial void OnNameChanging(ref string value);
        partial void OnNameChanged();
    
        /// <summary>
        /// There are no comments for Order in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> Order
        {
            get
            {
                global::System.Nullable<int> value = _Order;
                OnGetOrder(ref value);
                return value;
            }
            set
            {
                if (_Order != value)
                {
                  OnOrderChanging(ref value);
                  ReportPropertyChanging("Order");
                  _Order = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("Order");
                  OnOrderChanged();
              }
            }
        }
        private global::System.Nullable<int> _Order;
        partial void OnGetOrder(ref global::System.Nullable<int> value);
        partial void OnOrderChanging(ref global::System.Nullable<int> value);
        partial void OnOrderChanged();
    
        /// <summary>
        /// There are no comments for DocumentId in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        public int DocumentId
        {
            get
            {
                int value = _DocumentId;
                OnGetDocumentId(ref value);
                return value;
            }
            set
            {
                if (_DocumentId != value)
                {
                  OnDocumentIdChanging(ref value);
                  ReportPropertyChanging("DocumentId");
                  _DocumentId = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("DocumentId");
                  OnDocumentIdChanged();
              }
            }
        }
        private int _DocumentId;
        partial void OnGetDocumentId(ref int value);
        partial void OnDocumentIdChanging(ref int value);
        partial void OnDocumentIdChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for Document in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MtcModel", "FK_ReferenceDocument_Id", "Document")]
        public Document Document
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Document>("MtcModel.FK_ReferenceDocument_Id", "Document").Value;
            }
            set
            {
                ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Document>("MtcModel.FK_ReferenceDocument_Id", "Document").Value = value;
            }
        }
    
        /// <summary>
        /// There are no comments for Document in the schema.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Document> DocumentReference
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Document>("MtcModel.FK_ReferenceDocument_Id", "Document");
            }
            set
            {
                if (value != null)
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<Document>("MtcModel.FK_ReferenceDocument_Id", "Document", value);
                }
                else 
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Document>("MtcModel.FK_ReferenceDocument_Id", "Document").Value = null;
                }
            }
        }

        #endregion
    }

}