////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.336.100246-prod
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Reflection;

using Albion.Common.Time;

namespace Albion_Direct
{
    /* Internal type: a3r */
    public partial class HarvestableObject : StaticObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private a3r _internal;
        
        #region Properties
        
        public a3r HarvestableObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public ActionPoint GetActionPoint(Point2 A_0) => _internal.az((ak1)A_0);
        public HarvestableDescriptor GetDescriptor() => _internal.s0();
        public HarvestableChargeDescriptor GetChargeDescriptor() => _internal.s2();
        public long GetCharges() => _internal.tb();
        public long GetMaxCharges() => _internal.tc();
        public GameTimeStamp GetProtectedUntil() => _internal.tf();
        public int GetRareState() => _internal.ta();
        public ItemDescriptor GetResourceDescriptor() => _internal.tg();
        public HarvestableTierDescriptor GetTierDescriptor() => _internal.s1();
        public EquipmentItemProxy GetTool(LocalPlayerCharacter A_0, bool A_1) => _internal.az((ayt)A_0, (bool)A_1);
        public long GetYield() => _internal.td();
        public bool IsHarvestable() => _internal.te();
        
        #endregion
        
        #region Constructor
        
        public HarvestableObject(a3r instance) : base(instance)
        {
            _internal = instance;
        }
        
        static HarvestableObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator a3r(HarvestableObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator HarvestableObject(a3r instance)
        {
            return new HarvestableObject(instance);
        }
        
        public static implicit operator bool(HarvestableObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
