using System;
using System.Collections.Generic;

namespace staff_qualification_Forms
{
    public class IdHelper
    {
        public static void TryUpdateId<T>(T entity) where T : Id
        {
            if (entity.ID == Guid.Empty)
            {
                entity.ID = Guid.NewGuid();
            }
        }

        public static T GetEntityByID<T>(List<T> entities, Guid id) where T : Id
        {
            T requiredEntity = null;
            foreach (var entity in entities)
            {
                if (entity.ID == id)
                    requiredEntity = entity;
            }
            return requiredEntity;
        }
    }
}
