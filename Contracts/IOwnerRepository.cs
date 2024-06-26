﻿using Entities.Helpers;
using Entities.Models;
using System;

namespace Contracts
{
    public interface IOwnerRepository : IRepositoryBase<Owner>
    {
        PagedList<Entity> GetOwners(OwnerParameters ownerParameters);
        Entity GetOwnerById(Guid ownerId, string fields);
        Owner GetOwnerById(Guid ownerId);
        void CreateOwner(Owner owner);
        void UpdateOwner(Owner dbOwner, Owner owner);
        void DeleteOwner(Owner owner);
    }
}
