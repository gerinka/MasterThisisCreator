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
    /// There are no comments for MtcModel.Structureelement in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="MtcModel", Name="Structureelement")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Structureelement : EntityObject    {
        #region Factory Method

        /// <summary>
        /// Create a new Structureelement object.
        /// </summary>
        /// <param name="id">Initial value of Id.</param>
        /// <param name="structureTypeId">Initial value of StructureTypeId.</param>
        public static Structureelement CreateStructureelement(int id, int structureTypeId)
        {
            Structureelement structureelement = new Structureelement();
            structureelement.Id = id;
            structureelement.StructureTypeId = structureTypeId;
            return structureelement;
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
        public int StructureTypeId
        {
            get
            {
                int value = _StructureTypeId;
                OnGetStructureTypeId(ref value);
                return value;
            }
            set
            {
                if (_StructureTypeId != value)
                {
                  OnStructureTypeIdChanging(ref value);
                  ReportPropertyChanging("StructureTypeId");
                  _StructureTypeId = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("StructureTypeId");
                  OnStructureTypeIdChanged();
              }
            }
        }
        private int _StructureTypeId;
        partial void OnGetStructureTypeId(ref int value);
        partial void OnStructureTypeIdChanging(ref int value);
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
        /// There are no comments for Structurecontents in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MtcModel", "FK_StructureElementDocument_Id", "Structurecontents")]
        public EntityCollection<Structurecontent> Structurecontents
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Structurecontent>("MtcModel.FK_StructureElementDocument_Id", "Structurecontents");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<Structurecontent>("MtcModel.FK_StructureElementDocument_Id", "Structurecontents", value);
                }
            }
        }
    
        /// <summary>
        /// There are no comments for Documenttemplates in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MtcModel", "Documenttemplate_Structureelement", "Documenttemplates")]
        public EntityCollection<Documenttemplate> Documenttemplates
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Documenttemplate>("MtcModel.Documenttemplate_Structureelement", "Documenttemplates");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<Documenttemplate>("MtcModel.Documenttemplate_Structureelement", "Documenttemplates", value);
                }
            }
        }
    
        /// <summary>
        /// There are no comments for Structureelements in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MtcModel", "Structureelement_Structureelement", "Structureelements")]
        public EntityCollection<Structureelement> Structureelements
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Structureelement>("MtcModel.Structureelement_Structureelement", "Structureelements");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<Structureelement>("MtcModel.Structureelement_Structureelement", "Structureelements", value);
                }
            }
        }
    
        /// <summary>
        /// There are no comments for Structureelements1 in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MtcModel", "Structureelement_Structureelement", "Structureelements1")]
        public EntityCollection<Structureelement> Structureelements1
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Structureelement>("MtcModel.Structureelement_Structureelement", "Structureelements1");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<Structureelement>("MtcModel.Structureelement_Structureelement", "Structureelements1", value);
                }
            }
        }

        #endregion
    }

}
