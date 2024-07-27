using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using WonderCircuits.Ddd.Domain;
using WonderCircuits.ObjectModel.Services;

namespace WonderCircuits.ObjectModel
{
    public abstract class InterfaceBase : EntityBase, IInterface
    {
        private readonly IInterfaceType InterfaceType;
        private readonly Dictionary<string, IAttribute> Attrs = new Dictionary<string, IAttribute>();
        public InterfaceBase(string typeName)
        {
            var interfaceTypeService = Services.GetService<IInterfaceTypeService>();
            InterfaceType = interfaceTypeService.FindByName(typeName);
            InitializeAttributes(typeName);
        }

        public string Name { get => InterfaceType.Name; }

        public IEnumerable<IAttribute> GetAttributes()
        {
            return Attrs.Values;
        }
        public int GetAttributesCount() => Attrs.Count;
        public IAttribute GetAttribute(string name)
        {
            if (Attrs.TryGetValue(name, out var attr))
            {
                return attr;
            }
            return null;
        }
        public bool HasAttribute(string name)
        {
            return Attrs.ContainsKey(name);
        }
        public bool TryGetAttribute(string name, out IAttribute attr)
        {
            return Attrs.TryGetValue(name, out attr);
        }

        private void InitializeAttributes(string typeName)
        {
            var attributeTypeService = Services.GetService<IAttributeTypeService>();
            //todo: get all attributes and create instance
        }
    }


    public interface IInterface
    {
        string Name { get; }

        IEnumerable<IAttribute> GetAttributes();
        int GetAttributesCount();
        IAttribute GetAttribute(string name);
        bool HasAttribute(string name);
        bool TryGetAttribute(string name, out IAttribute attr);
    }
    public interface IAttribute
    {

    }

}
