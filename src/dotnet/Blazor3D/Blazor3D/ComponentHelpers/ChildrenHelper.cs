
using HomagGroup.Blazor3D.Core;

namespace HomagGroup.Blazor3D.ComponentHelpers
{
    internal static class ChildrenHelper
    {
        internal static void RemoveObjectByUuid(Guid uuid, List<Object3D> children)
        {
            Object3D? result = null;
            foreach (var child in children)
            {
                if (child.Uuid == uuid)
                {
                    result = child;
                    break;
                }

                if (child.Children.Count > 0)
                {
                    RemoveObjectByUuid(uuid, child.Children);
                };
            }

            if (result != null)
                children.Remove(result);
        }

        internal static Object3D? GetObjectByUuid(Guid uuid, List<Object3D> children)
        {
            Object3D? result = null;
            foreach (var child in children)
            {
                if (child.Uuid == uuid)
                {
                    return child;
                }

                if (child.Children.Count > 0)
                {
                    result = GetObjectByUuid(uuid, child.Children);
                    if (result != null)
                    {
                        return result;
                    }
                };
            }
            return result;
        }
    }
}
