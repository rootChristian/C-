using System;
using System.Data.Entity;
using static CodeFirstEntity.Person;

namespace CodeFirstEntity
{
    public class UserDBInitializer : CreateDatabaseIfNotExists<UserContext>
    {
        
    }
}