using System;
using System.Collections.Generic;
using System.Text;

namespace Org.Sdt.Architecture.Core.Entities
{
    /// <summary>
    /// Método trabajo documentos genericos.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class BsonCollectionAttribute : Attribute
    {
        public string CollectionName { get; }

        public BsonCollectionAttribute(string collectionName)
        {
            CollectionName = collectionName;
        }
    }
}
