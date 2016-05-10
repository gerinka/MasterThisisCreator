﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Entity Framework EntityObject template.
// Code is generated on: 5/9/2016 4:32:41 PM
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
    /// There are no comments for MtcModel.STRUCTUREELEMENT in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="MtcModel", Name="STRUCTUREELEMENT")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class STRUCTUREELEMENT : EntityObject    {
        #region Factory Method

        /// <summary>
        /// Create a new STRUCTUREELEMENT object.
        /// </summary>
        /// <param name="id">Initial value of Id.</param>
        /// <param name="structureTypeId">Initial value of StructureTypeId.</param>
        public static STRUCTUREELEMENT CreateSTRUCTUREELEMENT(int id, StructureType structureTypeId)
        {
            STRUCTUREELEMENT sTRUCTUREELEMENT = new STRUCTUREELEMENT();
            sTRUCTUREELEMENT.Id = id;
            sTRUCTUREELEMENT.StructureTypeId = structureTypeId;
            return sTRUCTUREELEMENT;
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
        /// There are no comments for Title in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public string Title
        {
            get
            {
                string value = _Title;
                OnGetTitle(ref value);
                return value;
            }
            set
            {
                if (_Title != value)
                {
                  OnTitleChanging(ref value);
                  ReportPropertyChanging("Title");
                  _Title = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Title");
                  OnTitleChanged();
              }
            }
        }
        private string _Title;
        partial void OnGetTitle(ref string value);
        partial void OnTitleChanging(ref string value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// There are no comments for StructureTypeId in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        public StructureType StructureTypeId
        {
            get
            {
                StructureType value = _StructureTypeId;
                OnGetStructureTypeId(ref value);
                return value;
            }
            set
            {
                if (_StructureTypeId != value)
                {
                  OnStructureTypeIdChanging(ref value);
                  ReportPropertyChanging("StructureTypeId");
                  _StructureTypeId = (StructureType)StructuralObject.SetValidValue((int)value);
                  ReportPropertyChanged("StructureTypeId");
                  OnStructureTypeIdChanged();
              }
            }
        }
        private StructureType _StructureTypeId;
        partial void OnGetStructureTypeId(ref StructureType value);
        partial void OnStructureTypeIdChanging(ref StructureType value);
        partial void OnStructureTypeIdChanged();
    
        /// <summary>
        /// There are no comments for Description in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public string Description
        {
            get
            {
                string value = _Description;
                OnGetDescription(ref value);
                return value;
            }
            set
            {
                if (_Description != value)
                {
                  OnDescriptionChanging(ref value);
                  ReportPropertyChanging("Description");
                  _Description = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Description");
                  OnDescriptionChanged();
              }
            }
        }
        private string _Description;
        partial void OnGetDescription(ref string value);
        partial void OnDescriptionChanging(ref string value);
        partial void OnDescriptionChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for STRUCTURECONTENTs in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MtcModel", "FK_StructureElementDocument_Id", "STRUCTURECONTENTs")]
        public EntityCollection<STRUCTURECONTENT> STRUCTURECONTENTs
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<STRUCTURECONTENT>("MtcModel.FK_StructureElementDocument_Id", "STRUCTURECONTENTs");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<STRUCTURECONTENT>("MtcModel.FK_StructureElementDocument_Id", "STRUCTURECONTENTs", value);
                }
            }
        }
    
        /// <summary>
        /// There are no comments for STRUCTUREELEMENTs in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MtcModel", "STRUCTUREELEMENT_STRUCTUREELEMENT", "STRUCTUREELEMENTs")]
        public EntityCollection<STRUCTUREELEMENT> STRUCTUREELEMENTs
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<STRUCTUREELEMENT>("MtcModel.STRUCTUREELEMENT_STRUCTUREELEMENT", "STRUCTUREELEMENTs");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<STRUCTUREELEMENT>("MtcModel.STRUCTUREELEMENT_STRUCTUREELEMENT", "STRUCTUREELEMENTs", value);
                }
            }
        }
    
        /// <summary>
        /// There are no comments for STRUCTUREELEMENTs1 in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MtcModel", "STRUCTUREELEMENT_STRUCTUREELEMENT", "STRUCTUREELEMENTs1")]
        public EntityCollection<STRUCTUREELEMENT> STRUCTUREELEMENTs1
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<STRUCTUREELEMENT>("MtcModel.STRUCTUREELEMENT_STRUCTUREELEMENT", "STRUCTUREELEMENTs1");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<STRUCTUREELEMENT>("MtcModel.STRUCTUREELEMENT_STRUCTUREELEMENT", "STRUCTUREELEMENTs1", value);
                }
            }
        }

        #endregion
    }

}
