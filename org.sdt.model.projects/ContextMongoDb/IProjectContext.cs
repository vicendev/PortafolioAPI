using MongoDB.Driver;
using Org.Sdt.Projects.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Org.Sdt.Projects.ContextMongoDb
{
    public interface IProjectContext
    {
        IMongoCollection<Project> Projects { get; }
    }
}
