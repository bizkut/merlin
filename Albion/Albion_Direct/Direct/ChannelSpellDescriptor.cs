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

namespace Albion_Direct
{
    /* Internal type: g9 */
    public partial class ChannelSpellDescriptor : ActiveSpellDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private g9 _internal;
        
        #region Properties
        
        public g9 ChannelSpellDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public ChannelSpellDescriptor(g9 instance) : base(instance)
        {
            _internal = instance;
        }
        
        static ChannelSpellDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator g9(ChannelSpellDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator ChannelSpellDescriptor(g9 instance)
        {
            return new ChannelSpellDescriptor(instance);
        }
        
        public static implicit operator bool(ChannelSpellDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}