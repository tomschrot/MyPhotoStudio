
using System;
namespace MyPhotoStudio
{
    public static partial class Extensions
    {
        public static T @apply <T> (this T obj, Action <T> handle)
        {
            handle?.Invoke (obj);
            return obj;
        }
    }
}
